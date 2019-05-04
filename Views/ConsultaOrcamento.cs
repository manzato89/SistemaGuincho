﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;
using SistemaGuincho.Utilidades;

namespace SistemaGuincho.Views {
    public partial class ConsultaOrcamento : Form {

        #region Atributos da classe
        private List<Orcamento> orcamentos;
        private List<Orcamento> orcamentos_view;

        private Util.TipoConsulta tpConsulta;

        public Orcamento orcamentoSelecionado;

        private Views.Orcamentos formOrcamento;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();
        }

        public ConsultaOrcamento(Util.TipoConsulta tpConsulta) {
            init();

            this.tpConsulta = tpConsulta;
        }

        private void getFromRepositorio() {
            orcamentos = OrcamentoRepositorio.Instance.read();

            orcamentos_view = new List<Model.Orcamento>(orcamentos);
        }

        private void ConsultaOrcamento_Load(object sender, EventArgs e) {
            getFromRepositorio();

            refreshDataGridView();

            //Preenche o ComboBox da busca
            cboCamposBusca.Items.Add("Cliente");
            cboCamposBusca.Items.Add("Número");
            cboCamposBusca.Items.Add("Veículo");
            cboCamposBusca.Items.Add("Valor");
            cboCamposBusca.Items.Add("Fechado? (S/N)");
            cboCamposBusca.SelectedIndex = 0;
        }
        #endregion

        #region Interfaces - Comum
        private void clearDataGridView() {
            // Seta o datagrid view como nulo
            dgvOrcamentos.DataSource = null;
            dgvOrcamentos.Refresh();
        }

        private void refreshDataGridView() {
            clearDataGridView();

            dgvOrcamentos.Columns.Clear();

            dgvOrcamentos.DataSource = orcamentos_view;

            dgvOrcamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "Valor_custom" });

            // Preenche os nomes das colunas
            for (var iCount = 0; iCount < dgvOrcamentos.Columns.Count; iCount++) {
                switch (dgvOrcamentos.Columns[iCount].DataPropertyName) {
                    case nameof(Orcamento.custosAdicionais):
                    case nameof(Orcamento.servicos):
                        dgvOrcamentos.Columns[iCount].Visible = false;
                        break;

                    case nameof(Orcamento.id):
                        dgvOrcamentos.Columns[iCount].DisplayIndex = 0;
                        dgvOrcamentos.Columns[iCount].HeaderText = "Número";
                        dgvOrcamentos.Columns[iCount].Width = 75;
                        dgvOrcamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Orcamento.cliente):
                        dgvOrcamentos.Columns[iCount].DisplayIndex = 1;
                        dgvOrcamentos.Columns[iCount].HeaderText = "Cliente";
                        dgvOrcamentos.Columns[iCount].Width = 275;
                        dgvOrcamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Orcamento.veiculo):
                        dgvOrcamentos.Columns[iCount].DisplayIndex = 2;
                        dgvOrcamentos.Columns[iCount].HeaderText = "Veículo";
                        dgvOrcamentos.Columns[iCount].Width = 250;
                        dgvOrcamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case "Valor_custom":
                        dgvOrcamentos.Columns[iCount].Name = dgvOrcamentos.Columns[iCount].DataPropertyName;
                        dgvOrcamentos.Columns[iCount].DisplayIndex = 3;
                        dgvOrcamentos.Columns[iCount].HeaderText = "Valor";
                        dgvOrcamentos.Columns[iCount].Width = 175;
                        dgvOrcamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Orcamento.fechado):
                        dgvOrcamentos.Columns[iCount].DisplayIndex = 4;
                        dgvOrcamentos.Columns[iCount].HeaderText = "Fechado";
                        dgvOrcamentos.Columns[iCount].Width = 100;
                        dgvOrcamentos.Columns[iCount].ReadOnly = true;
                        break;
                }
            }

            //Preenche os campos que vieram sem preenchimento do data set
            for (var iCount = 0; iCount < dgvOrcamentos.Rows.Count; iCount++) {
                //Placa (Cidade - Estado)
                dgvOrcamentos.Rows[iCount].Cells["Valor_custom"].Value = Util.formatValor(orcamentos_view[iCount].valorTotal());
            }

            dgvOrcamentos.Refresh();

        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                busca();
            }
        }

        private void busca() {
            string textoBusca = txtBusca.Text.ToUpper();

            if (textoBusca.Length == 0) {
                orcamentos_view = new List<Model.Orcamento>(orcamentos);
            } else {
                switch (cboCamposBusca.SelectedIndex) {
                    case 0: // Cliente
                        orcamentos_view = orcamentos.FindAll(find => find.cliente.nome.ToUpper().Contains(textoBusca));
                        break;
                    case 1: // Número
                        int idDesejado;

                        if (Int32.TryParse(textoBusca, out idDesejado)) {
                            orcamentos_view = orcamentos.FindAll(find => find.id == idDesejado);
                        }
                        break;
                    case 2: // Veículo
                        orcamentos_view = orcamentos.FindAll(find => find.veiculo != null && find.veiculo.ToString().ToUpper().Contains(textoBusca));
                        break;
                    case 3: // Valor
                        float valorDesejado = -1;

                        // Procura apenas pela parte inteira do valor
                        if (float.TryParse(textoBusca, out valorDesejado))
                            orcamentos_view = orcamentos.FindAll(find => (find.valorTotal() - find.valorTotal() % 1) == valorDesejado);
                        break;
                    case 4: // Fechado
                        bool buscaFechado = textoBusca.ToUpper().Equals("S");

                        orcamentos_view = orcamentos.FindAll(find => find.fechado == buscaFechado);
                        break;
                }
            }

            refreshDataGridView();
        }

        private void dgvOrcamentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                Orcamento orcamento = orcamentos_view[e.RowIndex];

                if (tpConsulta == Util.TipoConsulta.Edicao) {
                    formOrcamento = new Orcamentos(orcamento);
                    formOrcamento.Load += FormOrcamento_Load;
                    formOrcamento.Show();
                }else if (tpConsulta == Util.TipoConsulta.Selecao) {
                    orcamentoSelecionado = orcamento;
                    this.Close();
                }
            }
        }

        private void FormOrcamento_Load(object sender, EventArgs e) {
            if (tpConsulta == Util.TipoConsulta.Edicao)
                this.Close();
        }

        #endregion
    }
}