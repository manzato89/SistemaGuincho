using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaGuincho.Model;
using SistemaGuincho.Servicos;
using SistemaGuincho.Utilidades;

namespace SistemaGuincho.Views {
    public partial class ConsultaCliente : Form {

        #region Atributos da classe
        private List<Model.Cliente> clientes;
        private List<Model.Cliente> clientes_view;

        private Utilidades.Util.TipoConsulta tpConsulta;

        public Cliente clienteSelecionado;

        private Views.Clientes formCliente;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();
        }

        public ConsultaCliente(Util.TipoConsulta tpConsulta) {
            init();

            this.tpConsulta = tpConsulta;
        }

        private void getFromRepositorio() {
            clientes = ClienteServicos.Instance.read();

            clientes_view = new List<Model.Cliente>(clientes);
        }

        private void ConsultaCliente_Load(object sender, EventArgs e) {
            getFromRepositorio();

            refreshDataGridView();

            //Preenche o ComboBox da busca
            cboCamposBusca.Items.Add("Nome");
            cboCamposBusca.Items.Add("Código");
            cboCamposBusca.Items.Add("Veículo");
            cboCamposBusca.Items.Add("Placa do veículo");
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

            dgvClientes.DataSource = clientes_view;

            dgvClientes.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "Modelo_custom" });
            dgvClientes.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "Placa_custom" });

            // Preenche os nomes das colunas
            for (var iCount = 0; iCount < dgvClientes.Columns.Count; iCount++) {
                switch (dgvClientes.Columns[iCount].DataPropertyName) {
                    case nameof(Cliente.cpf):
                    case nameof(Cliente.rg):
                    case nameof(Cliente.endereco):
                    case nameof(Cliente.veiculos):
                    case nameof(Cliente.dataNascimento):
                    case nameof(Cliente.email):
                    case nameof(Cliente.fone1):
                    case nameof(Cliente.fone2):
                    case nameof(Cliente._idEndereco):
                        dgvClientes.Columns[iCount].Visible = false;
                        break;

                    case nameof(Cliente.id):
                        dgvClientes.Columns[iCount].DisplayIndex = 0;
                        dgvClientes.Columns[iCount].HeaderText = "Código";
                        dgvClientes.Columns[iCount].Width = 75;
                        dgvClientes.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Cliente.nome):
                        dgvClientes.Columns[iCount].DisplayIndex = 1;
                        dgvClientes.Columns[iCount].HeaderText = "Nome";
                        dgvClientes.Columns[iCount].Width = 275;
                        dgvClientes.Columns[iCount].ReadOnly = true;
                        break;

                    case "Modelo_custom":
                        dgvClientes.Columns[iCount].Name = dgvClientes.Columns[iCount].DataPropertyName;
                        dgvClientes.Columns[iCount].DisplayIndex = 2;
                        dgvClientes.Columns[iCount].HeaderText = "Veículos";
                        dgvClientes.Columns[iCount].Width = 250;
                        dgvClientes.Columns[iCount].ReadOnly = true;
                        break;

                    case "Placa_custom":
                        dgvClientes.Columns[iCount].Name = dgvClientes.Columns[iCount].DataPropertyName;
                        dgvClientes.Columns[iCount].DisplayIndex = 3;
                        dgvClientes.Columns[iCount].HeaderText = "Placas";
                        dgvClientes.Columns[iCount].Width = 175;
                        dgvClientes.Columns[iCount].ReadOnly = true;
                        break;
                }
            }

            //Preenche os campos que vieram sem preenchimento do data set
            for (var iCount = 0; iCount < dgvClientes.Rows.Count; iCount++) {
                //Modelo - Ano - Cor
                dgvClientes.Rows[iCount].Cells["Modelo_custom"].Value = clientes_view[iCount].getModeloVeiculos();

                //Placa (Cidade - Estado)
                dgvClientes.Rows[iCount].Cells["Placa_custom"].Value = clientes_view[iCount].getPlacaVeiculos();
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
                clientes_view = new List<Model.Cliente>(clientes);
            } else {
                switch (cboCamposBusca.SelectedIndex) {
                    case 0: // Nome
                        clientes_view = clientes.FindAll(find => find.nome.ToUpper().Contains(textoBusca));
                        break;
                    case 1: // Código
                        int idDesejado;

                        if (Int32.TryParse(textoBusca, out idDesejado)) {
                            clientes_view = clientes.FindAll(find => find.id == idDesejado);
                        }
                        break;
                    case 2: // Veículo
                        clientes_view = clientes.FindAll(find => find.getModeloVeiculos().ToUpper().Contains(textoBusca));
                        break;
                    case 3: // Placa do veículo
                        clientes_view = clientes.FindAll(find => find.getPlacaVeiculos().ToUpper().Contains(textoBusca));
                        break;
                }
            }

            refreshDataGridView();
        }

        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                Cliente cliente = clientes_view[e.RowIndex];

                if (tpConsulta == Util.TipoConsulta.Edicao) {

                    formCliente = new Views.Clientes(cliente);
                    formCliente.Load += FormCliente_Load;
                    formCliente.Show();
                }else if (tpConsulta == Util.TipoConsulta.Selecao) {
                    clienteSelecionado = cliente;
                    this.Close();
                }
            }
        }

        private void FormCliente_Load(object sender, EventArgs e) {
            if (tpConsulta == Util.TipoConsulta.Edicao)
                this.Close();
        }

        #endregion
    }
}