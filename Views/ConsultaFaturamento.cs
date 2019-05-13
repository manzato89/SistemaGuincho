using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;
using SistemaGuincho.Utilidades;

namespace SistemaGuincho.Views {
    public partial class ConsultaFaturamento : Form {

        #region Atributos da classe
        private List<Faturamento> faturamentos;
        private List<Faturamento> faturamentos_view;

        private Util.TipoConsulta tpConsulta;

        public Faturamento faturamentoSelecionado;

        private Faturamentos formFaturamento;

        private bool apenasFechado;
        private int idCliente;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();
        }

        public ConsultaFaturamento(Util.TipoConsulta tpConsulta, bool apenasFechado = false, int idCliente = -1) {
            init();

            this.tpConsulta = tpConsulta;
            this.apenasFechado = apenasFechado;
            this.idCliente = idCliente;
        }

        private void getFromRepositorio() {
            if (apenasFechado && idCliente > -1)
                faturamentos = FaturamentoRepositorio.Instance.read(String.Format("fechado = 1 AND _idCliente = {0}", idCliente));
            else if (apenasFechado)
                faturamentos = FaturamentoRepositorio.Instance.read("fechado = 1");
            else if (idCliente > -1)
                faturamentos = FaturamentoRepositorio.Instance.read(String.Format("_idCliente = {0}", idCliente));
            else
                faturamentos = FaturamentoRepositorio.Instance.read();

            faturamentos_view = new List<Model.Faturamento>(faturamentos);
        }

        private void ConsultaFaturamento_Load(object sender, EventArgs e) {
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
            dgvFaturamentos.DataSource = null;
            dgvFaturamentos.Refresh();
        }

        private void refreshDataGridView() {
            clearDataGridView();

            dgvFaturamentos.Columns.Clear();

            dgvFaturamentos.DataSource = faturamentos_view;

            dgvFaturamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "Valor_custom" });
            dgvFaturamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "DataCriacao_custom" });
            dgvFaturamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "DataEncerramento_custom" });

            // Preenche os nomes das colunas
            for (var iCount = 0; iCount < dgvFaturamentos.Columns.Count; iCount++) {
                switch (dgvFaturamentos.Columns[iCount].DataPropertyName) {
                    case nameof(Faturamento.custosAdicionais):
                    case nameof(Faturamento.servicos):
                    case nameof(Faturamento.dataCriacao):
                    case nameof(Faturamento.dataEncerramento):
                    case nameof(Faturamento._idCliente):
                    case nameof(Faturamento._idVeiculo):
                        dgvFaturamentos.Columns[iCount].Visible = false;
                        break;

                    case nameof(Faturamento.id):
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 0;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Número";
                        dgvFaturamentos.Columns[iCount].Width = 75;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Faturamento.cliente):
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 1;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Cliente";
                        dgvFaturamentos.Columns[iCount].Width = 275;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Faturamento.veiculo):
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 2;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Veículo";
                        dgvFaturamentos.Columns[iCount].Width = 250;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case "Valor_custom":
                        dgvFaturamentos.Columns[iCount].Name = dgvFaturamentos.Columns[iCount].DataPropertyName;
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 3;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Valor";
                        dgvFaturamentos.Columns[iCount].Width = 100;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Faturamento.fechado):
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 4;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Fechado";
                        dgvFaturamentos.Columns[iCount].Width = 75;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case "DataCriacao_custom":
                        dgvFaturamentos.Columns[iCount].Name = dgvFaturamentos.Columns[iCount].DataPropertyName;
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 5;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Criação";
                        dgvFaturamentos.Columns[iCount].Width = 100;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case "DataEncerramento_custom":
                        dgvFaturamentos.Columns[iCount].Name = dgvFaturamentos.Columns[iCount].DataPropertyName;
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 6;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Encerramento";
                        dgvFaturamentos.Columns[iCount].Width = 100;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;
                }
            }

            //Preenche os campos que vieram sem preenchimento do data set
            for (var iCount = 0; iCount < dgvFaturamentos.Rows.Count; iCount++) {
                dgvFaturamentos.Rows[iCount].Cells["Valor_custom"].Value = Util.formatValor(faturamentos_view[iCount].valorTotal());
                dgvFaturamentos.Rows[iCount].Cells["DataCriacao_custom"].Value = faturamentos_view[iCount].dataCriacao.ToString("dd/MM/yyyy");
                dgvFaturamentos.Rows[iCount].Cells["DataEncerramento_custom"].Value = faturamentos_view[iCount].dataEncerramento?.ToString("dd/MM/yyyy");
            }

            dgvFaturamentos.Refresh();

        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                busca();
            }
        }

        private void busca() {
            string textoBusca = txtBusca.Text.ToUpper();

            if (textoBusca.Length == 0) {
                faturamentos_view = new List<Model.Faturamento>(faturamentos);
            } else {
                switch (cboCamposBusca.SelectedIndex) {
                    case 0: // Cliente
                        faturamentos_view = faturamentos.FindAll(find => find.cliente.nome.ToUpper().Contains(textoBusca));
                        break;
                    case 1: // Número
                        int idDesejado;

                        if (Int32.TryParse(textoBusca, out idDesejado)) {
                            faturamentos_view = faturamentos.FindAll(find => find.id == idDesejado);
                        }
                        break;
                    case 2: // Veículo
                        faturamentos_view = faturamentos.FindAll(find => find.veiculo != null && find.veiculo.ToString().ToUpper().Contains(textoBusca));
                        break;
                    case 3: // Valor
                        float valorDesejado = -1;

                        // Procura apenas pela parte inteira do valor
                        if (float.TryParse(textoBusca, out valorDesejado))
                            faturamentos_view = faturamentos.FindAll(find => (find.valorTotal() - find.valorTotal() % 1) == valorDesejado);
                        break;
                    case 4: // Fechado
                        bool buscaFechado = textoBusca.ToUpper().Equals("S");

                        faturamentos_view = faturamentos.FindAll(find => find.fechado == buscaFechado);
                        break;
                }
            }

            refreshDataGridView();
        }

        private void dgvFaturamentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                Faturamento faturamento = faturamentos_view[e.RowIndex];

                if (tpConsulta == Util.TipoConsulta.Edicao) {
                    formFaturamento = new Faturamentos(faturamento);
                    formFaturamento.Load += FormFaturamento_Load;
                    formFaturamento.Show();
                }else if (tpConsulta == Util.TipoConsulta.Selecao) {
                    faturamentoSelecionado = faturamento;
                    this.Close();
                }
            }
        }

        private void FormFaturamento_Load(object sender, EventArgs e) {
            if (tpConsulta == Util.TipoConsulta.Edicao)
                this.Close();
        }

        #endregion
    }
}