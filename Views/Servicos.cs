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
    public partial class Servicos : Form{

        #region Atributos da classe
        private Util.WindowMode windowMode;

        private List<Servico> servicos;
        private List<Servico> servicos_view;


        private List<Unidade> unidades;

        private int index;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();

            index = -1;

            servicos = new List<Servico>();
            unidades = new List<Unidade>();

            //Preenche o ComboBox da busca
            cboCamposBusca.Items.Clear();
            cboCamposBusca.Items.Add("Descrição");
            cboCamposBusca.Items.Add("Unidade");
            cboCamposBusca.Items.Add("Valor");
            cboCamposBusca.Items.Add("ID");
            cboCamposBusca.SelectedIndex = 0;

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        public Servicos(){
            init();

            getFromRepositorio();
            refreshDataGridView();
        }

        private void getFromRepositorio() {
            servicos = ServicoServicos.Instance.read();
            servicos_view = new List<Servico>(servicos);

            unidades = UnidadeServicos.Instance.read();
            carregaComboBox();
        }
        #endregion

        #region Botões de navegação
        private void btnPrimeiro_Click(object sender, EventArgs e) {
            if (servicos_view.Count > 0) {
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
            if (index + 1 < servicos_view.Count) {
                index++;
                selecionaServico();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            if (servicos_view.Count > 0) {
                if (index != servicos_view.Count - 1) {
                    index = servicos_view.Count - 1;
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
            Servico newServico;

            // Cria os dados básicos do cliente
            string descricao = txtDescricao.Text;
            float valor = -1; float.TryParse(txtValor.Text, out valor);
            Unidade unidade = (Unidade)cboUnidade.SelectedItem;

            newServico = new Servico(descricao, valor, unidade);
            
            // Verifica se vai inserir um novo registro ou então salvá-lo
            if (windowMode == Util.WindowMode.ModoDeInsercao) {

                if (ServicoServicos.Instance.create(ref newServico)) {
                    getFromRepositorio();
                    btnUltimo_Click(null, null);
                    refreshDataGridView();
                } else {
                    clearFields();
                }

            } else if (windowMode == Util.WindowMode.ModoDeEdicao) {
                newServico.id = servicos_view[index].id;

                if (ServicoServicos.Instance.update(newServico)) {
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
                    servicos_view[index].ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ServicoServicos.Instance.delete(servicos_view[index]);

                getFromRepositorio();
                refreshDataGridView();
                clearFields();
            }
        }

        // Atualiza as informações dos clientes
        private void btnAtualizar_Click(object sender, EventArgs e) {
            getFromRepositorio();

            if (index > -1)
                index = servicos_view.FindIndex(clienteAEncontrar => clienteAEncontrar.id == servicos_view[index].id);

            selecionaServico();
            refreshDataGridView();
        }

        private void ConsultaClienteForm_Load(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        #region Interfaces - Comum
        private void fillFields() {
            if (index > -1 && servicos_view.Count > 0 && index < servicos_view.Count && servicos_view[index] != null) {
                // Preenche as informações básicas do cliente
                txtID.Text = servicos_view[index].id.ToString();
                txtDescricao.Text = servicos_view[index].descricao;
                txtValor.Text = servicos_view[index].valor.ToString();

                int indexUnidade = unidades.FindIndex(find => find.id == servicos_view[index].unidade.id);
                cboUnidade.SelectedIndex = indexUnidade;

                windowMode = Util.WindowMode.ModoNormal;
                windowModeChanged();
            }else if(index == -1) {
                clearFields();
            }
        }

        private void clearDataGridView() {
            // Seta o datagrid view como nulo
            dgvServicos.DataSource = null;
            dgvServicos.Refresh();
        }

        private void refreshDataGridView() {
            clearDataGridView();

            dgvServicos.Columns.Clear();

            dgvServicos.DataSource = servicos_view;

            // Preenche os nomes das colunas
            for (var iCount = 0; iCount < dgvServicos.Columns.Count; iCount++) {
                switch (dgvServicos.Columns[iCount].DataPropertyName) {
                    case nameof(Servico._total):
                    case nameof(Servico._quantidade):
                    case nameof(Servico._idUnidade):
                    case nameof(Servico._idServicoOrcFat):
                        dgvServicos.Columns[iCount].Visible = false;
                        break;
                    case nameof(Servico.id):
                        dgvServicos.Columns[iCount].DisplayIndex = 0;
                        dgvServicos.Columns[iCount].HeaderText = "ID";
                        dgvServicos.Columns[iCount].Width = 25;
                        dgvServicos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Servico.descricao):
                        dgvServicos.Columns[iCount].DisplayIndex = 1;
                        dgvServicos.Columns[iCount].HeaderText = "Descrição";
                        dgvServicos.Columns[iCount].Width = 250;
                        dgvServicos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Servico.unidade):
                        dgvServicos.Columns[iCount].DisplayIndex = 2;
                        dgvServicos.Columns[iCount].HeaderText = "Unidade";
                        dgvServicos.Columns[iCount].Width = 100;
                        dgvServicos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Servico.valor):
                        dgvServicos.Columns[iCount].DisplayIndex = 3;
                        dgvServicos.Columns[iCount].HeaderText = "Valor";
                        dgvServicos.Columns[iCount].Width = 100;
                        dgvServicos.Columns[iCount].ReadOnly = true;
                        break;
                }
            }

            dgvServicos.Refresh();
        }

        private void windowModeChanged() {
            switch (windowMode) {
                case Util.WindowMode.ModoNormal:
                case Util.WindowMode.ModoCriacaoForm:
                    enableFields(windowMode == Util.WindowMode.ModoNormal);

                   
                    btnExcluir.Enabled = windowMode == Util.WindowMode.ModoNormal;

                    btnCancelar.Enabled = false;
                    btnGravar.Enabled = false;

                    dgvServicos.Enabled = true;

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

                    dgvServicos.Enabled = false;

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
            txtValor.Enabled = enable;
            cboUnidade.Enabled = enable;
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
            txtValor.Text = "";
            cboUnidade.SelectedIndex = -1;

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        private void carregaComboBox() {
            // Carrega o combobox da unidade
            cboUnidade.Items.Clear();
            foreach (Unidade unidade in unidades) {
                cboUnidade.Items.Add(unidade);
            }
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                busca();
            }
        }

        private void busca() {
            string textoBusca = txtBusca.Text.ToUpper();

            if (textoBusca.Length == 0) {
                servicos_view = new List<Servico>(servicos);
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

            index = -1;
            selecionaServico();

            refreshDataGridView();
        }

        private void dgvServicos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                index = e.RowIndex;
                selecionaServico();
            }
        }

        #endregion

        #region Interfaces - Específico
        #endregion

        private void Servicos_Load(object sender, EventArgs e) {
            toolTip1.SetToolTip(btnAdicionar, "Adicionar serviço");
            toolTip1.SetToolTip(btnGravar, "Gravar alterações");
            toolTip1.SetToolTip(btnCancelar, "Cancelar alterações");
            toolTip1.SetToolTip(btnExcluir, "Excluir serviço");
            toolTip1.SetToolTip(btnAtualizar, "Atualizar informações");

            toolTip1.SetToolTip(btnPrimeiro, "Ir para o primeiro serviço");
            toolTip1.SetToolTip(btnAnterior, "Ir para o serviço anterior");
            toolTip1.SetToolTip(btnProximo, "Ir para o próximo serviço");
            toolTip1.SetToolTip(btnUltimo, "Ir para o último serviço");

            toolTip1.SetToolTip(txtBusca, "Tecle ENTER para realizar a busca");
            toolTip1.SetToolTip(cboCamposBusca, "Tecle ENTER para realizar a busca");

        }
    }
}