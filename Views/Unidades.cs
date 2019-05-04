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
    public partial class Unidades : Form{

        #region Atributos da classe
        private Util.WindowMode windowMode;

        private List<Unidade> unidades;
        private List<Unidade> unidades_view;

        private int index;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();

            index = -1;

            unidades = new List<Unidade>();

            //Preenche o ComboBox da busca
            cboCamposBusca.Items.Clear();
            cboCamposBusca.Items.Add("Código");
            cboCamposBusca.Items.Add("Descrição");
            cboCamposBusca.SelectedIndex = 0;

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        public Unidades(){
            init();

            getFromRepositorio();
            refreshDataGridView();
        }

        private void getFromRepositorio() {
            unidades = UnidadeServicos.Instance.read();
            unidades_view = new List<Unidade>(unidades);
        }
        #endregion

        #region Botões de navegação
        private void btnPrimeiro_Click(object sender, EventArgs e) {
            if (unidades_view.Count > 0) {
                if (index != 0) {
                    index = 0;
                    selecionaServico();
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if (index - 1 >= 0) {
                index--;
                selecionaServico();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e) {
            if (index + 1 < unidades_view.Count) {
                index++;
                selecionaServico();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            if (unidades_view.Count > 0) {
                if (index != unidades_view.Count - 1) {
                    index = unidades_view.Count - 1;
                    selecionaServico();
                }
            }
        }

        private void selecionaServico() {
            fillFields();
        }
        #endregion

        #region CRUD
        // Aciona a criação de um novo cliente
        private void btnAdicionar_Click(object sender, EventArgs e) {
            index = 0;
            txtDescricao.Focus();
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
            Unidade newUnidade;

            // Cria os dados básicos do cliente
            string codigo = txtCodigo.Text;
            string descricao = txtDescricao.Text;

            newUnidade = new Unidade(codigo, descricao);
            
            // Verifica se vai inserir um novo registro ou então salvá-lo
            if (windowMode == Util.WindowMode.ModoDeInsercao) {

                if (UnidadeServicos.Instance.create(ref newUnidade)) {
                    getFromRepositorio();
                    btnUltimo_Click(null, null);
                    refreshDataGridView();
                } else {
                    clearFields();
                }

            } else if (windowMode == Util.WindowMode.ModoDeEdicao) {
                newUnidade.id = unidades_view[index].id;

                if (UnidadeServicos.Instance.update(newUnidade)) {
                    getFromRepositorio();
                    refreshDataGridView();
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
                    unidades_view[index].ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                UnidadeServicos.Instance.delete(unidades_view[index]);

                getFromRepositorio();
                refreshDataGridView();
                clearFields();
            }
        }

        // Atualiza as informações dos clientes
        private void btnAtualizar_Click(object sender, EventArgs e) {
            getFromRepositorio();

            if (index > -1)
                index = unidades_view.FindIndex(clienteAEncontrar => clienteAEncontrar.id == unidades_view[index].id);

            selecionaServico();
            refreshDataGridView();
        }

        private void ConsultaClienteForm_Load(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        #region Interfaces - Comum
        private void fillFields() {
            if (index > -1 && unidades_view.Count > 0 && index < unidades_view.Count && unidades_view[index] != null) {
                // Preenche as informações básicas do cliente
                txtID.Text = unidades_view[index].id.ToString();
                txtCodigo.Text = unidades_view[index].codigo.ToString();
                txtDescricao.Text = unidades_view[index].descricao.ToString();

                windowMode = Util.WindowMode.ModoNormal;
                windowModeChanged();
            }else if(index == -1) {
                clearFields();
            }
        }

        private void clearDataGridView() {
            // Seta o datagrid view como nulo
            dgvUnidades.DataSource = null;
            dgvUnidades.Refresh();
        }

        private void refreshDataGridView() {
            clearDataGridView();

            dgvUnidades.Columns.Clear();

            dgvUnidades.DataSource = unidades_view;

            // Preenche os nomes das colunas
            for (var iCount = 0; iCount < dgvUnidades.Columns.Count; iCount++) {
                switch (dgvUnidades.Columns[iCount].DataPropertyName) {
                    case nameof(Unidade.id):
                        dgvUnidades.Columns[iCount].DisplayIndex = 0;
                        dgvUnidades.Columns[iCount].HeaderText = "ID";
                        dgvUnidades.Columns[iCount].Width = 25;
                        dgvUnidades.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Unidade.codigo):
                        dgvUnidades.Columns[iCount].DisplayIndex = 1;
                        dgvUnidades.Columns[iCount].HeaderText = "Código";
                        dgvUnidades.Columns[iCount].Width = 100;
                        dgvUnidades.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Unidade.descricao):
                        dgvUnidades.Columns[iCount].DisplayIndex = 2;
                        dgvUnidades.Columns[iCount].HeaderText = "Descrição";
                        dgvUnidades.Columns[iCount].Width = 250;
                        dgvUnidades.Columns[iCount].ReadOnly = true;
                        break;
                }
            }

            dgvUnidades.Refresh();
        }

        private void windowModeChanged() {
            switch (windowMode) {
                case Util.WindowMode.ModoNormal:
                case Util.WindowMode.ModoCriacaoForm:
                    enableFields(windowMode == Util.WindowMode.ModoNormal);

                   
                    btnExcluir.Enabled = windowMode == Util.WindowMode.ModoNormal;

                    btnCancelar.Enabled = false;
                    btnGravar.Enabled = false;

                    dgvUnidades.Enabled = true;

                    btnAtualizar.Enabled = true;

                    btnPrimeiro.Enabled = true;
                    btnAnterior.Enabled = true;
                    btnProximo.Enabled = true;
                    btnUltimo.Enabled = true;
                    break;

                case Util.WindowMode.ModoDeEdicao:
                case Util.WindowMode.ModoDeInsercao:
                    enableFields(true);

               
                    btnExcluir.Enabled = false;

                    btnCancelar.Enabled = true;
                    btnGravar.Enabled = true;

                    dgvUnidades.Enabled = false;

                    btnAtualizar.Enabled = false;

                    btnPrimeiro.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnProximo.Enabled = false;
                    btnUltimo.Enabled = false;
                    break;
            }
        }

        private void enableFields(bool enable) {
            txtCodigo.Enabled = enable;
            txtDescricao.Enabled = enable;
        }

        private void fields_keyDown(object sender, KeyEventArgs e) {
            if (windowMode != Util.WindowMode.ModoDeInsercao && windowMode != Util.WindowMode.ModoCriacaoForm) {
                windowMode = Util.WindowMode.ModoDeEdicao;
                windowModeChanged();
            }
        }

        private void fields_keyDown(object sender, EventArgs e) {
            fields_keyDown(sender, null);
        }

        private void clearFields() {
            index = -1;
            
            txtID.Text = "";
            txtCodigo.Text = "";
            txtDescricao.Text = "";

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                busca();
            }
        }

        private void busca() {
            string textoBusca = txtBusca.Text.ToUpper();

            if (textoBusca.Length == 0) {
                unidades_view = new List<Unidade>(unidades);
            } else {
                switch (cboCamposBusca.SelectedIndex) {
                    case 0: // Códiog
                        unidades_view = unidades.FindAll(find => find.codigo.ToUpper().Contains(textoBusca));
                        break;
                    case 1: // Descrição
                        unidades_view = unidades.FindAll(find => find.descricao.ToUpper().Contains(textoBusca));
                        break;
                }
            }

            index = -1;
            selecionaServico();

            refreshDataGridView();
        }

        private void dgvUnidades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                index = e.RowIndex;
                selecionaServico();
            }
        }

        #endregion

        #region Interfaces - Específico
        #endregion
    }
}