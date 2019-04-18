namespace SistemaGuincho.Views {
    partial class Servicos {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_CdCliente = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbl_NomeCliente = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbl_RGCliente = new System.Windows.Forms.Label();
            this.lbl_NascCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gpb_ddBasicCliente = new System.Windows.Forms.GroupBox();
            this.cboUnidade = new System.Windows.Forms.ComboBox();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboCamposBusca = new System.Windows.Forms.ComboBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.gpb_ddBasicCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CdCliente
            // 
            this.lbl_CdCliente.AutoSize = true;
            this.lbl_CdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CdCliente.Location = new System.Drawing.Point(19, 31);
            this.lbl_CdCliente.Name = "lbl_CdCliente";
            this.lbl_CdCliente.Size = new System.Drawing.Size(46, 13);
            this.lbl_CdCliente.TabIndex = 0;
            this.lbl_CdCliente.Text = "Código";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(71, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(91, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(245, 28);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(590, 20);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_NomeCliente
            // 
            this.lbl_NomeCliente.AutoSize = true;
            this.lbl_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeCliente.Location = new System.Drawing.Point(174, 31);
            this.lbl_NomeCliente.Name = "lbl_NomeCliente";
            this.lbl_NomeCliente.Size = new System.Drawing.Size(64, 13);
            this.lbl_NomeCliente.TabIndex = 2;
            this.lbl_NomeCliente.Text = "Descrição";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(61, 68);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(101, 20);
            this.txtValor.TabIndex = 7;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_RGCliente
            // 
            this.lbl_RGCliente.AutoSize = true;
            this.lbl_RGCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RGCliente.Location = new System.Drawing.Point(18, 71);
            this.lbl_RGCliente.Name = "lbl_RGCliente";
            this.lbl_RGCliente.Size = new System.Drawing.Size(36, 13);
            this.lbl_RGCliente.TabIndex = 6;
            this.lbl_RGCliente.Text = "Valor";
            // 
            // lbl_NascCliente
            // 
            this.lbl_NascCliente.AutoSize = true;
            this.lbl_NascCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NascCliente.Location = new System.Drawing.Point(190, 71);
            this.lbl_NascCliente.Name = "lbl_NascCliente";
            this.lbl_NascCliente.Size = new System.Drawing.Size(54, 13);
            this.lbl_NascCliente.TabIndex = 8;
            this.lbl_NascCliente.Text = "Unidade";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::SistemaGuincho.Properties.Resources.sign_ban;
            this.btnCancelar.Location = new System.Drawing.Point(212, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 36);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::SistemaGuincho.Properties.Resources.trashcan;
            this.btnExcluir.Location = new System.Drawing.Point(147, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(66, 36);
            this.btnExcluir.TabIndex = 14;
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
            this.btnGravar.Location = new System.Drawing.Point(81, 13);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(67, 36);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // gpb_ddBasicCliente
            // 
            this.gpb_ddBasicCliente.Controls.Add(this.cboUnidade);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_NascCliente);
            this.gpb_ddBasicCliente.Controls.Add(this.txtValor);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_RGCliente);
            this.gpb_ddBasicCliente.Controls.Add(this.txtDescricao);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_NomeCliente);
            this.gpb_ddBasicCliente.Controls.Add(this.txtID);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_CdCliente);
            this.gpb_ddBasicCliente.Location = new System.Drawing.Point(20, 58);
            this.gpb_ddBasicCliente.Name = "gpb_ddBasicCliente";
            this.gpb_ddBasicCliente.Size = new System.Drawing.Size(841, 101);
            this.gpb_ddBasicCliente.TabIndex = 33;
            this.gpb_ddBasicCliente.TabStop = false;
            this.gpb_ddBasicCliente.Text = "Serviço";
            // 
            // cboUnidade
            // 
            this.cboUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidade.FormattingEnabled = true;
            this.cboUnidade.Location = new System.Drawing.Point(247, 68);
            this.cboUnidade.Name = "cboUnidade";
            this.cboUnidade.Size = new System.Drawing.Size(140, 21);
            this.cboUnidade.TabIndex = 29;
            this.cboUnidade.SelectedIndexChanged += new System.EventHandler(this.fields_keyDown);
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.AllowUserToOrderColumns = true;
            this.dgvServicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServicos.Location = new System.Drawing.Point(6, 21);
            this.dgvServicos.MultiSelect = false;
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.Size = new System.Drawing.Size(830, 242);
            this.dgvServicos.TabIndex = 36;
            this.dgvServicos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvServicos_CellMouseClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::SistemaGuincho.Properties.Resources.sign_sync;
            this.btnAtualizar.Location = new System.Drawing.Point(277, 13);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(65, 36);
            this.btnAtualizar.TabIndex = 37;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Image = global::SistemaGuincho.Properties.Resources.sign_right_end;
            this.btnUltimo.Location = new System.Drawing.Point(814, 12);
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
            this.btnAnterior.Location = new System.Drawing.Point(724, 12);
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
            this.btnProximo.Location = new System.Drawing.Point(769, 12);
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
            this.btnPrimeiro.Location = new System.Drawing.Point(679, 12);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(46, 38);
            this.btnPrimeiro.TabIndex = 38;
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.dgvServicos);
            this.groupBox2.Location = new System.Drawing.Point(21, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 312);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de serviços";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cboCamposBusca, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBuscarPor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBusca, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBusca, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 266);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 40);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // cboCamposBusca
            // 
            this.cboCamposBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCamposBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamposBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamposBusca.FormattingEnabled = true;
            this.cboCamposBusca.Location = new System.Drawing.Point(625, 17);
            this.cboCamposBusca.Name = "cboCamposBusca";
            this.cboCamposBusca.Size = new System.Drawing.Size(202, 23);
            this.cboCamposBusca.TabIndex = 10;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(625, 0);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(66, 14);
            this.lblBuscarPor.TabIndex = 4;
            this.lblBuscarPor.Text = "Buscar por";
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(3, 0);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(45, 14);
            this.lblBusca.TabIndex = 0;
            this.lblBusca.Text = "Buscar";
            // 
            // txtBusca
            // 
            this.txtBusca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(3, 17);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(616, 21);
            this.txtBusca.TabIndex = 2;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::SistemaGuincho.Properties.Resources.sign_add;
            this.button5.Location = new System.Drawing.Point(20, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 36);
            this.button5.TabIndex = 42;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(885, 491);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.gpb_ddBasicCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.Name = "Servicos";
            this.Text = "Serviços";
            this.Load += new System.EventHandler(this.Servicos_Load);
            this.gpb_ddBasicCliente.ResumeLayout(false);
            this.gpb_ddBasicCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_CdCliente;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbl_NomeCliente;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lbl_RGCliente;
        private System.Windows.Forms.Label lbl_NascCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox gpb_ddBasicCliente;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboUnidade;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboCamposBusca;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button button5;
    }
}