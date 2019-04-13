using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGuincho.Model;
using SistemaGuincho.Utilidades;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Views {
    public partial class Cliente : Form{

        #region Atributos da classe
        private Util.WindowMode windowMode;

        private Model.Cliente cliente;
        private List<Model.Cliente> clientes;

        private int index;
        #endregion

        #region Construtor
        private void init() {
            InitializeComponent();
            CenterToScreen();

            index = 0;

            clientes = new List<Model.Cliente>();

            windowMode = Util.WindowMode.ModoCriacaoForm;
        }

        public Cliente(){
            init();

            clientes = ClienteRepositorio.getClientes();
        }
        #endregion

        #region Botões de navegação
        private void btnPrimeiro_Click(object sender, EventArgs e) {
            if (clientes.Count > 0) {
                index = 0;
                selecionaCliente();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if (index - 1 >= 0) {
                index--;
                selecionaCliente();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e) {
            if (index + 1 < clientes.Count) {
                index++;
                selecionaCliente();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            if (clientes.Count > 0) {
                index = clientes.Count - 1;
                selecionaCliente();
            }
        }

        private void selecionaCliente() {
            cliente = clientes[index];
            fillFields();
        }
        #endregion

        #region CRUD
        private void btnAdicionar_Click(object sender, EventArgs e) {
            txtNome.Focus();
            clearFields();

            windowMode = Util.WindowMode.ModoDeInsercao;
            windowModeChanged();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            clearFields();

            windowMode = Util.WindowMode.ModoNormal;
            windowModeChanged();
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            windowMode = Util.WindowMode.ModoNormal;
            windowModeChanged();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            clearFields();
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            clientes = new List<Model.Cliente>();

            refreshDataGridView();
        }

        #endregion

        #region Interfaces - Comum
        private void fillFields() {
            if (cliente != null) {
                // Preenche as informações básicas do cliente
                txtNome.Text = cliente.nome;
                txtCPF.Text = cliente.cpf;
                txtRG.Text = cliente.rg;
                txtDtNascimento.Text = cliente.dataNascimento.ToString("dd/MM/yyyy");

                // Preenche as informações do endereço do cliente
                txtEndereco.Text = cliente.endereco.logradouro;
                txtCEP.Text = cliente.endereco.cep.ToString();
                txtBairro.Text = cliente.endereco.bairro;
                txtCidade.Text = cliente.endereco.cidade;
                txtUF.Text = cliente.endereco.uf;

                // Preenche as informações de contato do cliente
                txtEmail.Text = cliente.email;
                txtFone1.Text = String.Format("({0}) {1}", cliente.dddFone1.ToString(), cliente.fone1.ToString());
                txtFone2.Text = String.Format("({0}) {1}", cliente.dddFone2.ToString(), cliente.fone2.ToString());


                refreshDataGridView();
                windowMode = Util.WindowMode.ModoNormal;
                windowModeChanged();

                // Atualiza o nome do formulário
                this.Text = String.Format("Cliente: {0} - {1}", cliente.id, cliente.nome);

            }
        }

        private void refreshDataGridView() {
            // Seta o datagrid view como nulo
            dgvVeiculos.DataSource = null;
            dgvVeiculos.Refresh();

            // Verifica se o cliente existe
            if (cliente != null) {

                dgvVeiculos.DataSource = cliente.veiculos;

                // Preenche os nomes das colunas
                for (var iCount = 0; iCount < dgvVeiculos.Columns.Count; iCount++) {
                    switch (dgvVeiculos.Columns[iCount].DataPropertyName) {
                        case nameof(Veiculo.id):
                        case nameof(Veiculo.ano):
                        case nameof(Veiculo.cor):
                        case nameof(Veiculo.cidadePlaca):
                        case nameof(Veiculo.ufPlaca):
                            dgvVeiculos.Columns[iCount].Visible = false;
                            break;

                        case nameof(Veiculo.tpVeiculo):
                            dgvVeiculos.Columns[iCount].DisplayIndex = 0;
                            dgvVeiculos.Columns[iCount].HeaderText = "Tipo";
                            dgvVeiculos.Columns[iCount].ReadOnly = true;
                            break;

                        case nameof(Veiculo.modelo):
                            dgvVeiculos.Columns[iCount].DisplayIndex = 1;
                            dgvVeiculos.Columns[iCount].HeaderText = "Modelo";
                            dgvVeiculos.Columns[iCount].Width = 250;
                            dgvVeiculos.Columns[iCount].ReadOnly = true;
                            break;

                        case nameof(Veiculo.placa):
                            dgvVeiculos.Columns[iCount].DisplayIndex = 2;
                            dgvVeiculos.Columns[iCount].HeaderText = "Placa";
                            dgvVeiculos.Columns[iCount].Width = 175;
                            dgvVeiculos.Columns[iCount].ReadOnly = true;
                            break;
                    }
                }

                //Preenche os campos que vieram sem preenchimento do data set
                for (var iCount = 0; iCount < dgvVeiculos.Rows.Count; iCount++) {
                    //Modelo - Ano - Cor
                    dgvVeiculos.Rows[iCount].Cells[nameof(Veiculo.modelo)].Value = String.Format("{0} - {1} - {2}",
                        cliente.veiculos[iCount].modelo,
                        cliente.veiculos[iCount].ano,
                        cliente.veiculos[iCount].cor);

                    //Placa (Cidade - Estado)
                    dgvVeiculos.Rows[iCount].Cells[nameof(Veiculo.placa)].Value = String.Format("{0} ({1} - {2})",
                        cliente.veiculos[iCount].placa,
                        cliente.veiculos[iCount].cidadePlaca,
                        cliente.veiculos[iCount].ufPlaca);
                }

                dgvVeiculos.Refresh();
            }
        }

        private void windowModeChanged() {
            switch (windowMode) {
                case Util.WindowMode.ModoNormal:
                case Util.WindowMode.ModoCriacaoForm:
                    btnAdicionar.Enabled = true;
                    btnExcluir.Enabled = true;

                    btnCancelar.Enabled = false;
                    btnGravar.Enabled = false;

                    dgvVeiculos.Enabled = true;

                    btnAtualizar.Enabled = true;
                    btnPrimeiro.Enabled = true;
                    btnAnterior.Enabled = true;
                    btnProximo.Enabled = true;
                    btnUltimo.Enabled = true;
                    break;

                case Util.WindowMode.ModoDeEdicao:
                    btnAdicionar.Enabled = false;
                    btnExcluir.Enabled = false;

                    btnCancelar.Enabled = true;
                    btnGravar.Enabled = true;

                    dgvVeiculos.Enabled = false;

                    btnAtualizar.Enabled = false;
                    btnPrimeiro.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnProximo.Enabled = false;
                    btnUltimo.Enabled = false;
                    break;

                case Util.WindowMode.ModoDeInsercao:
                    btnAdicionar.Enabled = false;
                    btnExcluir.Enabled = false;

                    btnCancelar.Enabled = true;
                    btnGravar.Enabled = true;

                    dgvVeiculos.Enabled = false;

                    btnAtualizar.Enabled = false;
                    btnPrimeiro.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnProximo.Enabled = false;
                    btnUltimo.Enabled = false;
                    break;
            }
        }

        private void fields_keyDown(object sender, KeyEventArgs e) {
            if (windowMode != Util.WindowMode.ModoDeInsercao && windowMode != Util.WindowMode.ModoCriacaoForm) {
                windowMode = Util.WindowMode.ModoDeEdicao;
                windowModeChanged();
            }
        }

        private void clearFields() {
            txtID.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtDtNascimento.Text = "";

            txtEndereco.Text = "";
            txtCEP.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";

            txtEmail.Text = "";
            txtFone1.Text = "";
            txtFone2.Text = "";
        }

        #endregion
    }
}
