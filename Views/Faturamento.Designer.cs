namespace SistemaGuincho.Views {
    partial class Faturamentos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblNumFaturamento = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.cboFormasPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDtEncerramento = new System.Windows.Forms.TextBox();
            this.cboVeiculo = new System.Windows.Forms.ComboBox();
            this.lblDtEncerramento = new System.Windows.Forms.Label();
            this.txtCdCliente = new System.Windows.Forms.TextBox();
            this.txtDtCriacao = new System.Windows.Forms.TextBox();
            this.lblDtGeracao = new System.Windows.Forms.Label();
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.lblFaturamentoGerado = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.grpServicos = new System.Windows.Forms.GroupBox();
            this.grpCustosAdicionais = new System.Windows.Forms.GroupBox();
            this.dgvCustosAdicionais = new System.Windows.Forms.DataGridView();
            this.btnConsultarValorServico = new System.Windows.Forms.Button();
            this.btnImprimirRecibo = new System.Windows.Forms.Button();
            this.btnFecharReabrir = new System.Windows.Forms.Button();
            this.btnAdicionarCustoAdicional = new System.Windows.Forms.Button();
            this.btnExcluirCustoAdicional = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdicionarServico = new System.Windows.Forms.Button();
            this.btnExcluirServico = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grpDadosBasicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.grpServicos.SuspendLayout();
            this.grpCustosAdicionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustosAdicionais)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumFaturamento
            // 
            this.lblNumFaturamento.AutoSize = true;
            this.lblNumFaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFaturamento.Location = new System.Drawing.Point(16, 26);
            this.lblNumFaturamento.Name = "lblNumFaturamento";
            this.lblNumFaturamento.Size = new System.Drawing.Size(58, 16);
            this.lblNumFaturamento.TabIndex = 0;
            this.lblNumFaturamento.Text = "Código";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(77, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(247, 24);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(312, 22);
            this.txtNomeCliente.TabIndex = 3;
            this.txtNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(135, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 16);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(602, 26);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(60, 16);
            this.lblVeiculo.TabIndex = 4;
            this.lblVeiculo.Text = "Veículo";
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.cboFormasPagamento);
            this.grpDadosBasicos.Controls.Add(this.label1);
            this.grpDadosBasicos.Controls.Add(this.btnPesquisarCliente);
            this.grpDadosBasicos.Controls.Add(this.txtDtEncerramento);
            this.grpDadosBasicos.Controls.Add(this.cboVeiculo);
            this.grpDadosBasicos.Controls.Add(this.lblDtEncerramento);
            this.grpDadosBasicos.Controls.Add(this.txtCdCliente);
            this.grpDadosBasicos.Controls.Add(this.txtDtCriacao);
            this.grpDadosBasicos.Controls.Add(this.lblVeiculo);
            this.grpDadosBasicos.Controls.Add(this.lblDtGeracao);
            this.grpDadosBasicos.Controls.Add(this.txtNomeCliente);
            this.grpDadosBasicos.Controls.Add(this.txtOrcamento);
            this.grpDadosBasicos.Controls.Add(this.lblCliente);
            this.grpDadosBasicos.Controls.Add(this.txtID);
            this.grpDadosBasicos.Controls.Add(this.lblFaturamentoGerado);
            this.grpDadosBasicos.Controls.Add(this.lblNumFaturamento);
            this.grpDadosBasicos.Controls.Add(this.txtValorTotal);
            this.grpDadosBasicos.Controls.Add(this.lblValorTotal);
            this.grpDadosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosBasicos.Location = new System.Drawing.Point(20, 50);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(912, 121);
            this.grpDadosBasicos.TabIndex = 33;
            this.grpDadosBasicos.TabStop = false;
            this.grpDadosBasicos.Text = "Dados Básicos";
            // 
            // cboFormasPagamento
            // 
            this.cboFormasPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormasPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormasPagamento.FormattingEnabled = true;
            this.cboFormasPagamento.Location = new System.Drawing.Point(178, 58);
            this.cboFormasPagamento.Name = "cboFormasPagamento";
            this.cboFormasPagamento.Size = new System.Drawing.Size(241, 24);
            this.cboFormasPagamento.TabIndex = 56;
            this.cboFormasPagamento.SelectedIndexChanged += new System.EventHandler(this.cboSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Forma de Pagamento";
            // 
            // txtDtEncerramento
            // 
            this.txtDtEncerramento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDtEncerramento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtEncerramento.Location = new System.Drawing.Point(507, 92);
            this.txtDtEncerramento.Name = "txtDtEncerramento";
            this.txtDtEncerramento.ReadOnly = true;
            this.txtDtEncerramento.Size = new System.Drawing.Size(74, 22);
            this.txtDtEncerramento.TabIndex = 54;
            // 
            // cboVeiculo
            // 
            this.cboVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVeiculo.FormattingEnabled = true;
            this.cboVeiculo.Location = new System.Drawing.Point(665, 22);
            this.cboVeiculo.Name = "cboVeiculo";
            this.cboVeiculo.Size = new System.Drawing.Size(241, 24);
            this.cboVeiculo.TabIndex = 29;
            this.cboVeiculo.SelectedIndexChanged += new System.EventHandler(this.cboSelectedIndexChanged);
            // 
            // lblDtEncerramento
            // 
            this.lblDtEncerramento.AutoSize = true;
            this.lblDtEncerramento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtEncerramento.Location = new System.Drawing.Point(377, 94);
            this.lblDtEncerramento.Name = "lblDtEncerramento";
            this.lblDtEncerramento.Size = new System.Drawing.Size(127, 16);
            this.lblDtEncerramento.TabIndex = 53;
            this.lblDtEncerramento.Text = "Dt. Encerramento";
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdCliente.Location = new System.Drawing.Point(194, 24);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.ReadOnly = true;
            this.txtCdCliente.Size = new System.Drawing.Size(50, 22);
            this.txtCdCliente.TabIndex = 28;
            this.txtCdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // txtDtCriacao
            // 
            this.txtDtCriacao.BackColor = System.Drawing.SystemColors.Control;
            this.txtDtCriacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCriacao.Location = new System.Drawing.Point(295, 92);
            this.txtDtCriacao.Name = "txtDtCriacao";
            this.txtDtCriacao.ReadOnly = true;
            this.txtDtCriacao.Size = new System.Drawing.Size(74, 22);
            this.txtDtCriacao.TabIndex = 52;
            // 
            // lblDtGeracao
            // 
            this.lblDtGeracao.AutoSize = true;
            this.lblDtGeracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtGeracao.Location = new System.Drawing.Point(207, 94);
            this.lblDtGeracao.Name = "lblDtGeracao";
            this.lblDtGeracao.Size = new System.Drawing.Size(85, 16);
            this.lblDtGeracao.TabIndex = 51;
            this.lblDtGeracao.Text = "Dt. Criação";
            // 
            // txtOrcamento
            // 
            this.txtOrcamento.BackColor = System.Drawing.SystemColors.Control;
            this.txtOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrcamento.Location = new System.Drawing.Point(125, 92);
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.ReadOnly = true;
            this.txtOrcamento.Size = new System.Drawing.Size(74, 22);
            this.txtOrcamento.TabIndex = 31;
            this.txtOrcamento.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtOrcamento_MouseDoubleClick);
            // 
            // lblFaturamentoGerado
            // 
            this.lblFaturamentoGerado.AutoSize = true;
            this.lblFaturamentoGerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturamentoGerado.Location = new System.Drawing.Point(18, 94);
            this.lblFaturamentoGerado.Name = "lblFaturamentoGerado";
            this.lblFaturamentoGerado.Size = new System.Drawing.Size(104, 16);
            this.lblFaturamentoGerado.TabIndex = 30;
            this.lblFaturamentoGerado.Text = "Nº Orçamento";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(790, 92);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(116, 26);
            this.txtValorTotal.TabIndex = 31;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(691, 94);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(96, 20);
            this.lblValorTotal.TabIndex = 30;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.AllowUserToOrderColumns = true;
            this.dgvServicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Location = new System.Drawing.Point(6, 54);
            this.dgvServicos.MultiSelect = false;
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.Size = new System.Drawing.Size(898, 156);
            this.dgvServicos.TabIndex = 36;
            this.dgvServicos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dgvServicos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // grpServicos
            // 
            this.grpServicos.Controls.Add(this.dgvServicos);
            this.grpServicos.Controls.Add(this.btnAdicionarServico);
            this.grpServicos.Controls.Add(this.btnExcluirServico);
            this.grpServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServicos.Location = new System.Drawing.Point(20, 173);
            this.grpServicos.Name = "grpServicos";
            this.grpServicos.Size = new System.Drawing.Size(913, 216);
            this.grpServicos.TabIndex = 36;
            this.grpServicos.TabStop = false;
            this.grpServicos.Text = "Serviços";
            // 
            // grpCustosAdicionais
            // 
            this.grpCustosAdicionais.Controls.Add(this.dgvCustosAdicionais);
            this.grpCustosAdicionais.Controls.Add(this.btnAdicionarCustoAdicional);
            this.grpCustosAdicionais.Controls.Add(this.btnExcluirCustoAdicional);
            this.grpCustosAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustosAdicionais.Location = new System.Drawing.Point(20, 387);
            this.grpCustosAdicionais.Name = "grpCustosAdicionais";
            this.grpCustosAdicionais.Size = new System.Drawing.Size(913, 172);
            this.grpCustosAdicionais.TabIndex = 49;
            this.grpCustosAdicionais.TabStop = false;
            this.grpCustosAdicionais.Text = "Custos Adicionais";
            // 
            // dgvCustosAdicionais
            // 
            this.dgvCustosAdicionais.AllowUserToAddRows = false;
            this.dgvCustosAdicionais.AllowUserToDeleteRows = false;
            this.dgvCustosAdicionais.AllowUserToOrderColumns = true;
            this.dgvCustosAdicionais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvCustosAdicionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustosAdicionais.Location = new System.Drawing.Point(6, 54);
            this.dgvCustosAdicionais.MultiSelect = false;
            this.dgvCustosAdicionais.Name = "dgvCustosAdicionais";
            this.dgvCustosAdicionais.Size = new System.Drawing.Size(898, 112);
            this.dgvCustosAdicionais.TabIndex = 36;
            this.dgvCustosAdicionais.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dgvCustosAdicionais.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // btnConsultarValorServico
            // 
            this.btnConsultarValorServico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarValorServico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConsultarValorServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarValorServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarValorServico.Location = new System.Drawing.Point(541, 7);
            this.btnConsultarValorServico.Name = "btnConsultarValorServico";
            this.btnConsultarValorServico.Size = new System.Drawing.Size(203, 32);
            this.btnConsultarValorServico.TabIndex = 55;
            this.btnConsultarValorServico.Text = "Consultar valores dos serviços";
            this.btnConsultarValorServico.UseVisualStyleBackColor = false;
            this.btnConsultarValorServico.Click += new System.EventHandler(this.btnConsultarValorServico_Click);
            // 
            // btnImprimirRecibo
            // 
            this.btnImprimirRecibo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimirRecibo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnImprimirRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRecibo.Image = global::SistemaGuincho.Properties.Resources.Faturamento;
            this.btnImprimirRecibo.Location = new System.Drawing.Point(473, 7);
            this.btnImprimirRecibo.Name = "btnImprimirRecibo";
            this.btnImprimirRecibo.Size = new System.Drawing.Size(66, 36);
            this.btnImprimirRecibo.TabIndex = 56;
            this.btnImprimirRecibo.UseVisualStyleBackColor = false;
            this.btnImprimirRecibo.Click += new System.EventHandler(this.btnImprimirRecibo_Click);
            // 
            // btnFecharReabrir
            // 
            this.btnFecharReabrir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFecharReabrir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnFecharReabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharReabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharReabrir.Image = global::SistemaGuincho.Properties.Resources.cadeado_aberto;
            this.btnFecharReabrir.Location = new System.Drawing.Point(343, 7);
            this.btnFecharReabrir.Name = "btnFecharReabrir";
            this.btnFecharReabrir.Size = new System.Drawing.Size(66, 36);
            this.btnFecharReabrir.TabIndex = 50;
            this.btnFecharReabrir.UseVisualStyleBackColor = false;
            this.btnFecharReabrir.Click += new System.EventHandler(this.btnFecharReabrir_Click);
            // 
            // btnAdicionarCustoAdicional
            // 
            this.btnAdicionarCustoAdicional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarCustoAdicional.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdicionarCustoAdicional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCustoAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCustoAdicional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionarCustoAdicional.Image = global::SistemaGuincho.Properties.Resources.sign_add;
            this.btnAdicionarCustoAdicional.Location = new System.Drawing.Point(6, 19);
            this.btnAdicionarCustoAdicional.Name = "btnAdicionarCustoAdicional";
            this.btnAdicionarCustoAdicional.Size = new System.Drawing.Size(49, 29);
            this.btnAdicionarCustoAdicional.TabIndex = 43;
            this.btnAdicionarCustoAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarCustoAdicional.UseVisualStyleBackColor = false;
            this.btnAdicionarCustoAdicional.Click += new System.EventHandler(this.btnAdicionarServico_Click);
            // 
            // btnExcluirCustoAdicional
            // 
            this.btnExcluirCustoAdicional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirCustoAdicional.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExcluirCustoAdicional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCustoAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCustoAdicional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluirCustoAdicional.Image = global::SistemaGuincho.Properties.Resources.trashcan;
            this.btnExcluirCustoAdicional.Location = new System.Drawing.Point(54, 19);
            this.btnExcluirCustoAdicional.Name = "btnExcluirCustoAdicional";
            this.btnExcluirCustoAdicional.Size = new System.Drawing.Size(49, 29);
            this.btnExcluirCustoAdicional.TabIndex = 45;
            this.btnExcluirCustoAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCustoAdicional.UseVisualStyleBackColor = false;
            this.btnExcluirCustoAdicional.Click += new System.EventHandler(this.btnExcluirServico_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::SistemaGuincho.Properties.Resources.search;
            this.btnPesquisar.Location = new System.Drawing.Point(408, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(66, 36);
            this.btnPesquisar.TabIndex = 42;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarServico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdicionarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarServico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionarServico.Image = global::SistemaGuincho.Properties.Resources.sign_add;
            this.btnAdicionarServico.Location = new System.Drawing.Point(6, 19);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.Size = new System.Drawing.Size(49, 29);
            this.btnAdicionarServico.TabIndex = 43;
            this.btnAdicionarServico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarServico.UseVisualStyleBackColor = false;
            this.btnAdicionarServico.Click += new System.EventHandler(this.btnAdicionarServico_Click);
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirServico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExcluirServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirServico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluirServico.Image = global::SistemaGuincho.Properties.Resources.trashcan;
            this.btnExcluirServico.Location = new System.Drawing.Point(54, 19);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(49, 29);
            this.btnExcluirServico.TabIndex = 45;
            this.btnExcluirServico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirServico.UseVisualStyleBackColor = false;
            this.btnExcluirServico.Click += new System.EventHandler(this.btnExcluirServico_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Image = global::SistemaGuincho.Properties.Resources.sign_right_end;
            this.btnUltimo.Location = new System.Drawing.Point(885, 7);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(46, 38);
            this.btnUltimo.TabIndex = 41;
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Image = global::SistemaGuincho.Properties.Resources.sign_left;
            this.btnAnterior.Location = new System.Drawing.Point(795, 7);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(46, 38);
            this.btnAnterior.TabIndex = 40;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.Control;
            this.btnProximo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Image = global::SistemaGuincho.Properties.Resources.sign_right;
            this.btnProximo.Location = new System.Drawing.Point(840, 7);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(46, 38);
            this.btnProximo.TabIndex = 39;
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimeiro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiro.Image = global::SistemaGuincho.Properties.Resources.sign_left_end;
            this.btnPrimeiro.Location = new System.Drawing.Point(750, 7);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(46, 38);
            this.btnPrimeiro.TabIndex = 38;
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtualizar.Image = global::SistemaGuincho.Properties.Resources.sign_sync;
            this.btnAtualizar.Location = new System.Drawing.Point(278, 7);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(66, 36);
            this.btnAtualizar.TabIndex = 37;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarCliente.BackgroundImage = global::SistemaGuincho.Properties.Resources.search;
            this.btnPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(562, 26);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(32, 21);
            this.btnPesquisarCliente.TabIndex = 51;
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Image = global::SistemaGuincho.Properties.Resources.trashcan;
            this.btnExcluir.Location = new System.Drawing.Point(213, 7);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(66, 36);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = global::SistemaGuincho.Properties.Resources.sign_check;
            this.btnGravar.Location = new System.Drawing.Point(83, 7);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(66, 36);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Image = global::SistemaGuincho.Properties.Resources.sign_ban;
            this.btnCancelar.Location = new System.Drawing.Point(148, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 36);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionar.Image = global::SistemaGuincho.Properties.Resources.sign_add;
            this.btnAdicionar.Location = new System.Drawing.Point(22, 7);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(65, 36);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Faturamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.btnImprimirRecibo);
            this.Controls.Add(this.btnConsultarValorServico);
            this.Controls.Add(this.btnFecharReabrir);
            this.Controls.Add(this.grpCustosAdicionais);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.grpServicos);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.MaximizeBox = false;
            this.Name = "Faturamentos";
            this.Text = "Faturamento";
            this.grpDadosBasicos.ResumeLayout(false);
            this.grpDadosBasicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.grpServicos.ResumeLayout(false);
            this.grpCustosAdicionais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustosAdicionais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumFaturamento;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.GroupBox grpServicos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtCdCliente;
        private System.Windows.Forms.ComboBox cboVeiculo;
        private System.Windows.Forms.Button btnAdicionarServico;
        private System.Windows.Forms.Button btnExcluirServico;
        private System.Windows.Forms.GroupBox grpCustosAdicionais;
        private System.Windows.Forms.DataGridView dgvCustosAdicionais;
        private System.Windows.Forms.Button btnAdicionarCustoAdicional;
        private System.Windows.Forms.Button btnExcluirCustoAdicional;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnFecharReabrir;
        private System.Windows.Forms.Label lblFaturamentoGerado;
        private System.Windows.Forms.TextBox txtOrcamento;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.TextBox txtDtCriacao;
        private System.Windows.Forms.Label lblDtGeracao;
        private System.Windows.Forms.TextBox txtDtEncerramento;
        private System.Windows.Forms.Label lblDtEncerramento;
        private System.Windows.Forms.Button btnConsultarValorServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFormasPagamento;
        private System.Windows.Forms.Button btnImprimirRecibo;
    }
}