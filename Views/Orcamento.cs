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
    public partial class Orcamentos : Form {

        #region Atributos da classe
        private Util.WindowMode windowMode;

        private List<Orcamento> orcamentos;

        private int index;

        private ConsultaCliente consultaClienteForm;
        private ConsultaServico consultaServicoForm;                  //TODO
        //private ConsultaCustoAdicional consultaCustoAdicionalForm;    //TODO

        public enum Edicao {
            DadosDoOrcamento,
            DadosDosServicos,
            DadosDosCustosAdicionais
        };
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();

            index = -1;

            orcamentos = new List<Orcamento>();

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        public Orcamentos(){
            init();

            getFromRepositorio();
        }

        public Orcamentos(Orcamento orcamento) : this() {
            index = orcamentos.FindIndex(find => find.id == orcamento.id);

            selecionaOrcamento();
        }

        private void getFromRepositorio() {
            orcamentos = OrcamentoServicos.read();
        }
        #endregion

        #region Botões de navegação
        private void btnPrimeiro_Click(object sender, EventArgs e) {
            if (orcamentos.Count > 0) {
                if (index != 0) {
                    index = 0;
                    selecionaOrcamento();
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if (index - 1 >= 0) {
                index--;
                selecionaOrcamento();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e) {
            if (index + 1 < orcamentos.Count) {
                index++;
                selecionaOrcamento();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            if (orcamentos.Count > 0) {
                if (index != orcamentos.Count - 1) {
                    index = orcamentos.Count - 1;
                    selecionaOrcamento();
                }
            }
        }

        private void selecionaOrcamento() {
            fillFields();
        }
        #endregion

        #region CRUD
        // Aciona a criação de um novo cliente
        private void btnAdicionar_Click(object sender, EventArgs e) {
            index = 0;
            txtNomeCliente.Focus();
            clearFields();

            windowMode = Util.WindowMode.ModoDeInsercao;
            windowModeChanged();

            btnPesquisarCliente_Click(null, null);
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
            Orcamento newOrcamento;

            // Cria os dados básicos do orçamento
            int idCliente = -1; int.TryParse(txtCdCliente.Text, out idCliente);

            if (txtCdCliente.Text.Trim().Length == 0) {
                MessageBox.Show("Não foi possível salvar o orçamento.\n\nDeve ser selecionado um cliente",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            } else {

                Cliente cliente = ClienteServicos.read(idCliente);
                Veiculo veiculo = (Veiculo)cboVeiculo.SelectedItem;

                newOrcamento = new Orcamento(cliente, veiculo);

                // Verifica se vai inserir um novo registro ou então salvá-lo
                if (windowMode == Util.WindowMode.ModoDeInsercao) {
                    // Cria novo orçameto

                    if (OrcamentoServicos.create(ref newOrcamento)) {
                        getFromRepositorio();
                        btnUltimo_Click(null, null);
                    } else {
                        clearFields();
                    }

                } else if (windowMode == Util.WindowMode.ModoDeEdicao) {
                    // Grava orçamento já existente

                    newOrcamento.id = orcamentos[index].id;
                    newOrcamento.servicos = orcamentos[index].servicos;
                    newOrcamento.custosAdicionais = orcamentos[index].custosAdicionais;

                    if (OrcamentoServicos.update(newOrcamento)) {
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
                    orcamentos[index].ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                OrcamentoServicos.delete(orcamentos[index]);

                getFromRepositorio();
                clearFields();
            }
        }

        // Atualiza as informações dos Orcamento
        private void btnAtualizar_Click(object sender, EventArgs e) {
            getFromRepositorio();

            if (index > -1)
                index = orcamentos.FindIndex(clienteAEncontrar => clienteAEncontrar.id == orcamentos[index].id);

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
            if (index > -1 && orcamentos.Count > 0 && index < orcamentos.Count && orcamentos[index] != null) {
                // Preenche as informações básicas do orçamento
                txtID.Text = orcamentos[index].id.ToString();
                preencheInformacoesCliente(orcamentos[index].cliente);
                cboVeiculo.SelectedItem = orcamentos[index].veiculo;

                refreshDataGridView();

                calculaEAtualizaInformacoesServicos();

                windowMode = Util.WindowMode.ModoNormal;
                windowModeChanged();

                // Atualiza o nome do formulário
                this.Text = String.Format("Orçamento: {0} - {1}", orcamentos[index].id, orcamentos[index].cliente.nome);

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
            if (index > -1 && orcamentos.Count > 0 && index < orcamentos.Count && orcamentos[index] != null) {

                List<Servico> valores = null;

                if (dataGridView.Name.Equals(nameof(dgvServicos))) {
                    valores = orcamentos[index].servicos;

                    dataGridView.Columns.Clear();
                    dataGridView.DataSource = valores;
                } else if (dataGridView.Name.Equals(nameof(dgvCustosAdicionais))) {
                    valores = orcamentos[index].custosAdicionais;

                    dataGridView.Columns.Clear();
                    dataGridView.DataSource = valores;
                }

                // Preenche os nomes das colunas
                for (var iCount = 0; iCount < dataGridView.Columns.Count; iCount++) {
                    switch (dataGridView.Columns[iCount].DataPropertyName) {
                        case nameof(Servico.id):
                            dataGridView.Columns[iCount].Visible = false;
                            break;

                        case nameof(Servico.descricao):
                            dataGridView.Columns[iCount].DisplayIndex = 0;
                            dataGridView.Columns[iCount].HeaderText = "Descrição";
                            dataGridView.Columns[iCount].Width = 240;
                            dataGridView.Columns[iCount].ReadOnly = true;
                            break;

                        case nameof(Servico.unidade):
                            dataGridView.Columns[iCount].DisplayIndex = 1;
                            dataGridView.Columns[iCount].HeaderText = "Unidade";
                            dataGridView.Columns[iCount].Width = 100;
                            dataGridView.Columns[iCount].ReadOnly = true;
                            break;

                        case nameof(Servico._quantidade):
                            dataGridView.Columns[iCount].DisplayIndex = 2;
                            dataGridView.Columns[iCount].HeaderText = "Quantidade";
                            dataGridView.Columns[iCount].Width = 100;
                            break;

                        case nameof(Servico.valor):
                            dataGridView.Columns[iCount].DisplayIndex = 3;
                            dataGridView.Columns[iCount].HeaderText = "Valor un.";
                            dataGridView.Columns[iCount].Width = 100;
                            break;

                        case nameof(Servico._total):
                            dataGridView.Columns[iCount].DisplayIndex = 4;
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

            if (index == -1 || (index > -1 && !orcamentos[index].fechado)) {
                // Orçamento aberto
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

        private void cboVeiculo_SelectedIndexChanged(object sender, EventArgs e) {
            fields_keyDown(null, null);
        }

        private void clearFields() {
            index = -1;
            
            txtID.Text = "";
            txtCdCliente.Text = "";
            txtNomeCliente.Text = "";
            cboVeiculo.Items.Clear();

            clearDataGridView(dgvServicos);
            clearDataGridView(dgvCustosAdicionais);

            this.Text = "Orcamento";

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        #endregion

        #region Interfaces - Específico
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            calculaEAtualizaInformacoesServicos();

            clearDataGridView(dgvServicos);
            clearDataGridView(dgvCustosAdicionais);

            refreshDataGridView(dgvServicos);
            refreshDataGridView(dgvCustosAdicionais);
        }

        private void calculaEAtualizaInformacoesServicos() {
            txtValorTotal.Text = Util.formatValor(orcamentos[index].valorTotal());
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e) {
            fields_keyDown(null, null);

            consultaClienteForm = new ConsultaCliente(Util.TipoConsulta.Selecao);
            consultaClienteForm.FormClosing += ConsultaClienteForm_FormClosing;
            consultaClienteForm.Show();
        }

        private void ConsultaClienteForm_FormClosing(object sender, FormClosingEventArgs e) {
            Cliente clienteSelecionado = consultaClienteForm.clienteSelecionado;

            if (clienteSelecionado != null) {

                if (windowMode != Util.WindowMode.ModoDeInsercao) {
                    orcamentos[index].cliente = clienteSelecionado;
                }

                preencheInformacoesCliente(clienteSelecionado);
            }

        }

        private void btnAdicionarServico_Click(object sender, EventArgs e) {
            fields_keyDown(null, null);

            string formChamador = "";

            Button botaoChamador = (Button)sender;
            if (botaoChamador.Name.Equals(nameof(btnAdicionarServico)))
                formChamador = nameof(Orcamento.servicos);
            else if (botaoChamador.Name.Equals(nameof(btnAdicionarCustoAdicional)))
                formChamador = nameof(Orcamento.custosAdicionais);

            consultaServicoForm = new ConsultaServico(Util.TipoConsulta.Selecao, formChamador);
            consultaServicoForm.FormClosing += ConsultaServicoForm_FormClosing;
            consultaServicoForm.ShowDialog();
        }

        private void ConsultaServicoForm_FormClosing(object sender, FormClosingEventArgs e) {
            ConsultaServico formChamador = (ConsultaServico)sender;

            Servico servicoSelecionado = consultaServicoForm.servicoSelecionado;

            if (servicoSelecionado != null) {
                if (formChamador.Tag.Equals(nameof(Orcamento.servicos)))
                    orcamentos[index].servicos.Add(servicoSelecionado);
                else if (formChamador.Tag.Equals(nameof(Orcamento.custosAdicionais)))
                    orcamentos[index].custosAdicionais.Add(servicoSelecionado);

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

        #endregion

        private void btnExcluirServico_Click(object sender, EventArgs e) {
            Button btnExclurPressionado = (Button)sender;

            DataGridView dgv = null;
            List<Servico> listaServicos = null;
            String nome = "";

            // Verifica se é pra excluir serviço ou custo adicional
            if (btnExclurPressionado.Name.Equals(nameof(btnExcluirServico))) {
                dgv = dgvServicos;
                listaServicos = orcamentos[index].servicos;
                nome = "serviço";
            } else if (btnExclurPressionado.Name.Equals(nameof(btnExcluirCustoAdicional))) {
                dgv = dgvCustosAdicionais;
                listaServicos = orcamentos[index].custosAdicionais;
                nome = "custo adicional";
            }

            if (dgv.SelectedCells.Count > 0) {
                Servico servicoADeletar = listaServicos[dgv.SelectedCells[0].RowIndex];

                if (MessageBox.Show( String.Format("Confirma a deleção do {0}?", nome) +
                    Environment.NewLine + Environment.NewLine +
                    servicoADeletar.ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    // Verifica se é pra excluir serviço ou custo adicional
                    if (btnExclurPressionado.Name.Equals(nameof(btnExcluirServico))) {
                        orcamentos[index].servicos.Remove(servicoADeletar);
                    } else if (btnExclurPressionado.Name.Equals(nameof(btnExcluirCustoAdicional))) {
                        orcamentos[index].custosAdicionais.Remove(servicoADeletar);
                    }

                    dataGridView_CellEndEdit(null, null);

                }

            }

        }

        private void btnFecharReabrir_Click(object sender, EventArgs e) {
            // Verifica se vai fechar
            if (!orcamentos[index].fechado) {
                // Vai fechar

                if (MessageBox.Show("Tem certeza que quer fechar o orçamento?",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    Orcamento orcamentoAtualizado = orcamentos[index];

                    String mensagemRetorno = "";

                    // Verifica se fechou com sucesso
                    if (OrcamentoServicos.fechaOrcamento(ref orcamentoAtualizado, ref mensagemRetorno)) {
                        orcamentos[index] = orcamentoAtualizado;

                        windowModeChanged();
                    } else {
                        MessageBox.Show(String.Format("Não foi possível fechar o orçamento.\n\n{0}", mensagemRetorno),
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }

            } else {
                // Vai reabrir

                if (MessageBox.Show("Tem certeza que quer reabrir o orçamento?",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    Orcamento orcamentoAtualizado = orcamentos[index];

                    String mensagemRetorno = "";

                    // Verifica se reabriu com sucesso
                    if (OrcamentoServicos.reabreOrcamento(ref orcamentoAtualizado, ref mensagemRetorno)) {
                        orcamentos[index] = orcamentoAtualizado;

                        windowModeChanged();
                    } else {
                        MessageBox.Show(String.Format("Não foi possível reabrir o orçamento.\n\n{0}", mensagemRetorno),
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
    }
}