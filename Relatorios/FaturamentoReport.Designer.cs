namespace SistemaGuincho.Relatorios {
    partial class FaturamentoReport {
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
            this.dgvFaturamentos = new System.Windows.Forms.DataGridView();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.rdbtFaturamento = new System.Windows.Forms.RadioButton();
            this.rdbtOrcamento = new System.Windows.Forms.RadioButton();
            this.chkDataFechamento = new System.Windows.Forms.CheckBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.chkLstClientes = new System.Windows.Forms.CheckedListBox();
            this.chkApenasFechado = new System.Windows.Forms.CheckBox();
            this.chkCustosAdicionais = new System.Windows.Forms.CheckBox();
            this.chkDataCriacao = new System.Windows.Forms.CheckBox();
            this.chkLstCustosAdicionais = new System.Windows.Forms.CheckedListBox();
            this.chkServicos = new System.Windows.Forms.CheckBox();
            this.chkLstServicos = new System.Windows.Forms.CheckedListBox();
            this.chkFormasPagamento = new System.Windows.Forms.CheckBox();
            this.chkLstFormasPagamento = new System.Windows.Forms.CheckedListBox();
            this.grpDtFechamento = new System.Windows.Forms.GroupBox();
            this.txtDtEncerramentoInicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDtEncerramentoFim = new System.Windows.Forms.TextBox();
            this.grpDtCriacao = new System.Windows.Forms.GroupBox();
            this.txtDtCriacaoInicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDtCriacaoFim = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturamentos)).BeginInit();
            this.grpReport.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            this.grpDtFechamento.SuspendLayout();
            this.grpDtCriacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFaturamentos
            // 
            this.dgvFaturamentos.AllowUserToAddRows = false;
            this.dgvFaturamentos.AllowUserToDeleteRows = false;
            this.dgvFaturamentos.AllowUserToOrderColumns = true;
            this.dgvFaturamentos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFaturamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturamentos.Location = new System.Drawing.Point(6, 22);
            this.dgvFaturamentos.MultiSelect = false;
            this.dgvFaturamentos.Name = "dgvFaturamentos";
            this.dgvFaturamentos.Size = new System.Drawing.Size(1032, 436);
            this.dgvFaturamentos.TabIndex = 5;
            this.dgvFaturamentos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFaturamentos_CellMouseDoubleClick);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.dgvFaturamentos);
            this.grpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReport.Location = new System.Drawing.Point(11, 184);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(1044, 468);
            this.grpReport.TabIndex = 6;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Relatório";
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.rdbtFaturamento);
            this.grpFiltros.Controls.Add(this.rdbtOrcamento);
            this.grpFiltros.Controls.Add(this.chkDataFechamento);
            this.grpFiltros.Controls.Add(this.chkCliente);
            this.grpFiltros.Controls.Add(this.chkLstClientes);
            this.grpFiltros.Controls.Add(this.chkApenasFechado);
            this.grpFiltros.Controls.Add(this.chkCustosAdicionais);
            this.grpFiltros.Controls.Add(this.chkDataCriacao);
            this.grpFiltros.Controls.Add(this.chkLstCustosAdicionais);
            this.grpFiltros.Controls.Add(this.chkServicos);
            this.grpFiltros.Controls.Add(this.chkLstServicos);
            this.grpFiltros.Controls.Add(this.chkFormasPagamento);
            this.grpFiltros.Controls.Add(this.chkLstFormasPagamento);
            this.grpFiltros.Controls.Add(this.grpDtFechamento);
            this.grpFiltros.Controls.Add(this.grpDtCriacao);
            this.grpFiltros.Controls.Add(this.btnPesquisar);
            this.grpFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.Location = new System.Drawing.Point(11, 8);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(1044, 170);
            this.grpFiltros.TabIndex = 7;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // rdbtFaturamento
            // 
            this.rdbtFaturamento.AutoSize = true;
            this.rdbtFaturamento.Location = new System.Drawing.Point(170, 0);
            this.rdbtFaturamento.Name = "rdbtFaturamento";
            this.rdbtFaturamento.Size = new System.Drawing.Size(106, 21);
            this.rdbtFaturamento.TabIndex = 76;
            this.rdbtFaturamento.TabStop = true;
            this.rdbtFaturamento.Text = "Faturamento";
            this.rdbtFaturamento.UseVisualStyleBackColor = true;
            this.rdbtFaturamento.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChange);
            // 
            // rdbtOrcamento
            // 
            this.rdbtOrcamento.AutoSize = true;
            this.rdbtOrcamento.Checked = true;
            this.rdbtOrcamento.Location = new System.Drawing.Point(68, 0);
            this.rdbtOrcamento.Name = "rdbtOrcamento";
            this.rdbtOrcamento.Size = new System.Drawing.Size(96, 21);
            this.rdbtOrcamento.TabIndex = 75;
            this.rdbtOrcamento.TabStop = true;
            this.rdbtOrcamento.Text = "Orçamento";
            this.rdbtOrcamento.UseVisualStyleBackColor = true;
            this.rdbtOrcamento.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChange);
            // 
            // chkDataFechamento
            // 
            this.chkDataFechamento.AutoSize = true;
            this.chkDataFechamento.Location = new System.Drawing.Point(732, 82);
            this.chkDataFechamento.Name = "chkDataFechamento";
            this.chkDataFechamento.Size = new System.Drawing.Size(155, 21);
            this.chkDataFechamento.TabIndex = 74;
            this.chkDataFechamento.Text = "Data de fechamento";
            this.chkDataFechamento.UseVisualStyleBackColor = true;
            this.chkDataFechamento.CheckedChanged += new System.EventHandler(this.checkbBoxCheckedChange);
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Location = new System.Drawing.Point(15, 33);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(77, 21);
            this.chkCliente.TabIndex = 72;
            this.chkCliente.Text = "Clientes";
            this.chkCliente.UseVisualStyleBackColor = true;
            this.chkCliente.CheckedChanged += new System.EventHandler(this.checkbBoxCheckedChange);
            // 
            // chkLstClientes
            // 
            this.chkLstClientes.Enabled = false;
            this.chkLstClientes.FormattingEnabled = true;
            this.chkLstClientes.Location = new System.Drawing.Point(12, 55);
            this.chkLstClientes.Name = "chkLstClientes";
            this.chkLstClientes.Size = new System.Drawing.Size(173, 112);
            this.chkLstClientes.TabIndex = 71;
            // 
            // chkApenasFechado
            // 
            this.chkApenasFechado.AutoSize = true;
            this.chkApenasFechado.Location = new System.Drawing.Point(732, 136);
            this.chkApenasFechado.Name = "chkApenasFechado";
            this.chkApenasFechado.Size = new System.Drawing.Size(215, 21);
            this.chkApenasFechado.TabIndex = 70;
            this.chkApenasFechado.Text = "Apenas orçamentos fechados";
            this.chkApenasFechado.UseVisualStyleBackColor = true;
            // 
            // chkCustosAdicionais
            // 
            this.chkCustosAdicionais.AutoSize = true;
            this.chkCustosAdicionais.Location = new System.Drawing.Point(373, 33);
            this.chkCustosAdicionais.Name = "chkCustosAdicionais";
            this.chkCustosAdicionais.Size = new System.Drawing.Size(137, 21);
            this.chkCustosAdicionais.TabIndex = 69;
            this.chkCustosAdicionais.Text = "Custos adicionais";
            this.chkCustosAdicionais.UseVisualStyleBackColor = true;
            this.chkCustosAdicionais.CheckedChanged += new System.EventHandler(this.checkbBoxCheckedChange);
            // 
            // chkDataCriacao
            // 
            this.chkDataCriacao.AutoSize = true;
            this.chkDataCriacao.Location = new System.Drawing.Point(732, 22);
            this.chkDataCriacao.Name = "chkDataCriacao";
            this.chkDataCriacao.Size = new System.Drawing.Size(127, 21);
            this.chkDataCriacao.TabIndex = 73;
            this.chkDataCriacao.Text = "Data de criação";
            this.chkDataCriacao.UseVisualStyleBackColor = true;
            this.chkDataCriacao.CheckedChanged += new System.EventHandler(this.checkbBoxCheckedChange);
            // 
            // chkLstCustosAdicionais
            // 
            this.chkLstCustosAdicionais.Enabled = false;
            this.chkLstCustosAdicionais.FormattingEnabled = true;
            this.chkLstCustosAdicionais.Location = new System.Drawing.Point(370, 55);
            this.chkLstCustosAdicionais.Name = "chkLstCustosAdicionais";
            this.chkLstCustosAdicionais.Size = new System.Drawing.Size(173, 112);
            this.chkLstCustosAdicionais.TabIndex = 68;
            // 
            // chkServicos
            // 
            this.chkServicos.AutoSize = true;
            this.chkServicos.Location = new System.Drawing.Point(194, 33);
            this.chkServicos.Name = "chkServicos";
            this.chkServicos.Size = new System.Drawing.Size(81, 21);
            this.chkServicos.TabIndex = 67;
            this.chkServicos.Text = "Serviços";
            this.chkServicos.UseVisualStyleBackColor = true;
            this.chkServicos.CheckedChanged += new System.EventHandler(this.checkbBoxCheckedChange);
            // 
            // chkLstServicos
            // 
            this.chkLstServicos.Enabled = false;
            this.chkLstServicos.FormattingEnabled = true;
            this.chkLstServicos.Location = new System.Drawing.Point(191, 55);
            this.chkLstServicos.Name = "chkLstServicos";
            this.chkLstServicos.Size = new System.Drawing.Size(173, 112);
            this.chkLstServicos.TabIndex = 66;
            // 
            // chkFormasPagamento
            // 
            this.chkFormasPagamento.AutoSize = true;
            this.chkFormasPagamento.Enabled = false;
            this.chkFormasPagamento.Location = new System.Drawing.Point(552, 33);
            this.chkFormasPagamento.Name = "chkFormasPagamento";
            this.chkFormasPagamento.Size = new System.Drawing.Size(170, 21);
            this.chkFormasPagamento.TabIndex = 65;
            this.chkFormasPagamento.Text = "Formas de Pagamento";
            this.chkFormasPagamento.UseVisualStyleBackColor = true;
            this.chkFormasPagamento.CheckedChanged += new System.EventHandler(this.checkbBoxCheckedChange);
            // 
            // chkLstFormasPagamento
            // 
            this.chkLstFormasPagamento.Enabled = false;
            this.chkLstFormasPagamento.FormattingEnabled = true;
            this.chkLstFormasPagamento.Location = new System.Drawing.Point(549, 55);
            this.chkLstFormasPagamento.Name = "chkLstFormasPagamento";
            this.chkLstFormasPagamento.Size = new System.Drawing.Size(173, 112);
            this.chkLstFormasPagamento.TabIndex = 64;
            // 
            // grpDtFechamento
            // 
            this.grpDtFechamento.Controls.Add(this.txtDtEncerramentoInicio);
            this.grpDtFechamento.Controls.Add(this.label3);
            this.grpDtFechamento.Controls.Add(this.label4);
            this.grpDtFechamento.Controls.Add(this.txtDtEncerramentoFim);
            this.grpDtFechamento.Enabled = false;
            this.grpDtFechamento.Location = new System.Drawing.Point(728, 82);
            this.grpDtFechamento.Name = "grpDtFechamento";
            this.grpDtFechamento.Size = new System.Drawing.Size(239, 52);
            this.grpDtFechamento.TabIndex = 61;
            this.grpDtFechamento.TabStop = false;
            // 
            // txtDtEncerramentoInicio
            // 
            this.txtDtEncerramentoInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtDtEncerramentoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtEncerramentoInicio.Location = new System.Drawing.Point(44, 22);
            this.txtDtEncerramentoInicio.Name = "txtDtEncerramentoInicio";
            this.txtDtEncerramentoInicio.Size = new System.Drawing.Size(74, 22);
            this.txtDtEncerramentoInicio.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "De:";
            // 
            // txtDtEncerramentoFim
            // 
            this.txtDtEncerramentoFim.BackColor = System.Drawing.SystemColors.Control;
            this.txtDtEncerramentoFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtEncerramentoFim.Location = new System.Drawing.Point(158, 22);
            this.txtDtEncerramentoFim.Name = "txtDtEncerramentoFim";
            this.txtDtEncerramentoFim.Size = new System.Drawing.Size(74, 22);
            this.txtDtEncerramentoFim.TabIndex = 58;
            // 
            // grpDtCriacao
            // 
            this.grpDtCriacao.Controls.Add(this.txtDtCriacaoInicio);
            this.grpDtCriacao.Controls.Add(this.label2);
            this.grpDtCriacao.Controls.Add(this.label1);
            this.grpDtCriacao.Controls.Add(this.txtDtCriacaoFim);
            this.grpDtCriacao.Enabled = false;
            this.grpDtCriacao.Location = new System.Drawing.Point(728, 24);
            this.grpDtCriacao.Name = "grpDtCriacao";
            this.grpDtCriacao.Size = new System.Drawing.Size(239, 52);
            this.grpDtCriacao.TabIndex = 60;
            this.grpDtCriacao.TabStop = false;
            // 
            // txtDtCriacaoInicio
            // 
            this.txtDtCriacaoInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtDtCriacaoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCriacaoInicio.Location = new System.Drawing.Point(44, 22);
            this.txtDtCriacaoInicio.Name = "txtDtCriacaoInicio";
            this.txtDtCriacaoInicio.Size = new System.Drawing.Size(74, 22);
            this.txtDtCriacaoInicio.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "De:";
            // 
            // txtDtCriacaoFim
            // 
            this.txtDtCriacaoFim.BackColor = System.Drawing.SystemColors.Control;
            this.txtDtCriacaoFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCriacaoFim.Location = new System.Drawing.Point(158, 22);
            this.txtDtCriacaoFim.Name = "txtDtCriacaoFim";
            this.txtDtCriacaoFim.Size = new System.Drawing.Size(74, 22);
            this.txtDtCriacaoFim.TabIndex = 58;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(958, 136);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 31);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FaturamentoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1064, 656);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.grpReport);
            this.MaximizeBox = false;
            this.Name = "FaturamentoReport";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowInTaskbar = false;
            this.Text = "Relatório de Orçamentos";
            this.Load += new System.EventHandler(this.FaturamentoReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturamentos)).EndInit();
            this.grpReport.ResumeLayout(false);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpDtFechamento.ResumeLayout(false);
            this.grpDtFechamento.PerformLayout();
            this.grpDtCriacao.ResumeLayout(false);
            this.grpDtCriacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFaturamentos;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDtCriacaoInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDtCriacaoFim;
        private System.Windows.Forms.GroupBox grpDtCriacao;
        private System.Windows.Forms.GroupBox grpDtFechamento;
        private System.Windows.Forms.TextBox txtDtEncerramentoInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDtEncerramentoFim;
        private System.Windows.Forms.CheckedListBox chkLstFormasPagamento;
        private System.Windows.Forms.CheckBox chkFormasPagamento;
        private System.Windows.Forms.CheckBox chkCustosAdicionais;
        private System.Windows.Forms.CheckedListBox chkLstCustosAdicionais;
        private System.Windows.Forms.CheckBox chkServicos;
        private System.Windows.Forms.CheckedListBox chkLstServicos;
        private System.Windows.Forms.CheckBox chkApenasFechado;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.CheckedListBox chkLstClientes;
        private System.Windows.Forms.CheckBox chkDataCriacao;
        private System.Windows.Forms.CheckBox chkDataFechamento;
        private System.Windows.Forms.RadioButton rdbtOrcamento;
        private System.Windows.Forms.RadioButton rdbtFaturamento;
    }
}