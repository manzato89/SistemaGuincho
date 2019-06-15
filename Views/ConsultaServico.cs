using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;
using SistemaGuincho.Utilidades;

namespace SistemaGuincho.Views {
    public partial class ConsultaServico : Form {

        #region Atributos da classe
        private List<Servico> servicos;
        private List<Servico> servicos_view;

        private Util.TipoConsulta tpConsulta;

        public Servico servicoSelecionado;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();
        }

        public ConsultaServico(Util.TipoConsulta tpConsulta, string titulo) {
            init();

            this.tpConsulta = tpConsulta;

            Tag = titulo;
            switch (titulo) {
                case nameof(Orcamento.servicos):
                    this.Text = "Consulta de serviços";
                    break;

                case nameof(Orcamento.custosAdicionais):
                    this.Text = "Consulta de custos adicionais";
                    break;
            }
        }

        private void getFromRepositorio() {
            servicos = ServicoRepositorio.Instance.read();

            servicos_view = new List<Model.Servico>(servicos);
        }

        private void ConsultaServico_Load(object sender, EventArgs e) {
            getFromRepositorio();

            refreshDataGridView();

            //Preenche o ComboBox da busca
            cboCamposBusca.Items.Add("Descrição");
            cboCamposBusca.Items.Add("Unidade");
            cboCamposBusca.Items.Add("Valor");
            cboCamposBusca.Items.Add("ID");
            cboCamposBusca.SelectedIndex = 0;

            toolTip1.SetToolTip(txtBusca, "Tecle ENTER para realizar a busca");
            toolTip1.SetToolTip(cboCamposBusca, "Tecle ENTER para realizar a busca");
        }
        #endregion

        #region Interfaces - Comum
        private void clearDataGridView() {
            // Seta o datagrid view como nulo
            dgvClientes.DataSource = null;
            dgvClientes.Refresh();
        }

        private void refreshDataGridView() {
            clearDataGridView();

            dgvClientes.Columns.Clear();

            dgvClientes.DataSource = servicos_view;

            // Preenche os nomes das colunas
            for (var iCount = 0; iCount < dgvClientes.Columns.Count; iCount++) {
                switch (dgvClientes.Columns[iCount].DataPropertyName) {
                    case nameof(Servico._quantidade):
                    case nameof(Servico._idUnidade):
                    case nameof(Servico._idServicoOrcFat):
                    case nameof(Servico._total):
                        dgvClientes.Columns[iCount].Visible = false;
                        break;

                    case nameof(Servico.id):
                        dgvClientes.Columns[iCount].DisplayIndex = 0;
                        dgvClientes.Columns[iCount].HeaderText = "ID";
                        dgvClientes.Columns[iCount].Width = 25;
                        dgvClientes.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Servico.descricao):
                        dgvClientes.Columns[iCount].DisplayIndex = 1;
                        dgvClientes.Columns[iCount].HeaderText = "Descrição";
                        dgvClientes.Columns[iCount].Width = 250;
                        dgvClientes.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Servico.unidade):
                        dgvClientes.Columns[iCount].DisplayIndex = 2;
                        dgvClientes.Columns[iCount].HeaderText = "Unidade";
                        dgvClientes.Columns[iCount].Width = 100;
                        dgvClientes.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Servico.valor):
                        dgvClientes.Columns[iCount].DisplayIndex = 3;
                        dgvClientes.Columns[iCount].HeaderText = "Valor";
                        dgvClientes.Columns[iCount].Width = 100;
                        dgvClientes.Columns[iCount].ReadOnly = true;
                        break;
                }
            }

            dgvClientes.Refresh();

        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                busca();
            }
        }

        private void busca() {
            string textoBusca = txtBusca.Text.ToUpper();

            if (textoBusca.Length == 0) {
                servicos_view = new List<Model.Servico>(servicos);
            } else {
                switch (cboCamposBusca.SelectedIndex) {
                    case 0: // Descrição
                        servicos_view = servicos.FindAll(find => find.descricao.ToUpper().Contains(textoBusca));
                        break;
                    case 1: // Unidade
                        servicos_view = servicos.FindAll(find => find.unidade.codigo.ToUpper().Contains(textoBusca) || find.unidade.descricao.ToUpper().Contains(textoBusca));
                        break;
                    case 2: // Valor
                        float valorDesejado = -1;

                        // Procura apenas pela parte inteira do valor
                        if (float.TryParse(textoBusca, out valorDesejado))
                            servicos_view = servicos.FindAll(find => (find.valor - find.valor % 1) == valorDesejado);
                        break;
                    case 3: // ID
                        int idDesejado = -1;

                        if (int.TryParse(textoBusca, out idDesejado))
                            servicos_view = servicos.FindAll(find => find.id == idDesejado);

                        break;
                }
            }

            refreshDataGridView();
        }

        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                Servico servico = servicos_view[e.RowIndex];

                if (tpConsulta == Util.TipoConsulta.Selecao) {
                    servicoSelecionado = servico;
                    this.Close();
                }
            }
        }

        #endregion
    }
}