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
    public partial class Faturamentos : Form {

        #region Atributos da classe
        private Util.WindowMode windowMode;

        private List<Faturamento> faturamentos;

        private int index;

        private ConsultaCliente consultaClienteForm;
        private ConsultaFaturamento consultaFaturamentoForm;
        private ConsultaServico consultaServicoForm;
        private ConsultaOrcamento consultaOrcamentoForm;

        public enum Edicao {
            DadosDoFaturamento,
            DadosDosServicos,
            DadosDosCustosAdicionais
        };

        private List<FormaPagamento> formasPagamento;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();

            index = -1;

            faturamentos = new List<Faturamento>();

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        public Faturamentos(){
            init();

            getFromRepositorio();
        }

        public Faturamentos(Faturamento faturamento) : this() {
            index = faturamentos.FindIndex(find => find.id == faturamento.id);

            selecionaFaturamento();
        }

        private void getFromRepositorio() {
            faturamentos = FaturamentoServicos.read();

            formasPagamento = FormaPagamentoServicos.Instance.read();
            cboFormasPagamento.Items.Clear();
            cboFormasPagamento.Items.AddRange(formasPagamento.ToArray());
            if (index > -1 && faturamentos[index].formaPagamento != null)
                cboFormasPagamento.SelectedIndex = formasPagamento.FindIndex(find => find.id == faturamentos[index].formaPagamento.id);
            else
                cboFormasPagamento.SelectedIndex = -1;
        }
        #endregion

        #region Botões de navegação
        private void btnPrimeiro_Click(object sender, EventArgs e) {
            if (faturamentos.Count > 0) {
                if (index != 0) {
                    index = 0;
                    selecionaFaturamento();
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if (index - 1 >= 0) {
                index--;
                selecionaFaturamento();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e) {
            if (index + 1 < faturamentos.Count) {
                index++;
                selecionaFaturamento();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            if (faturamentos.Count > 0) {
                if (index != faturamentos.Count - 1) {
                    index = faturamentos.Count - 1;
                    selecionaFaturamento();
                }
            }
        }

        private void selecionaFaturamento() {
            fillFields();
        }
        #endregion

        #region CRUD
        // Aciona a criação de um novo cliente
        private void btnAdicionar_Click(object sender, EventArgs e) {
            // Cria o menu de contexto
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem toolStripMenuItem;

            toolStripMenuItem = new ToolStripMenuItem("Criar faturamento com base em orçamento");
            toolStripMenuItem.Click += criaFaturamentoBaseOrcamento;
            contextMenuStrip.Items.Add(toolStripMenuItem);

            toolStripMenuItem = new ToolStripMenuItem("Criar faturamento");
            toolStripMenuItem.Click += criaFaturamento;
            contextMenuStrip.Items.Add(toolStripMenuItem);

            // Exibe o menu de contexto
            contextMenuStrip.Show(this, this.PointToClient(MousePosition));
        }

        private void criaFaturamento(object _sender, EventArgs e) {
            index = 0;
            txtNomeCliente.Focus();
            clearFields();

            windowMode = Util.WindowMode.ModoDeInsercao;
            windowModeChanged();

            btnPesquisarCliente_Click(null, null);
        }

        private void criaFaturamentoBaseOrcamento(object _sender, EventArgs e) {
            consultaOrcamentoForm = new ConsultaOrcamento(Util.TipoConsulta.Selecao, true);
            consultaOrcamentoForm.FormClosing += ConsultaOrcamentoForm_FormClosing;
            consultaOrcamentoForm.Show();
        }

        private void ConsultaOrcamentoForm_FormClosing(object sender, FormClosingEventArgs e) {
            Orcamento orcamentoSelecionado = consultaOrcamentoForm.orcamentoSelecionado;

            if (orcamentoSelecionado != null) {
                Faturamento newFaturamento = new Faturamento(orcamentoSelecionado.cliente, orcamentoSelecionado.veiculo);

                foreach (Servico servico in orcamentoSelecionado.servicos)
                    newFaturamento.servicos.Add(servico);

                foreach (Servico custoAdicional in orcamentoSelecionado.custosAdicionais)
                    newFaturamento.custosAdicionais.Add(custoAdicional);

                newFaturamento.numOrcamento = orcamentoSelecionado.id;

                FaturamentoServicos.create(ref newFaturamento);

                getFromRepositorio();
                btnUltimo_Click(null, null);
            }
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

        // Salva as alterações do orçamento
        private void btnGravar_Click(object sender, EventArgs e) {
            // Cria um novo orçamento
            Faturamento newFaturamento;

            // Cria os dados básicos do orçamento
            int idCliente = -1; int.TryParse(txtCdCliente.Text, out idCliente);

            if (txtCdCliente.Text.Trim().Length == 0) {
                MessageBox.Show("Não foi possível salvar o faturamento.\n\nDeve ser selecionado um cliente",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            } else {

                Cliente cliente = ClienteServicos.Instance.read(idCliente);
                Veiculo veiculo = (Veiculo)cboVeiculo.SelectedItem;

                newFaturamento = new Faturamento(cliente, veiculo);
                FormaPagamento formaPagamento = null;

                if (cboFormasPagamento.SelectedIndex > -1)
                    formaPagamento = (FormaPagamento)cboFormasPagamento.SelectedItem;

                newFaturamento.formaPagamento = formaPagamento;
                newFaturamento._idFormaPagamento = formaPagamento != null ? formaPagamento.id : 0;


                // Verifica se vai inserir um novo registro ou então salvá-lo
                if (windowMode == Util.WindowMode.ModoDeInsercao) {
                    // Cria novo orçameto

                    if (FaturamentoServicos.create(ref newFaturamento)) {
                        getFromRepositorio();
                        btnUltimo_Click(null, null);
                    } else {
                        clearFields();
                    }

                } else if (windowMode == Util.WindowMode.ModoDeEdicao) {
                    // Grava orçamento já existente

                    newFaturamento.id = faturamentos[index].id;
                    newFaturamento.servicos = faturamentos[index].servicos;
                    newFaturamento.custosAdicionais = faturamentos[index].custosAdicionais;
                    newFaturamento.dataCriacao = faturamentos[index].dataCriacao;

                    if (cliente != null)
                        newFaturamento._idCliente = cliente.id;

                    if (veiculo != null)
                        newFaturamento._idVeiculo = veiculo.id;

                    if (FaturamentoServicos.update(newFaturamento)) {
                        getFromRepositorio();
                    }

                    fillFields();
                }

                windowMode = Util.WindowMode.ModoNormal;
                windowModeChanged();
            }
        }

        // Exclui o cliente
        private void btnExcluir_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Confirma a deleção do registro ?" +
                    Environment.NewLine + Environment.NewLine +
                    faturamentos[index].ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                FaturamentoServicos.delete(faturamentos[index]);

                getFromRepositorio();
                clearFields();
            }
        }

        // Atualiza as informações dos Faturamento
        private void btnAtualizar_Click(object sender, EventArgs e) {
            getFromRepositorio();

            if (index > -1)
                index = faturamentos.FindIndex(clienteAEncontrar => clienteAEncontrar.id == faturamentos[index].id);

            fillFields();
            refreshDataGridView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e) {
            consultaFaturamentoForm = new ConsultaFaturamento(Util.TipoConsulta.Edicao);
            consultaFaturamentoForm.Load += ConsultaClienteForm_Load;
            consultaFaturamentoForm.Show();
        }

        private void ConsultaClienteForm_Load(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        #region Interfaces - Comum
        private void fillFields() {
            if (index > -1 && faturamentos.Count > 0 && index < faturamentos.Count && faturamentos[index] != null) {
                // Preenche as informações básicas do orçamento
                txtID.Text = faturamentos[index].id.ToString();
                txtDtCriacao.Text = faturamentos[index].dataCriacao.ToString("dd/MM/yyyy");
                txtDtEncerramento.Text = faturamentos[index].dataEncerramento?.ToString("dd/MM/yyyy");
                if (faturamentos[index].numOrcamento > 0)
                    txtOrcamento.Text = faturamentos[index].numOrcamento.ToString();
                else
                    txtOrcamento.Text = "";

                preencheInformacoesCliente(faturamentos[index].cliente);

                if (faturamentos[index].veiculo != null) {
                    int indexVeiculo = faturamentos[index].cliente.veiculos.FindIndex(find => find.id == faturamentos[index].veiculo.id);
                    cboVeiculo.SelectedIndex = indexVeiculo;
                } else
                    cboVeiculo.SelectedIndex = -1;

                if (faturamentos[index].formaPagamento != null) {
                    int indexFormaPgto = formasPagamento.FindIndex(find => find.id == faturamentos[index].formaPagamento.id);
                    cboFormasPagamento.SelectedIndex = indexFormaPgto;
                } else
                    cboVeiculo.SelectedIndex = -1;

                refreshDataGridView();

                calculaEAtualizaInformacoesServicos();

                windowMode = Util.WindowMode.ModoNormal;
                windowModeChanged();

                // Atualiza o nome do formulário
                this.Text = String.Format("Faturamento: {0} - {1}", faturamentos[index].id, faturamentos[index].cliente.nome);

            }
        }

        private void preencheInformacoesCliente(Cliente cliente) {
            txtCdCliente.Text = cliente.id.ToString();
            txtNomeCliente.Text = cliente.nome;
            fillCombobox(cliente);
        }

        private void fillCombobox(Cliente cliente) {
            cboVeiculo.Items.Clear();
            cboVeiculo.Items.AddRange(cliente.veiculos.ToArray());
        }

        private void clearDataGridView(DataGridView dataGridView) {
            // Seta o datagrid view como nulo
            dataGridView.DataSource = null;
            dataGridView.Refresh();
        }

        private void refreshDataGridView() {
            clearDataGridView(dgvServicos);
            clearDataGridView(dgvCustosAdicionais);

            refreshDataGridView(dgvServicos);
            refreshDataGridView(dgvCustosAdicionais);
        }

        private void refreshDataGridView(DataGridView dataGridView) {
            // Verifica se o cliente existe
            if (index > -1 && faturamentos.Count > 0 && index < faturamentos.Count && faturamentos[index] != null) {

                List<Servico> valores = null;

                if (dataGridView.Name.Equals(nameof(dgvServicos))) {
                    valores = faturamentos[index].servicos;

                    dataGridView.Columns.Clear();
                    dataGridView.DataSource = valores;
                } else if (dataGridView.Name.Equals(nameof(dgvCustosAdicionais))) {
                    valores = faturamentos[index].custosAdicionais;

                    dataGridView.Columns.Clear();
                    dataGridView.DataSource = valores;
                }

                // Preenche os nomes das colunas
                for (var iCount = 0; iCount < dataGridView.Columns.Count; iCount++) {
                    switch (dataGridView.Columns[iCount].DataPropertyName) {
                        case nameof(Servico.id):
                        case nameof(Servico._idServicoOrcFat):
                        case nameof(Servico._idUnidade):
                            dataGridView.Columns[iCount].Visible = false;
                            break;

                        case nameof(Servico.descricao):
                            dataGridView.Columns[iCount].DisplayIndex = iCount;
                            dataGridView.Columns[iCount].HeaderText = "Descrição";
                            dataGridView.Columns[iCount].Width = 240;
                            dataGridView.Columns[iCount].ReadOnly = true;
                            break;

                        case nameof(Servico.unidade):
                            dataGridView.Columns[iCount].DisplayIndex = iCount;
                            dataGridView.Columns[iCount].HeaderText = "Unidade";
                            dataGridView.Columns[iCount].Width = 100;
                            dataGridView.Columns[iCount].ReadOnly = true;
                            break;

                        case nameof(Servico._quantidade):
                            dataGridView.Columns[iCount].DisplayIndex = iCount;
                            dataGridView.Columns[iCount].HeaderText = "Quantidade";
                            dataGridView.Columns[iCount].Width = 100;
                            break;

                        case nameof(Servico.valor):
                            dataGridView.Columns[iCount].DisplayIndex = iCount;
                            dataGridView.Columns[iCount].HeaderText = "Valor unitário";
                            dataGridView.Columns[iCount].Width = 100;
                            break;

                        case nameof(Servico._total):
                            dataGridView.Columns[iCount].DisplayIndex = iCount;
                            dataGridView.Columns[iCount].HeaderText = "Total";
                            dataGridView.Columns[iCount].Width = 115;
                            dataGridView.Columns[iCount].ReadOnly = true;
                            break;
                    }
                }

                //Preenche os campos que vieram sem preenchimento do data set
                for (var iCount = 0; iCount < dataGridView.Rows.Count; iCount++) {
                    dataGridView.Rows[iCount].Cells[nameof(Servico._total)].Value = Util.formatValor(valores[iCount].valor * valores[iCount]._quantidade);
                }

                dataGridView.Refresh();
            }
        }

        private void windowModeChanged() {

            if (index == -1 || (index > -1 && !faturamentos[index].fechado)) {
                // Faturamento aberto
                btnFecharReabrir.Image = Properties.Resources.cadeado_fechado;

                switch (windowMode) {
                    case Util.WindowMode.ModoNormal:
                    case Util.WindowMode.ModoCriacaoForm:
                        enableFields(windowMode == Util.WindowMode.ModoNormal);

                        if (windowMode == Util.WindowMode.ModoCriacaoForm) {
                            // Especificidades de quando estiver criando o form em branco
                            btnExcluir.Enabled = false;

                            grpServicos.Enabled = false;
                            grpCustosAdicionais.Enabled = false;

                            btnPesquisarCliente.Enabled = false;

                            btnFecharReabrir.Enabled = false;

                        } else {
                            // Especificidades de quando estiver editando normalmente
                            btnExcluir.Enabled = true;

                            grpServicos.Enabled = true;
                            grpCustosAdicionais.Enabled = true;

                            btnPesquisarCliente.Enabled = true;

                            btnFecharReabrir.Enabled = true;
                        }

                        // Botões do CRUD
                        btnAdicionar.Enabled = true;
                        btnCancelar.Enabled = false;
                        btnGravar.Enabled = false;
                        btnAtualizar.Enabled = true;
                        btnPesquisar.Enabled = true;

                        // Datagrid view
                        dgvServicos.Enabled = true;
                        dgvCustosAdicionais.Enabled = true;

                        // Botões de navegação
                        btnPrimeiro.Enabled = true;
                        btnAnterior.Enabled = true;
                        btnProximo.Enabled = true;
                        btnUltimo.Enabled = true;

                        //CRUD das outras funcionalidades
                        btnAdicionarServico.Enabled = true;
                        btnAdicionarCustoAdicional.Enabled = true;
                        break;

                    case Util.WindowMode.ModoDeEdicao:
                    case Util.WindowMode.ModoDeInsercao:
                        enableFields(true);

                        // Botões do CRUD
                        btnAdicionar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnGravar.Enabled = true;
                        btnAtualizar.Enabled = false;
                        btnPesquisar.Enabled = false;
                        btnPesquisarCliente.Enabled = true;

                        // Datagrid view
                        dgvServicos.Enabled = false;
                        dgvCustosAdicionais.Enabled = false;

                        //Botões de navegação
                        btnPrimeiro.Enabled = false;
                        btnAnterior.Enabled = false;
                        btnProximo.Enabled = false;
                        btnUltimo.Enabled = false;

                        // CRUD das outras funcionalidades
                        grpServicos.Enabled = false;
                        grpCustosAdicionais.Enabled = false;

                        btnFecharReabrir.Enabled = false;

                        break;
                }

            } else {
                // Orçamento fechado
                btnFecharReabrir.Image = Properties.Resources.cadeado_aberto;

                enableFields(false);

                btnAdicionar.Enabled = true;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                btnGravar.Enabled = false;
                btnAtualizar.Enabled = true;
                btnPesquisar.Enabled = true;

                btnFecharReabrir.Enabled = true;

                grpServicos.Enabled = false;
                grpCustosAdicionais.Enabled = false;
            }
        }

        private void enableFields(bool enable) {
            grpDadosBasicos.Enabled = enable;
        }

        private void fields_keyDown(object sender, KeyEventArgs e) {
            if (sender != null) {
                TextBox _sender = (TextBox)sender;

                if (_sender.Name == nameof(txtCdCliente) || _sender.Name == nameof(txtNomeCliente)) {
                    // Busca
                } else if (windowMode != Util.WindowMode.ModoDeInsercao && windowMode != Util.WindowMode.ModoCriacaoForm) {
                    windowMode = Util.WindowMode.ModoDeEdicao;
                    windowModeChanged();
                }
            } else if (windowMode != Util.WindowMode.ModoDeInsercao && windowMode != Util.WindowMode.ModoCriacaoForm) {
                windowMode = Util.WindowMode.ModoDeEdicao;
                windowModeChanged();
            }
        }

        private void cboSelectedIndexChanged(object sender, EventArgs e) {
            fields_keyDown(null, null);
        }

        private void clearFields() {
            index = -1;
            
            txtID.Text = "";
            txtCdCliente.Text = "";
            txtNomeCliente.Text = "";
            cboVeiculo.Items.Clear();
            cboFormasPagamento.Items.Clear();
            txtOrcamento.Text = "";
            txtValorTotal.Text = "";
            txtDtCriacao.Text = "";
            txtDtEncerramento.Text = "";

            clearDataGridView(dgvServicos);
            clearDataGridView(dgvCustosAdicionais);

            this.Text = "Faturamento";

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        #endregion

        #region Interfaces - Específico
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            DataGridView dgv = (DataGridView)sender;
            Servico servico = null;

            if (e.RowIndex > -1) {
                if (dgv.Name.Equals(nameof(dgvServicos)))
                    servico = faturamentos[index].servicos[e.RowIndex];
                else if (dgv.Name.Equals(nameof(dgvCustosAdicionais)))
                    servico = faturamentos[index].custosAdicionais[e.RowIndex];
            }

            calculaEAtualizaInformacoesServicos(dgv, servico);

            clearDataGridView(dgvServicos);
            clearDataGridView(dgvCustosAdicionais);

            refreshDataGridView(dgvServicos);
            refreshDataGridView(dgvCustosAdicionais);
        }

        private void calculaEAtualizaInformacoesServicos() {
            txtValorTotal.Text = Util.formatValor(faturamentos[index].valorTotal());
        }

        private void calculaEAtualizaInformacoesServicos(DataGridView dgv, Servico servico) {
            txtValorTotal.Text = Util.formatValor(faturamentos[index].valorTotal());

            if (dgv.Name.Equals(nameof(dgvServicos)))
                gravarServico_Custo(servico, Servico.TipoServico.Servico);
            else if (dgv.Name.Equals(nameof(dgvCustosAdicionais)))
                gravarServico_Custo(servico, Servico.TipoServico.CustoAdicional);

        }

        private void criarServico_Custo(Servico servico, Servico.TipoServico tpServico) {
            if (tpServico == Servico.TipoServico.Servico) {
                FaturamentoServicos.createServicosInFaturamento(faturamentos[index], ref servico, Servico.TipoServico.Servico);
                faturamentos[index].servicos[faturamentos[index].servicos.Count - 1] = servico;
            } else if (tpServico == Servico.TipoServico.CustoAdicional) {
                FaturamentoServicos.createServicosInFaturamento(faturamentos[index], ref servico, Servico.TipoServico.CustoAdicional);
                faturamentos[index].custosAdicionais[faturamentos[index].custosAdicionais.Count - 1] = servico;
            }
        }

        private void gravarServico_Custo(Servico servico, Servico.TipoServico tpServico) {
            if (tpServico == Servico.TipoServico.Servico) {
                FaturamentoServicos.updateServicosInFaturamento(servico, Servico.TipoServico.Servico);
            } else if (tpServico == Servico.TipoServico.CustoAdicional) {
                FaturamentoServicos.updateServicosInFaturamento(servico, Servico.TipoServico.CustoAdicional);
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e) {
            if (index > -1 && faturamentos[index].numOrcamento > 0) {
                MessageBox.Show("Não é possível alterar o cliente quando o faturamento foi gerado com base no orçamento",
                            "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                return;
            }

            fields_keyDown(null, null);

            consultaClienteForm = new ConsultaCliente(Util.TipoConsulta.Selecao);
            consultaClienteForm.FormClosing += ConsultaClienteForm_FormClosing;
            consultaClienteForm.Show();
        }

        private void ConsultaClienteForm_FormClosing(object sender, FormClosingEventArgs e) {
            Cliente clienteSelecionado = consultaClienteForm.clienteSelecionado;

            if (clienteSelecionado != null) {

                if (windowMode != Util.WindowMode.ModoDeInsercao) {
                    faturamentos[index].cliente = clienteSelecionado;
                }

                preencheInformacoesCliente(clienteSelecionado);
            }

        }

        private void btnAdicionarServico_Click(object sender, EventArgs e) {
            fields_keyDown(null, null);

            string formChamador = "";

            Button botaoChamador = (Button)sender;
            if (botaoChamador.Name.Equals(nameof(btnAdicionarServico)))
                formChamador = nameof(Faturamento.servicos);
            else if (botaoChamador.Name.Equals(nameof(btnAdicionarCustoAdicional)))
                formChamador = nameof(Faturamento.custosAdicionais);

            consultaServicoForm = new ConsultaServico(Util.TipoConsulta.Selecao, formChamador);
            consultaServicoForm.FormClosing += ConsultaServicoForm_FormClosing;
            consultaServicoForm.ShowDialog();
        }

        private void ConsultaServicoForm_FormClosing(object sender, FormClosingEventArgs e) {
            ConsultaServico formChamador = (ConsultaServico)sender;

            Servico servicoSelecionado = consultaServicoForm.servicoSelecionado;
            Servico.TipoServico tpServico = 0;

            if (servicoSelecionado != null) {
                if (formChamador.Tag.Equals(nameof(Faturamento.servicos))) {
                    faturamentos[index].servicos.Add(servicoSelecionado);
                    tpServico = Servico.TipoServico.Servico;
                } else if (formChamador.Tag.Equals(nameof(Faturamento.custosAdicionais))) {
                    faturamentos[index].custosAdicionais.Add(servicoSelecionado);
                    tpServico = Servico.TipoServico.CustoAdicional;
                }

                criarServico_Custo(servicoSelecionado, tpServico);
                btnGravar_Click(null, null);
            } else {
                btnCancelar_Click(null, null);
            }
        }

        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            DataGridView dgv = (DataGridView)sender;

            if (e.ColumnIndex > -1 && e.RowIndex > -1) {

                string coluna = dgv.Columns[e.ColumnIndex].Name;
                string nomeColuna = dgv.Columns[e.ColumnIndex].HeaderText;

                if (coluna.Equals(nameof(Servico.valor)) || coluna.Equals(nameof(Servico._quantidade))) {
                    float valorDigitado;

                    if (!float.TryParse(e.FormattedValue.ToString(), out valorDigitado)) {

                        MessageBox.Show(String.Format("O valor digitado no campo {0} deve ser numérico", nomeColuna),
                            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        e.Cancel = true;
                    }

                }
            }

        }

        private void btnExcluirServico_Click(object sender, EventArgs e) {
            Button btnExclurPressionado = (Button)sender;

            DataGridView dgv = null;
            List<Servico> listaServicos = null;
            String nome = "";

            // Verifica se é pra excluir serviço ou custo adicional
            if (btnExclurPressionado.Name.Equals(nameof(btnExcluirServico))) {
                dgv = dgvServicos;
                listaServicos = faturamentos[index].servicos;
                nome = "serviço";
            } else if (btnExclurPressionado.Name.Equals(nameof(btnExcluirCustoAdicional))) {
                dgv = dgvCustosAdicionais;
                listaServicos = faturamentos[index].custosAdicionais;
                nome = "custo adicional";
            }

            if (dgv.SelectedCells.Count > 0) {
                Servico servicoADeletar = listaServicos[dgv.SelectedCells[0].RowIndex];

                if (MessageBox.Show(String.Format("Confirma a deleção do {0}?", nome) +
                    Environment.NewLine + Environment.NewLine +
                    servicoADeletar.ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    // Verifica se é pra excluir serviço ou custo adicional
                    if (btnExclurPressionado.Name.Equals(nameof(btnExcluirServico))) {
                        faturamentos[index].servicos.Remove(servicoADeletar);
                    } else if (btnExclurPressionado.Name.Equals(nameof(btnExcluirCustoAdicional))) {
                        faturamentos[index].custosAdicionais.Remove(servicoADeletar);
                    }

                    dataGridView_CellEndEdit(null, null);

                }

            }

        }

        private void btnFecharReabrir_Click(object sender, EventArgs e) {
            // Verifica se vai fechar
            if (!faturamentos[index].fechado) {
                // Vai fechar

                if (MessageBox.Show("Tem certeza que quer fechar o faturamento?",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    Faturamento faturamentoAtualizado = faturamentos[index];

                    String mensagemRetorno = "";

                    // Verifica se fechou com sucesso
                    if (FaturamentoServicos.fechaFaturamento(ref faturamentoAtualizado, ref mensagemRetorno)) {
                        faturamentos[index] = faturamentoAtualizado;

                        fillFields();
                    } else {
                        MessageBox.Show(String.Format("Não foi possível fechar o faturamento.\n\n{0}", mensagemRetorno),
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }

            } else {
                // Vai reabrir

                if (MessageBox.Show("Tem certeza que quer reabrir o faturamento?",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    Faturamento faturamentoAtualizado = faturamentos[index];

                    String mensagemRetorno = "";

                    // Verifica se reabriu com sucesso
                    if (FaturamentoServicos.reabreFaturamento(ref faturamentoAtualizado, ref mensagemRetorno)) {
                        faturamentos[index] = faturamentoAtualizado;

                        fillFields();
                    } else {
                        MessageBox.Show(String.Format("Não foi possível reabrir o faturamento.\n\n{0}", mensagemRetorno),
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void btnConsultarValorServico_Click(object sender, EventArgs e) {
            // Cria o menu de contexto
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem toolStripMenuItem;

            toolStripMenuItem = new ToolStripMenuItem("QualP");
            toolStripMenuItem.Click += abreLink;
            toolStripMenuItem.Image = Properties.Resources.rotas_qualp;
            toolStripMenuItem.Tag = "https://qualp.com.br/";
            contextMenuStrip.Items.Add(toolStripMenuItem);

            toolStripMenuItem = new ToolStripMenuItem("Rotas Brasil");
            toolStripMenuItem.Click += abreLink;
            toolStripMenuItem.Image = Properties.Resources.rotas_rotasbrasil;
            toolStripMenuItem.Tag = "http://rotasbrasil.com.br/";
            contextMenuStrip.Items.Add(toolStripMenuItem);

            toolStripMenuItem = new ToolStripMenuItem("Google Maps");
            toolStripMenuItem.Click += abreLink;
            toolStripMenuItem.Image = Properties.Resources.rotas_maps;
            toolStripMenuItem.Tag = "https://www.google.com.br/maps/";
            contextMenuStrip.Items.Add(toolStripMenuItem);

            // Exibe o menu de contexto
            contextMenuStrip.Show(this, this.PointToClient(MousePosition));
        }

        private void abreLink(object _sender, EventArgs e) {
            ToolStripMenuItem sender = (ToolStripMenuItem)_sender;
            String url = sender.Tag.ToString();
            System.Diagnostics.Process.Start(url);
        }

        private void txtOrcamento_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (index > -1) {
                int numOrcamento = faturamentos[index].numOrcamento;
                int numFaturamento = faturamentos[index].id;
                String cliente = faturamentos[index].cliente.nome;

                if (numOrcamento > 0) {
                    // Cria o menu de contexto
                    ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                    ToolStripMenuItem toolStripMenuItem;

                    toolStripMenuItem = new ToolStripMenuItem(String.Format("Desvicular orçamento {0} do faturamento {1}", numOrcamento, numFaturamento));
                    toolStripMenuItem.Click += (_sender, _e) => {
                        // desviculaOrcamentoDoFaturamento
                        faturamentos[index].numOrcamento = 0;
                        FaturamentoServicos.update(faturamentos[index]);

                        btnAtualizar_Click(null, null);
                    };
                    contextMenuStrip.Items.Add(toolStripMenuItem);

                    // Exibe o menu de contexto
                    contextMenuStrip.Show(this, this.PointToClient(MousePosition));
                } else {
                    // Cria o menu de contexto
                    ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                    ToolStripMenuItem toolStripMenuItem;

                    toolStripMenuItem = new ToolStripMenuItem(String.Format("Vincular faturamento {0} com orçamento do cliente {1}", numFaturamento, cliente));
                    toolStripMenuItem.Click += (_sender, _e) => {
                        // vincularOrcamentoAoFaturamento
                        consultaOrcamentoForm = new ConsultaOrcamento(Util.TipoConsulta.Selecao, true, faturamentos[index].cliente.id);
                        consultaOrcamentoForm.FormClosing += (__sender, __e) => {
                            Orcamento orcamentoSelecionado = consultaOrcamentoForm.orcamentoSelecionado;

                            if (orcamentoSelecionado != null) {
                                faturamentos[index].numOrcamento = orcamentoSelecionado.id;
                                FaturamentoServicos.update(faturamentos[index]);

                                btnAtualizar_Click(null, null);
                            }
                        };
                        consultaOrcamentoForm.Show();
                    };
                    contextMenuStrip.Items.Add(toolStripMenuItem);

                    // Exibe o menu de contexto
                    contextMenuStrip.Show(this, this.PointToClient(MousePosition));
                }
            }
        }
        #endregion
    }
}