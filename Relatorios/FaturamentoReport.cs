using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SistemaGuincho.Model;
using SistemaGuincho.Servicos;
using SistemaGuincho.Utilidades;
using SistemaGuincho.Views;

namespace SistemaGuincho.Relatorios {
    public partial class FaturamentoReport : Form {

        #region Atributos da classe
        private Faturamentos formFaturamento;
        private Orcamentos formOrcamento; // TODO

        private List<FormaPagamento> formasPagamento;
        private List<Servico> servicos;
        private List<Servico> custosAdicionais;
        private List<Cliente> clientes;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();
        }

        public FaturamentoReport() {
            init();
        }

        private void FaturamentoReport_Load(object sender, EventArgs e) {
            //refreshDataGridView(null);

            preencheCheckedListBox();

            if (1 == 2) {
                // Seleciona os clientes
                chkLstClientes.SetItemChecked(0, true);
                chkLstClientes.SetItemChecked(clientes.Count - 1, true);

                // Seleciona os serviços
                chkLstServicos.SetItemChecked(0, true);
                chkLstServicos.SetItemChecked(servicos.Count - 1, true);

                // Seleciona os custos adicionais
                chkLstCustosAdicionais.SetItemChecked(0, true);
                chkLstCustosAdicionais.SetItemChecked(custosAdicionais.Count - 1, true);

                // Seleciona as formas de pagamento
                chkLstFormasPagamento.SetItemChecked(0, true);
                chkLstFormasPagamento.SetItemChecked(formasPagamento.Count - 1, true);

                // Seleciona a data de criação
                chkDataCriacao.Checked = true;
                txtDtCriacaoInicio.Text = "15/02/2008";
                txtDtCriacaoFim.Text = "31/12/2020";

                // Seleciona a data de encerramento

                // Seleciona apenas fechados
            }

        }
        #endregion

        #region Interfaces - Comum
        private void clearDataGridView() {
            // Seta o datagrid view como nulo
            dgvFaturamentos.DataSource = null;
            dgvFaturamentos.Refresh();
        }

        private void refreshDataGridView(Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio tpRelatorio, Object orcamentoFaturamento) {
            clearDataGridView();

            dgvFaturamentos.Columns.Clear();

            dgvFaturamentos.DataSource = orcamentoFaturamento;

            dgvFaturamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "Valor_custom" });
            dgvFaturamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "DataCriacao_custom" });
            dgvFaturamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "DataEncerramento_custom" });
            dgvFaturamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "Servicos_custom" });
            dgvFaturamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "CustosAdicionais_custom" });
            dgvFaturamentos.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { DataPropertyName = "Orcamento_Origem" });

            // Preenche os nomes das colunas
            for (var iCount = 0; iCount < dgvFaturamentos.Columns.Count; iCount++) {
                switch (dgvFaturamentos.Columns[iCount].DataPropertyName) {
                    case nameof(Faturamento.custosAdicionais):
                    case nameof(Faturamento.servicos):
                    case nameof(Faturamento.dataCriacao):
                    case nameof(Faturamento.dataEncerramento):
                    case nameof(Faturamento._idFormaPagamento):
                    case nameof(Faturamento._idCliente):
                    case nameof(Faturamento._idVeiculo):
                    case nameof(Faturamento.numOrcamento):
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

                    case nameof(Faturamento.formaPagamento):
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 4;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Forma de Pagamento";
                        dgvFaturamentos.Columns[iCount].Width = 125;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case nameof(Faturamento.fechado):
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 5;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Fechado";
                        dgvFaturamentos.Columns[iCount].Width = 75;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case "Orcamento_Origem":
                        dgvFaturamentos.Columns[iCount].Name = dgvFaturamentos.Columns[iCount].DataPropertyName;
                        dgvFaturamentos.Columns[iCount].ReadOnly = tpRelatorio == Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Faturamento;
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 6;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Orçamento origem";
                        dgvFaturamentos.Columns[iCount].Width = 100;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case "DataCriacao_custom":
                        dgvFaturamentos.Columns[iCount].Name = dgvFaturamentos.Columns[iCount].DataPropertyName;
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 7;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Criação";
                        dgvFaturamentos.Columns[iCount].Width = 100;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case "DataEncerramento_custom":
                        dgvFaturamentos.Columns[iCount].Name = dgvFaturamentos.Columns[iCount].DataPropertyName;
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 8;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Encerramento";
                        dgvFaturamentos.Columns[iCount].Width = 100;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case "Servicos_custom":
                        dgvFaturamentos.Columns[iCount].Name = dgvFaturamentos.Columns[iCount].DataPropertyName;
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 9;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Total dos serviços";
                        dgvFaturamentos.Columns[iCount].Width = 100;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                    case "CustosAdicionais_custom":
                        dgvFaturamentos.Columns[iCount].Name = dgvFaturamentos.Columns[iCount].DataPropertyName;
                        dgvFaturamentos.Columns[iCount].DisplayIndex = 10;
                        dgvFaturamentos.Columns[iCount].HeaderText = "Total dos custos adicionais";
                        dgvFaturamentos.Columns[iCount].Width = 100;
                        dgvFaturamentos.Columns[iCount].ReadOnly = true;
                        break;

                }
            }

            //Preenche os campos que vieram sem preenchimento do data set
            for (int iCount = 0; iCount < dgvFaturamentos.Rows.Count; iCount++) {
                if (tpRelatorio == Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Orcamento) {
                    List<Orcamento> orcamentos = (List<Orcamento>)orcamentoFaturamento;

                    dgvFaturamentos.Rows[iCount].Cells["Valor_custom"].Value = Util.formatValor(orcamentos[iCount].valorTotal());
                    dgvFaturamentos.Rows[iCount].Cells["DataCriacao_custom"].Value = orcamentos[iCount].dataCriacao.ToString("dd/MM/yyyy");
                    dgvFaturamentos.Rows[iCount].Cells["DataEncerramento_custom"].Value = orcamentos[iCount].dataEncerramento?.ToString("dd/MM/yyyy");

                    dgvFaturamentos.Rows[iCount].Cells["Servicos_custom"].Value = Util.formatValor(orcamentos[iCount].valorTotalServicos());
                    dgvFaturamentos.Rows[iCount].Cells["CustosAdicionais_custom"].Value = Util.formatValor(orcamentos[iCount].valorTotalCustosAdicionais());
                } else {
                    List<Faturamento> faturamentos = (List<Faturamento>)orcamentoFaturamento;

                    dgvFaturamentos.Rows[iCount].Cells["Valor_custom"].Value = Util.formatValor(faturamentos[iCount].valorTotal());
                    dgvFaturamentos.Rows[iCount].Cells["DataCriacao_custom"].Value = faturamentos[iCount].dataCriacao.ToString("dd/MM/yyyy");
                    dgvFaturamentos.Rows[iCount].Cells["DataEncerramento_custom"].Value = faturamentos[iCount].dataEncerramento?.ToString("dd/MM/yyyy");

                    dgvFaturamentos.Rows[iCount].Cells["Servicos_custom"].Value = Util.formatValor(faturamentos[iCount].valorTotalServicos());
                    dgvFaturamentos.Rows[iCount].Cells["CustosAdicionais_custom"].Value = Util.formatValor(faturamentos[iCount].valorTotalCustosAdicionais());

                    if (faturamentos[iCount].numOrcamento > 0)
                        dgvFaturamentos.Rows[iCount].Cells["Orcamento_Origem"].Value = faturamentos[iCount].numOrcamento;
                }
            }

            dgvFaturamentos.Refresh();

        }

        private void dgvFaturamentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                //Faturamento faturamento = faturamentos[e.RowIndex];
                //
                //formFaturamento = new Faturamentos(faturamento);
                //formFaturamento.Load += FormFaturamento_Load;
                //formFaturamento.Show();
            }
        }

        private void FormFaturamento_Load(object sender, EventArgs e) {
            Close();
        }

        private void preencheCheckedListBox() {
            //read
            formasPagamento = FormaPagamentoServicos.Instance.read();
            servicos = ServicoServicos.Instance.read();
            custosAdicionais = new List<Servico>(servicos);
            clientes = ClienteServicos.Instance.read();

            // Preenche
            chkLstFormasPagamento.Items.AddRange(formasPagamento.ToArray());
            chkLstServicos.Items.AddRange(servicos.ToArray());
            chkLstCustosAdicionais.Items.AddRange(custosAdicionais.ToArray());
            chkLstClientes.Items.AddRange(clientes.ToArray());
        }

        private void radioButtonCheckedChange(object sender, EventArgs e) {
            RadioButton radioButton = (RadioButton)sender;

            Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio tipoRelatorio = Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Orcamento;

            switch (radioButton.Name) {
                case nameof(rdbtOrcamento):
                    if (radioButton.Checked)
                        tipoRelatorio = Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Orcamento;
                    else
                        tipoRelatorio = Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Faturamento;
                    break;

                case nameof(rdbtFaturamento):
                    if (radioButton.Checked)
                        tipoRelatorio = Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Faturamento; 
                    else
                        tipoRelatorio = Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Orcamento;
                    break;
            }

            switch (tipoRelatorio) {
                case Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Orcamento:
                    chkApenasFechado.Text = "Apenas orçamentos fechados";
                    Text = "Relatório de Orçamentos";
                    chkFormasPagamento.Enabled = false;
                    chkLstFormasPagamento.Enabled = false;

                    break;
                case Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Faturamento:
                    chkApenasFechado.Text = "Apenas faturamentos fechados";
                    Text = "Relatório de Faturamentos";
                    chkFormasPagamento.Enabled = true;

                    chkLstFormasPagamento.Enabled = chkFormasPagamento.Checked;
                    break;
            }

        }

        private void checkbBoxCheckedChange(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;

            switch (checkBox.Name) {
                case nameof(chkFormasPagamento):
                    chkLstFormasPagamento.Enabled = checkBox.Checked;
                    break;
                case nameof(chkServicos):
                    chkLstServicos.Enabled = checkBox.Checked;
                    break;
                case nameof(chkCustosAdicionais):
                    chkLstCustosAdicionais.Enabled = checkBox.Checked;
                    break;
                case nameof(chkCliente):
                    chkLstClientes.Enabled = checkBox.Checked;
                    break;
                case nameof(chkDataCriacao):
                    grpDtCriacao.Enabled = checkBox.Checked;
                    break;
                case nameof(chkDataFechamento):
                    grpDtFechamento.Enabled = checkBox.Checked;
                    break;
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e) {
            Faturamento_OrcamentoFiltroRelatorio faturamentoFiltroRelatorio;

            if (rdbtOrcamento.Checked)
                faturamentoFiltroRelatorio = new Faturamento_OrcamentoFiltroRelatorio(Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Orcamento);
            else 
                faturamentoFiltroRelatorio = new Faturamento_OrcamentoFiltroRelatorio(Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Faturamento);

            faturamentoFiltroRelatorio.apenasFechados = chkApenasFechado.Checked;

            if (chkFormasPagamento.Checked) {
                faturamentoFiltroRelatorio.formasPagamentoSelecionadas = chkLstFormasPagamento.CheckedItems.OfType<FormaPagamento>().ToList();
            }
            if (chkServicos.Checked) {
                faturamentoFiltroRelatorio.servicosSelecionados = chkLstServicos.CheckedItems.OfType<Servico>().ToList();
            }
            if (chkCustosAdicionais.Checked) {
                faturamentoFiltroRelatorio.custosAdicionaisSelecionados = chkLstCustosAdicionais.CheckedItems.OfType<Servico>().ToList();
            }
            if (chkCliente.Checked) {
                faturamentoFiltroRelatorio.clientesSelecionados = chkLstClientes.CheckedItems.OfType<Cliente>().ToList();
            }
            if (chkDataCriacao.Checked) {
                DateTime _dtCriacaoInicio, _dtCriacaoFim;
                DateTime.TryParse(txtDtCriacaoInicio.Text.ToString(), out _dtCriacaoInicio);
                DateTime.TryParse(txtDtCriacaoFim.Text.ToString(), out _dtCriacaoFim);

                faturamentoFiltroRelatorio.dtCriacaoInicio = _dtCriacaoInicio;
                faturamentoFiltroRelatorio.dtCriacaoFim = _dtCriacaoFim;
            }
            if (chkDataFechamento.Checked) {
                DateTime _dtEncerramentoInicio, _dtEncerramentoFim;
                DateTime.TryParse(txtDtCriacaoInicio.Text.ToString(), out _dtEncerramentoInicio);
                DateTime.TryParse(txtDtCriacaoFim.Text.ToString(), out _dtEncerramentoFim);

                faturamentoFiltroRelatorio.dtEncerramentoInicio = _dtEncerramentoInicio;
                faturamentoFiltroRelatorio.dtEncerramentoFim = _dtEncerramentoFim;
            }

            if (faturamentoFiltroRelatorio.tpRelatorio == Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Orcamento) {
                refreshDataGridView(faturamentoFiltroRelatorio.tpRelatorio, OrcamentoServicos.reportOrcamento(faturamentoFiltroRelatorio));
            } else {
                refreshDataGridView(faturamentoFiltroRelatorio.tpRelatorio, FaturamentoServicos.reportFaturamento(faturamentoFiltroRelatorio));
            }
        }
        #endregion
    }
}