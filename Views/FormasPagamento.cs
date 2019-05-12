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
    public partial class FormasPagamento : Form{

        #region Atributos da classe
        private Util.WindowMode windowMode;

        private List<FormaPagamento> formasPagamento;
        private List<FormaPagamento> formasPagamento_view;

        private int index;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();

            index = -1;

            formasPagamento = new List<FormaPagamento>();

            //Preenche o ComboBox da busca
            cboCamposBusca.Items.Clear();
            cboCamposBusca.Items.Add("Descrição");
            cboCamposBusca.Items.Add("Número de Parcelas");
            cboCamposBusca.Items.Add("Entrada? (S/N)");
            cboCamposBusca.SelectedIndex = 0;

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        public FormasPagamento(){
            init();

            getFromRepositorio();
            refreshDataGridView();
        }

        private void getFromRepositorio() {
            formasPagamento = FormaPagamentoServicos.Instance.read();
            formasPagamento_view = new List<FormaPagamento>(formasPagamento);
        }
        #endregion

        #region Botões de navegação
        private void btnPrimeiro_Click(object sender, EventArgs e) {
            if (formasPagamento_view.Count > 0) {
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
            if (index + 1 < formasPagamento_view.Count) {
                index++;
                selecionaServico();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            if (formasPagamento_view.Count > 0) {
                if (index != formasPagamento_view.Count - 1) {
                    index = formasPagamento_view.Count - 1;
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
            FormaPagamento newFormaPagamento;

            // Cria os dados básicos do cliente
            string descricao = txtDescricao.Text;
            int numParcelas = -1; int.TryParse(txtNumParcelas.Text, out numParcelas);
            bool entrada = chkEntrada.Checked;

            newFormaPagamento = new FormaPagamento(descricao, numParcelas, entrada);
            
            // Verifica se vai inserir um novo registro ou então salvá-lo
            if (windowMode == Util.WindowMode.ModoDeInsercao) {

                if (FormaPagamentoServicos.Instance.create(ref newFormaPagamento)) {
                    getFromRepositorio();
                    btnUltimo_Click(null, null);
                    refreshDataGridView();
                } else {
                    clearFields();
                }

            } else if (windowMode == Util.WindowMode.ModoDeEdicao) {
                newFormaPagamento.id = formasPagamento_view[index].id;

                if (FormaPagamentoServicos.Instance.update(newFormaPagamento)) {
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
                    formasPagamento_view[index].ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                FormaPagamentoServicos.Instance.delete(formasPagamento_view[index]);

                getFromRepositorio();
                refreshDataGridView();
                clearFields();
            }
        }

        // Atualiza as informações dos clientes
        private void btnAtualizar_Click(object sender, EventArgs e) {
            getFromRepositorio();

            if (index > -1)
                index = formasPagamento_view.FindIndex(clienteAEncontrar => clienteAEncontrar.id == formasPagamento_view[index].id);

            selecionaServico();
            refreshDataGridView();
        }

        private void ConsultaClienteForm_Load(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        #region Interfaces - Comum
        private void fillFields() {
            if (index > -1 && formasPagamento_view.Count > 0 && index < formasPagamento_view.Count && formasPagamento_view[index] != null) {
                // Preenche as informações básicas do cliente
                txtID.Text = formasPagamento_view[index].id.ToString();
                txtDescricao.Text = formasPagamento_view[index].descricao.ToString();
                txtNumParcelas.Text = formasPagamento_view[index].numParcelas.ToString();
                chkEntrada.Checked = formasPagamento_view[index].entrada;

                windowMode = Util.WindowMode.ModoNormal;
                windowModeChanged();
            }else if(index == -1) {
                clearFields();
            }
        }

        private void clearDataGridView() {
            // Seta o datagrid view como nulo
            dgvFormasPagamento.DataSource = null;
            dgvFormasPagamento.Refresh();
        }

        private void refreshDataGridView() {
            clearDataGridView();

            dgvFormasPagamento.Columns.Clear();

            dgvFormasPagamento.DataSource = formasPagamento_view;

            // Preenche os nomes das colunas
            for (var iCount = 0; iCount < dgvFormasPagamento.Columns.Count; iCount++) {
                switch (dgvFormasPagamento.Columns[iCount].DataPropertyName) {
                    case nameof(FormaPagamento.id):
                        dgvFormasPagamento.Columns[iCount].DisplayIndex = 0;
                        dgvFormasPagamento.Columns[iCount].HeaderText = "ID";
                        dgvFormasPagamento.Columns[iCount].Width = 25;
                        dgvFormasPagamento.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(FormaPagamento.descricao):
                        dgvFormasPagamento.Columns[iCount].DisplayIndex = 1;
                        dgvFormasPagamento.Columns[iCount].HeaderText = "Descrição";
                        dgvFormasPagamento.Columns[iCount].Width = 250;
                        dgvFormasPagamento.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(FormaPagamento.numParcelas):
                        dgvFormasPagamento.Columns[iCount].DisplayIndex = 2;
                        dgvFormasPagamento.Columns[iCount].HeaderText = "Parcelas";
                        dgvFormasPagamento.Columns[iCount].Width = 100;
                        dgvFormasPagamento.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(FormaPagamento.entrada):
                        dgvFormasPagamento.Columns[iCount].DisplayIndex = 3;
                        dgvFormasPagamento.Columns[iCount].HeaderText = "Entrada?";
                        dgvFormasPagamento.Columns[iCount].Width = 100;
                        dgvFormasPagamento.Columns[iCount].ReadOnly = true;
                        break;
                }
            }

            dgvFormasPagamento.Refresh();
        }

        private void windowModeChanged() {
            switch (windowMode) {
                case Util.WindowMode.ModoNormal:
                case Util.WindowMode.ModoCriacaoForm:
                    enableFields(windowMode == Util.WindowMode.ModoNormal);

                   
                    btnExcluir.Enabled = windowMode == Util.WindowMode.ModoNormal;

                    btnCancelar.Enabled = false;
                    btnGravar.Enabled = false;

                    dgvFormasPagamento.Enabled = true;

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

                    dgvFormasPagamento.Enabled = false;

                    btnAtualizar.Enabled = false;

                    btnPrimeiro.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnProximo.Enabled = false;
                    btnUltimo.Enabled = false;
                    break;
            }
        }

        private void enableFields(bool enable) {
            txtDescricao.Enabled = enable;
            txtNumParcelas.Enabled = enable;
            chkEntrada.Enabled = enable;
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
            txtDescricao.Text = "";
            txtNumParcelas.Text = "";
            chkEntrada.Checked = false;

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
                formasPagamento_view = new List<FormaPagamento>(formasPagamento);
            } else {
                switch (cboCamposBusca.SelectedIndex) {
                    case 0: // Descrição
                        formasPagamento_view = formasPagamento.FindAll(find => find.descricao.ToUpper().Contains(textoBusca));
                        break;
                    case 1: // Número de parcelas
                        int numParcelasDesejado;

                        if (Int32.TryParse(textoBusca, out numParcelasDesejado)) {
                            formasPagamento_view = formasPagamento.FindAll(find => find.numParcelas == numParcelasDesejado);
                        }
                        break;

                    case 2: // Entrada
                        bool entrada = textoBusca.ToUpper().Equals("S");

                        formasPagamento_view = formasPagamento.FindAll(find => find.entrada == entrada);
                        break;
                }
            }
            /*
             * cboCamposBusca.Items.Add("Descrição");
            cboCamposBusca.Items.Add("Número de Parcelas");
            cboCamposBusca.Items.Add("Entrada? (S/N)");
             */
            index = -1;
            selecionaServico();

            refreshDataGridView();
        }

        private void dgvFormasPagamento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
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