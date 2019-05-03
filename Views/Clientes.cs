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
using SistemaGuincho.Servicos;

namespace SistemaGuincho.Views {
    public partial class Clientes : Form{

        #region Atributos da classe
        private Util.WindowMode windowMode;

        private List<Cliente> clientes;

        private int index;

        private AdicionarVeiculo adicionarVeiculoForm;
        private ConsultaCliente consultaClienteForm;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();

            index = -1;

            clientes = new List<Model.Cliente>();

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        public Clientes(){
            init();

            getFromRepositorio();
        }

        public Clientes(Model.Cliente cliente) : this() {
            index = clientes.FindIndex(find => find.id == cliente.id);

            selecionaCliente();
        }

        private void getFromRepositorio() {
            clientes = ClienteServicos.Instance.read();
        }
        #endregion

        #region Botões de navegação
        private void btnPrimeiro_Click(object sender, EventArgs e) {
            if (clientes.Count > 0) {
                if (index != 0) {
                    index = 0;
                    selecionaCliente();
                }
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
                if (index != clientes.Count - 1) {
                    index = clientes.Count - 1;
                    selecionaCliente();
                }
            }
        }

        private void selecionaCliente() {
            fillFields();
        }
        #endregion

        #region CRUD
        // Aciona a criação de um novo cliente
        private void btnAdicionar_Click(object sender, EventArgs e) {
            index = 0;
            txtNome.Focus();
            clearFields();

            windowMode = Util.WindowMode.ModoDeInsercao;
            windowModeChanged();
        }


        // Cancela a edição
        private void btnCancelar_Click(object sender, EventArgs e) {
            // Verifica se vai inserir um novo registro ou então salvá-lo
            if (windowMode == Util.WindowMode.ModoDeInsercao) {
                clearFields();
            } else if (windowMode == Util.WindowMode.ModoDeEdicao) {
                fillFields();
            }
        }

        // Salva as alterações do cliente
        private void btnGravar_Click(object sender, EventArgs e) {
            // Cria um novo cliente
            Model.Cliente newCliente;

            // Cria os dados básicos do cliente
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string rg = txtRG.Text;
            DateTime dtNascimento = new DateTime(); DateTime.TryParseExact(txtDtNascimento.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.NoCurrentDateDefault, out dtNascimento);

            // Cria os dados do endereço do cliente
            Endereco endereco;
            string logradouro = txtEndereco.Text;
            string numero = txtNumero.Text;
            string complemento = txtComplemento.Text;
            long cep = -1; long.TryParse(txtCEP.Text, out cep);
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string uf = txtUF.Text;
            endereco = new Endereco(logradouro, numero, bairro, cep, complemento, cidade, uf);

            // Cria os dados de contato do cliente
            string email = txtEmail.Text;
            string fone1 = txtFone1.Text;
            string fone2 = txtFone2.Text;

            newCliente = new Model.Cliente(nome, cpf, rg, endereco, new List<Veiculo>(), dtNascimento, email, fone1, fone2);
            
            // Verifica se vai inserir um novo registro ou então salvá-lo
            if (windowMode == Util.WindowMode.ModoDeInsercao) {

                if (ClienteServicos.Instance.create(ref newCliente)) {
                    getFromRepositorio();
                    btnUltimo_Click(null, null);
                } else {
                    clearFields();
                }

            } else if (windowMode == Util.WindowMode.ModoDeEdicao) {
                newCliente.veiculos = clientes[index].veiculos;
                newCliente.id = clientes[index].id;

                if (ClienteServicos.Instance.update(newCliente)) {
                    getFromRepositorio();
                }

                fillFields();
            }

            windowMode = Util.WindowMode.ModoNormal;
            windowModeChanged();
        }

        // Exclui o cliente
        private void btnExcluir_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Confirma a deleção do registro ?" +
                    Environment.NewLine + Environment.NewLine +
                    clientes[index].ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ClienteServicos.Instance.delete(clientes[index]);

                getFromRepositorio();
                clearFields();
            }
        }

        // Atualiza as informações dos clientes
        private void btnAtualizar_Click(object sender, EventArgs e) {
            getFromRepositorio();

            if (index > -1)
                index = clientes.FindIndex(clienteAEncontrar => clienteAEncontrar.id == clientes[index].id);

            refreshDataGridView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e) {
            consultaClienteForm = new ConsultaCliente(Util.TipoConsulta.Edicao);
            consultaClienteForm.Load += ConsultaClienteForm_Load;
            consultaClienteForm.Show();
        }

        private void ConsultaClienteForm_Load(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        #region Interfaces - Comum
        private void fillFields() {
            if (index > -1 && clientes.Count > 0 && index < clientes.Count && clientes[index] != null) {
                // Preenche as informações básicas do cliente
                txtID.Text = clientes[index].id.ToString();
                txtNome.Text = clientes[index].nome;
                txtCPF.Text = clientes[index].cpf;
                txtRG.Text = clientes[index].rg;
                txtDtNascimento.Text = clientes[index].dataNascimento.ToString("dd/MM/yyyy");

                // Preenche as informações do endereço do cliente
                txtEndereco.Text = clientes[index].endereco.logradouro;
                txtNumero.Text = clientes[index].endereco.numero;
                txtComplemento.Text = clientes[index].endereco.complemento;
                txtCEP.Text = clientes[index].endereco.cep.ToString();
                txtBairro.Text = clientes[index].endereco.bairro;
                txtCidade.Text = clientes[index].endereco.cidade;
                txtUF.Text = clientes[index].endereco.uf;

                // Preenche as informações de contato do cliente
                txtEmail.Text = clientes[index].email;
                txtFone1.Text = clientes[index].fone1;
                txtFone2.Text = clientes[index].fone2;


                refreshDataGridView();
                windowMode = Util.WindowMode.ModoNormal;
                windowModeChanged();

                // Atualiza o nome do formulário
                this.Text = String.Format("Cliente: {0} - {1}", clientes[index].id, clientes[index].nome);

            }
        }

        private void clearDataGridView() {
            // Seta o datagrid view como nulo
            dgvVeiculos.DataSource = null;
            dgvVeiculos.Refresh();
        }

        private void refreshDataGridView() {
            clearDataGridView();

            // Verifica se o cliente existe
            if (index > -1 && clientes.Count > 0 && index < clientes.Count && clientes[index] != null) {

                dgvVeiculos.Columns.Clear();

                dgvVeiculos.DataSource = clientes[index].veiculos;

                // Preenche os nomes das colunas
                for (var iCount = 0; iCount < dgvVeiculos.Columns.Count; iCount++) {
                    switch (dgvVeiculos.Columns[iCount].DataPropertyName) {
                        case nameof(Veiculo.id):
                        case nameof(Veiculo.modelo):
                        case nameof(Veiculo.ano):
                        case nameof(Veiculo.cor):
                        case nameof(Veiculo.placa):
                        case nameof(Veiculo.cidadePlaca):
                        case nameof(Veiculo.ufPlaca):
                        case nameof(Veiculo._idCliente):
                            dgvVeiculos.Columns[iCount].Visible = false;
                            break;

                        case nameof(Veiculo.tpVeiculo):
                            dgvVeiculos.Columns[iCount].DisplayIndex = 0;
                            dgvVeiculos.Columns[iCount].HeaderText = "Tipo";
                            dgvVeiculos.Columns[iCount].ReadOnly = true;
                            break;

                        case nameof(Veiculo.modelo_2):
                            dgvVeiculos.Columns[iCount].Name = dgvVeiculos.Columns[iCount].DataPropertyName;
                            dgvVeiculos.Columns[iCount].DisplayIndex = 1;
                            dgvVeiculos.Columns[iCount].HeaderText = "Modelo";
                            dgvVeiculos.Columns[iCount].Width = 250;
                            dgvVeiculos.Columns[iCount].ReadOnly = true;
                            break;

                        case nameof(Veiculo.placa_2):
                            dgvVeiculos.Columns[iCount].Name = dgvVeiculos.Columns[iCount].DataPropertyName;
                            dgvVeiculos.Columns[iCount].DisplayIndex = 2;
                            dgvVeiculos.Columns[iCount].HeaderText = "Placa";
                            dgvVeiculos.Columns[iCount].Width = 175;
                            dgvVeiculos.Columns[iCount].ReadOnly = true;
                            break;
                    }
                }

                dgvVeiculos.Refresh();
            }
        }

        private void dgvVeiculos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                Veiculo veiculo = clientes[index].veiculos[e.RowIndex];
                abrirFormVeiculos(veiculo);
            }
        }

        private void windowModeChanged() {
            switch (windowMode) {
                case Util.WindowMode.ModoNormal:
                case Util.WindowMode.ModoCriacaoForm:
                    enableFields(windowMode == Util.WindowMode.ModoNormal);

                    btnAdicionar.Enabled = true;
                    btnExcluir.Enabled = windowMode == Util.WindowMode.ModoNormal;
                    btnAddVeiculo.Enabled = windowMode == Util.WindowMode.ModoNormal;

                    btnCancelar.Enabled = false;
                    btnGravar.Enabled = false;

                    dgvVeiculos.Enabled = true;

                    btnAtualizar.Enabled = true;
                    btnPesquisar.Enabled = true;

                    btnPrimeiro.Enabled = true;
                    btnAnterior.Enabled = true;
                    btnProximo.Enabled = true;
                    btnUltimo.Enabled = true;
                    break;

                case Util.WindowMode.ModoDeEdicao:
                case Util.WindowMode.ModoDeInsercao:
                    enableFields(true);

                    btnAdicionar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnAddVeiculo.Enabled = false;

                    btnCancelar.Enabled = true;
                    btnGravar.Enabled = true;

                    dgvVeiculos.Enabled = false;

                    btnAtualizar.Enabled = false;
                    btnPesquisar.Enabled = false;

                    btnPrimeiro.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnProximo.Enabled = false;
                    btnUltimo.Enabled = false;
                    break;
            }
        }

        private void enableFields(bool enable) {
            txtNome.Enabled = enable;
            txtCPF.Enabled = enable;
            txtRG.Enabled = enable;
            txtDtNascimento.Enabled = enable;

            txtEndereco.Enabled = enable;
            txtCEP.Enabled = enable;
            txtBairro.Enabled = enable;
            txtCidade.Enabled = enable;
            txtUF.Enabled = enable;
            txtNumero.Enabled = enable;
            txtComplemento.Enabled = enable;

            txtEmail.Enabled = enable;
            txtFone1.Enabled = enable;
            txtFone2.Enabled = enable;
        }

        private void fields_keyDown(object sender, KeyEventArgs e) {
            if (windowMode != Util.WindowMode.ModoDeInsercao && windowMode != Util.WindowMode.ModoCriacaoForm) {
                windowMode = Util.WindowMode.ModoDeEdicao;
                windowModeChanged();
            }
        }

        private void clearFields() {
            index = -1;
            
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
            txtNumero.Text = "";
            txtComplemento.Text = "";

            txtEmail.Text = "";
            txtFone1.Text = "";
            txtFone2.Text = "";

            clearDataGridView();

            this.Text = "Clientes";

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        #endregion

        #region Interfaces - Específico
        private void btnAddVeiculo_Click(object sender, EventArgs e) {
            adicionarVeiculoForm = new AdicionarVeiculo(clientes[index]);
            abrirFormVeiculos();
        }

        private void abrirFormVeiculos(Veiculo veiculo) {
            adicionarVeiculoForm = new AdicionarVeiculo(clientes[index], veiculo);
            abrirFormVeiculos();
        }

        private void abrirFormVeiculos() {
            adicionarVeiculoForm.FormClosing += adicionarVeiculoForm_FormClosing;
            adicionarVeiculoForm.ShowDialog();
        }

        private void adicionarVeiculoForm_FormClosing(object sender, FormClosingEventArgs e) {
            clientes[index].veiculos = VeiculoServicos.Instance.read(clientes[index]);
            refreshDataGridView();
        }
        #endregion
    }
}