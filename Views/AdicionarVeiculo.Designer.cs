namespace SistemaGuincho.Views {
    partial class AdicionarVeiculo {
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
            this.lbl_CdCliente = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl_NomeCliente = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lbl_CPFCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lbl_enderCliente = new System.Windows.Forms.Label();
            this.gpb_ddBasicCliente = new System.Windows.Forms.GroupBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTpVeiculo = new System.Windows.Forms.ComboBox();
            this.gpb_LocalCliente = new System.Windows.Forms.GroupBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.gpb_ddBasicCliente.SuspendLayout();
            this.gpb_LocalCliente.SuspendLayout();
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
            this.txtID.Size = new System.Drawing.Size(58, 20);
            this.txtID.TabIndex = 1;
            // 
            // lbl_NomeCliente
            // 
            this.lbl_NomeCliente.AutoSize = true;
            this.lbl_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeCliente.Location = new System.Drawing.Point(135, 30);
            this.lbl_NomeCliente.Name = "lbl_NomeCliente";
            this.lbl_NomeCliente.Size = new System.Drawing.Size(51, 13);
            this.lbl_NomeCliente.TabIndex = 2;
            this.lbl_NomeCliente.Text = "Veículo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(342, 27);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(215, 20);
            this.txtModelo.TabIndex = 5;
            this.txtModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_CPFCliente
            // 
            this.lbl_CPFCliente.AutoSize = true;
            this.lbl_CPFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPFCliente.Location = new System.Drawing.Point(288, 31);
            this.lbl_CPFCliente.Name = "lbl_CPFCliente";
            this.lbl_CPFCliente.Size = new System.Drawing.Size(48, 13);
            this.lbl_CPFCliente.TabIndex = 4;
            this.lbl_CPFCliente.Text = "Modelo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(209, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 27);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(303, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 27);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(115, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(88, 27);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(21, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 27);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Novo";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(57, 24);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(101, 20);
            this.txtPlaca.TabIndex = 19;
            this.txtPlaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_enderCliente
            // 
            this.lbl_enderCliente.AutoSize = true;
            this.lbl_enderCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enderCliente.Location = new System.Drawing.Point(12, 27);
            this.lbl_enderCliente.Name = "lbl_enderCliente";
            this.lbl_enderCliente.Size = new System.Drawing.Size(39, 13);
            this.lbl_enderCliente.TabIndex = 18;
            this.lbl_enderCliente.Text = "Placa";
            // 
            // gpb_ddBasicCliente
            // 
            this.gpb_ddBasicCliente.Controls.Add(this.txtAno);
            this.gpb_ddBasicCliente.Controls.Add(this.label1);
            this.gpb_ddBasicCliente.Controls.Add(this.txtCor);
            this.gpb_ddBasicCliente.Controls.Add(this.label5);
            this.gpb_ddBasicCliente.Controls.Add(this.cboTpVeiculo);
            this.gpb_ddBasicCliente.Controls.Add(this.txtModelo);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_CPFCliente);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_NomeCliente);
            this.gpb_ddBasicCliente.Controls.Add(this.txtID);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_CdCliente);
            this.gpb_ddBasicCliente.Location = new System.Drawing.Point(20, 48);
            this.gpb_ddBasicCliente.Name = "gpb_ddBasicCliente";
            this.gpb_ddBasicCliente.Size = new System.Drawing.Size(841, 61);
            this.gpb_ddBasicCliente.TabIndex = 33;
            this.gpb_ddBasicCliente.TabStop = false;
            this.gpb_ddBasicCliente.Text = "Veículo";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(598, 27);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(66, 20);
            this.txtAno.TabIndex = 32;
            this.txtAno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ano";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(706, 27);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(119, 20);
            this.txtCor.TabIndex = 30;
            this.txtCor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(674, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cor";
            // 
            // cboTpVeiculo
            // 
            this.cboTpVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTpVeiculo.FormattingEnabled = true;
            this.cboTpVeiculo.Location = new System.Drawing.Point(192, 26);
            this.cboTpVeiculo.Name = "cboTpVeiculo";
            this.cboTpVeiculo.Size = new System.Drawing.Size(92, 21);
            this.cboTpVeiculo.TabIndex = 28;
            this.cboTpVeiculo.SelectedIndexChanged += new System.EventHandler(this.fields_keyDown);
            // 
            // gpb_LocalCliente
            // 
            this.gpb_LocalCliente.Controls.Add(this.txtUF);
            this.gpb_LocalCliente.Controls.Add(this.label4);
            this.gpb_LocalCliente.Controls.Add(this.txtCidade);
            this.gpb_LocalCliente.Controls.Add(this.label2);
            this.gpb_LocalCliente.Controls.Add(this.txtPlaca);
            this.gpb_LocalCliente.Controls.Add(this.lbl_enderCliente);
            this.gpb_LocalCliente.Location = new System.Drawing.Point(21, 117);
            this.gpb_LocalCliente.Name = "gpb_LocalCliente";
            this.gpb_LocalCliente.Size = new System.Drawing.Size(841, 54);
            this.gpb_LocalCliente.TabIndex = 34;
            this.gpb_LocalCliente.TabStop = false;
            this.gpb_LocalCliente.Text = "Placa";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(350, 24);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(38, 20);
            this.txtUF.TabIndex = 34;
            this.txtUF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(216, 24);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(99, 20);
            this.txtCidade.TabIndex = 32;
            this.txtCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cidade";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(397, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(88, 27);
            this.btnAtualizar.TabIndex = 37;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(818, 12);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(43, 27);
            this.btnUltimo.TabIndex = 41;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(720, 12);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(43, 27);
            this.btnAnterior.TabIndex = 40;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.Control;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(769, 12);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(43, 27);
            this.btnProximo.TabIndex = 39;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiro.Location = new System.Drawing.Point(671, 12);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(43, 27);
            this.btnPrimeiro.TabIndex = 38;
            this.btnPrimeiro.Text = "<<";
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // AdicionarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 179);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.gpb_LocalCliente);
            this.Controls.Add(this.gpb_ddBasicCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAdicionar);
            this.MaximizeBox = false;
            this.Name = "AdicionarVeiculo";
            this.Text = " - Veículos";
            this.gpb_ddBasicCliente.ResumeLayout(false);
            this.gpb_ddBasicCliente.PerformLayout();
            this.gpb_LocalCliente.ResumeLayout(false);
            this.gpb_LocalCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_CdCliente;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl_NomeCliente;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lbl_CPFCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lbl_enderCliente;
        private System.Windows.Forms.GroupBox gpb_ddBasicCliente;
        private System.Windows.Forms.GroupBox gpb_LocalCliente;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTpVeiculo;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label1;
    }
}