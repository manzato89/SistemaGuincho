namespace SistemaGuincho.Views {
    partial class Cliente {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_CdCliente = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl_NomeCliente = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbl_CPFCliente = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lbl_RGCliente = new System.Windows.Forms.Label();
            this.lbl_NascCliente = new System.Windows.Forms.Label();
            this.txtFone1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAddVeiculo = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbl_BairroCliente = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbl_enderCliente = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lbl_CepCliente = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.txtFone2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_ddBasicCliente = new System.Windows.Forms.GroupBox();
            this.txtDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.gpb_LocalCliente = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gpb_ddBasicCliente.SuspendLayout();
            this.gpb_LocalCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(236, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_NomeCliente
            // 
            this.lbl_NomeCliente.AutoSize = true;
            this.lbl_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeCliente.Location = new System.Drawing.Point(191, 31);
            this.lbl_NomeCliente.Name = "lbl_NomeCliente";
            this.lbl_NomeCliente.Size = new System.Drawing.Size(39, 13);
            this.lbl_NomeCliente.TabIndex = 2;
            this.lbl_NomeCliente.Text = "Nome";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(601, 28);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(215, 20);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_CPFCliente
            // 
            this.lbl_CPFCliente.AutoSize = true;
            this.lbl_CPFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPFCliente.Location = new System.Drawing.Point(565, 31);
            this.lbl_CPFCliente.Name = "lbl_CPFCliente";
            this.lbl_CPFCliente.Size = new System.Drawing.Size(30, 13);
            this.lbl_CPFCliente.TabIndex = 4;
            this.lbl_CPFCliente.Text = "CPF";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(49, 68);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(213, 20);
            this.txtRG.TabIndex = 7;
            this.txtRG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_RGCliente
            // 
            this.lbl_RGCliente.AutoSize = true;
            this.lbl_RGCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RGCliente.Location = new System.Drawing.Point(18, 71);
            this.lbl_RGCliente.Name = "lbl_RGCliente";
            this.lbl_RGCliente.Size = new System.Drawing.Size(25, 13);
            this.lbl_RGCliente.TabIndex = 6;
            this.lbl_RGCliente.Text = "RG";
            // 
            // lbl_NascCliente
            // 
            this.lbl_NascCliente.AutoSize = true;
            this.lbl_NascCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NascCliente.Location = new System.Drawing.Point(282, 71);
            this.lbl_NascCliente.Name = "lbl_NascCliente";
            this.lbl_NascCliente.Size = new System.Drawing.Size(94, 13);
            this.lbl_NascCliente.TabIndex = 8;
            this.lbl_NascCliente.Text = "Dt. Nascimento";
            // 
            // txtFone1
            // 
            this.txtFone1.Location = new System.Drawing.Point(340, 26);
            this.txtFone1.Name = "txtFone1";
            this.txtFone1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFone1.Size = new System.Drawing.Size(199, 20);
            this.txtFone1.TabIndex = 11;
            this.txtFone1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone";
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
            // btnAddVeiculo
            // 
            this.btnAddVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVeiculo.Image = global::SistemaGuincho.Properties.Resources.keyring;
            this.btnAddVeiculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddVeiculo.Location = new System.Drawing.Point(6, 15);
            this.btnAddVeiculo.Name = "btnAddVeiculo";
            this.btnAddVeiculo.Size = new System.Drawing.Size(114, 111);
            this.btnAddVeiculo.TabIndex = 17;
            this.btnAddVeiculo.Text = "Adicionar Veículo";
            this.btnAddVeiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddVeiculo.UseVisualStyleBackColor = false;
            this.btnAddVeiculo.Click += new System.EventHandler(this.btnAddVeiculo_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(59, 60);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBairro.Size = new System.Drawing.Size(224, 20);
            this.txtBairro.TabIndex = 21;
            this.txtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_BairroCliente
            // 
            this.lbl_BairroCliente.AutoSize = true;
            this.lbl_BairroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BairroCliente.Location = new System.Drawing.Point(13, 63);
            this.lbl_BairroCliente.Name = "lbl_BairroCliente";
            this.lbl_BairroCliente.Size = new System.Drawing.Size(40, 13);
            this.lbl_BairroCliente.TabIndex = 20;
            this.lbl_BairroCliente.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(79, 24);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(254, 20);
            this.txtEndereco.TabIndex = 19;
            this.txtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_enderCliente
            // 
            this.lbl_enderCliente.AutoSize = true;
            this.lbl_enderCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enderCliente.Location = new System.Drawing.Point(12, 27);
            this.lbl_enderCliente.Name = "lbl_enderCliente";
            this.lbl_enderCliente.Size = new System.Drawing.Size(61, 13);
            this.lbl_enderCliente.TabIndex = 18;
            this.lbl_enderCliente.Text = "Endereço";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(731, 63);
            this.txtUF.Name = "txtUF";
            this.txtUF.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUF.Size = new System.Drawing.Size(84, 20);
            this.txtUF.TabIndex = 25;
            this.txtUF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "UF";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(731, 24);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(84, 20);
            this.txtCEP.TabIndex = 23;
            this.txtCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_CepCliente
            // 
            this.lbl_CepCliente.AutoSize = true;
            this.lbl_CepCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CepCliente.Location = new System.Drawing.Point(694, 27);
            this.lbl_CepCliente.Name = "lbl_CepCliente";
            this.lbl_CepCliente.Size = new System.Drawing.Size(31, 13);
            this.lbl_CepCliente.TabIndex = 22;
            this.lbl_CepCliente.Text = "CEP";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 26);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(18, 29);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(37, 13);
            this.lbl_email.TabIndex = 27;
            this.lbl_email.Text = "Email";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(361, 63);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCidade.Size = new System.Drawing.Size(313, 20);
            this.txtCidade.TabIndex = 30;
            this.txtCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cidade.Location = new System.Drawing.Point(309, 66);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(46, 13);
            this.lbl_Cidade.TabIndex = 29;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // txtFone2
            // 
            this.txtFone2.Location = new System.Drawing.Point(615, 26);
            this.txtFone2.Name = "txtFone2";
            this.txtFone2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFone2.Size = new System.Drawing.Size(197, 20);
            this.txtFone2.TabIndex = 32;
            this.txtFone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Celular";
            // 
            // gpb_ddBasicCliente
            // 
            this.gpb_ddBasicCliente.Controls.Add(this.txtDtNascimento);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_NascCliente);
            this.gpb_ddBasicCliente.Controls.Add(this.txtRG);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_RGCliente);
            this.gpb_ddBasicCliente.Controls.Add(this.txtCPF);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_CPFCliente);
            this.gpb_ddBasicCliente.Controls.Add(this.txtNome);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_NomeCliente);
            this.gpb_ddBasicCliente.Controls.Add(this.txtID);
            this.gpb_ddBasicCliente.Controls.Add(this.lbl_CdCliente);
            this.gpb_ddBasicCliente.Location = new System.Drawing.Point(20, 48);
            this.gpb_ddBasicCliente.Name = "gpb_ddBasicCliente";
            this.gpb_ddBasicCliente.Size = new System.Drawing.Size(841, 101);
            this.gpb_ddBasicCliente.TabIndex = 33;
            this.gpb_ddBasicCliente.TabStop = false;
            this.gpb_ddBasicCliente.Text = "Dados Básicos";
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtNascimento.Location = new System.Drawing.Point(382, 68);
            this.txtDtNascimento.Mask = "00/00/0000";
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(71, 21);
            this.txtDtNascimento.TabIndex = 27;
            this.txtDtNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // gpb_LocalCliente
            // 
            this.gpb_LocalCliente.Controls.Add(this.txtComplemento);
            this.gpb_LocalCliente.Controls.Add(this.label4);
            this.gpb_LocalCliente.Controls.Add(this.txtNumero);
            this.gpb_LocalCliente.Controls.Add(this.label2);
            this.gpb_LocalCliente.Controls.Add(this.txtCidade);
            this.gpb_LocalCliente.Controls.Add(this.lbl_Cidade);
            this.gpb_LocalCliente.Controls.Add(this.txtUF);
            this.gpb_LocalCliente.Controls.Add(this.label3);
            this.gpb_LocalCliente.Controls.Add(this.txtCEP);
            this.gpb_LocalCliente.Controls.Add(this.lbl_CepCliente);
            this.gpb_LocalCliente.Controls.Add(this.txtBairro);
            this.gpb_LocalCliente.Controls.Add(this.lbl_BairroCliente);
            this.gpb_LocalCliente.Controls.Add(this.txtEndereco);
            this.gpb_LocalCliente.Controls.Add(this.lbl_enderCliente);
            this.gpb_LocalCliente.Location = new System.Drawing.Point(21, 157);
            this.gpb_LocalCliente.Name = "gpb_LocalCliente";
            this.gpb_LocalCliente.Size = new System.Drawing.Size(841, 102);
            this.gpb_LocalCliente.TabIndex = 34;
            this.gpb_LocalCliente.TabStop = false;
            this.gpb_LocalCliente.Text = "Localização";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(540, 24);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(148, 20);
            this.txtComplemento.TabIndex = 34;
            this.txtComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(390, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(56, 20);
            this.txtNumero.TabIndex = 32;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fields_keyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Número";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFone2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.txtFone1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(20, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 63);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.AllowUserToOrderColumns = true;
            this.dgvVeiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeiculos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVeiculos.Location = new System.Drawing.Point(126, 15);
            this.dgvVeiculos.MultiSelect = false;
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.Size = new System.Drawing.Size(710, 111);
            this.dgvVeiculos.TabIndex = 36;
            this.dgvVeiculos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVeiculos_CellMouseDoubleClick);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddVeiculo);
            this.groupBox2.Controls.Add(this.dgvVeiculos);
            this.groupBox2.Location = new System.Drawing.Point(21, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 141);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veículos";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(491, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 27);
            this.btnPesquisar.TabIndex = 42;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 481);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_LocalCliente);
            this.Controls.Add(this.gpb_ddBasicCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAdicionar);
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.gpb_ddBasicCliente.ResumeLayout(false);
            this.gpb_ddBasicCliente.PerformLayout();
            this.gpb_LocalCliente.ResumeLayout(false);
            this.gpb_LocalCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_CdCliente;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl_NomeCliente;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lbl_CPFCliente;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lbl_RGCliente;
        private System.Windows.Forms.Label lbl_NascCliente;
        private System.Windows.Forms.TextBox txtFone1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAddVeiculo;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbl_BairroCliente;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lbl_enderCliente;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lbl_CepCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.TextBox txtFone2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb_ddBasicCliente;
        private System.Windows.Forms.GroupBox gpb_LocalCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.MaskedTextBox txtDtNascimento;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisar;
    }
}