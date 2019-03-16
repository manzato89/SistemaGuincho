namespace SistemaGuincho
{
    partial class Frm_Servico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_codServico = new System.Windows.Forms.Label();
            this.txt_codServico = new System.Windows.Forms.TextBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_DescServico = new System.Windows.Forms.TextBox();
            this.lbl_DescServico = new System.Windows.Forms.Label();
            this.txt_VlrServico = new System.Windows.Forms.TextBox();
            this.lbl_VlrServico = new System.Windows.Forms.Label();
            this.lbl_CatServico = new System.Windows.Forms.Label();
            this.cbb_CatServicos = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_NovoServico = new System.Windows.Forms.Button();
            this.btn_GravServico = new System.Windows.Forms.Button();
            this.btn_ExcluirServico = new System.Windows.Forms.Button();
            this.btn_CancServico = new System.Windows.Forms.Button();
            this.dataGridView_Servico = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Servico)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codServico
            // 
            this.lbl_codServico.AutoSize = true;
            this.lbl_codServico.Location = new System.Drawing.Point(32, 49);
            this.lbl_codServico.Name = "lbl_codServico";
            this.lbl_codServico.Size = new System.Drawing.Size(40, 13);
            this.lbl_codServico.TabIndex = 0;
            this.lbl_codServico.Text = "Código";
            // 
            // txt_codServico
            // 
            this.txt_codServico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Codigo", true));
            this.txt_codServico.Location = new System.Drawing.Point(78, 46);
            this.txt_codServico.Name = "txt_codServico";
            this.txt_codServico.Size = new System.Drawing.Size(108, 20);
            this.txt_codServico.TabIndex = 1;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(SistemaGuincho.DAL.Servico);
            // 
            // txt_DescServico
            // 
            this.txt_DescServico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.txt_DescServico.Location = new System.Drawing.Point(264, 46);
            this.txt_DescServico.Name = "txt_DescServico";
            this.txt_DescServico.Size = new System.Drawing.Size(444, 20);
            this.txt_DescServico.TabIndex = 3;
            // 
            // lbl_DescServico
            // 
            this.lbl_DescServico.AutoSize = true;
            this.lbl_DescServico.Location = new System.Drawing.Point(203, 49);
            this.lbl_DescServico.Name = "lbl_DescServico";
            this.lbl_DescServico.Size = new System.Drawing.Size(55, 13);
            this.lbl_DescServico.TabIndex = 2;
            this.lbl_DescServico.Text = "Descrição";
            // 
            // txt_VlrServico
            // 
            this.txt_VlrServico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Valor", true));
            this.txt_VlrServico.Location = new System.Drawing.Point(78, 86);
            this.txt_VlrServico.Name = "txt_VlrServico";
            this.txt_VlrServico.Size = new System.Drawing.Size(108, 20);
            this.txt_VlrServico.TabIndex = 5;
            // 
            // lbl_VlrServico
            // 
            this.lbl_VlrServico.AutoSize = true;
            this.lbl_VlrServico.Location = new System.Drawing.Point(32, 89);
            this.lbl_VlrServico.Name = "lbl_VlrServico";
            this.lbl_VlrServico.Size = new System.Drawing.Size(31, 13);
            this.lbl_VlrServico.TabIndex = 4;
            this.lbl_VlrServico.Text = "Valor";
            // 
            // lbl_CatServico
            // 
            this.lbl_CatServico.AutoSize = true;
            this.lbl_CatServico.Location = new System.Drawing.Point(206, 89);
            this.lbl_CatServico.Name = "lbl_CatServico";
            this.lbl_CatServico.Size = new System.Drawing.Size(52, 13);
            this.lbl_CatServico.TabIndex = 6;
            this.lbl_CatServico.Text = "Categoria";
            // 
            // cbb_CatServicos
            // 
            this.cbb_CatServicos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.servicoBindingSource, "CodigoCategoria", true));
            this.cbb_CatServicos.DataSource = this.categoriaBindingSource;
            this.cbb_CatServicos.DisplayMember = "Descricao";
            this.cbb_CatServicos.FormattingEnabled = true;
            this.cbb_CatServicos.Location = new System.Drawing.Point(265, 84);
            this.cbb_CatServicos.Name = "cbb_CatServicos";
            this.cbb_CatServicos.Size = new System.Drawing.Size(121, 21);
            this.cbb_CatServicos.TabIndex = 7;
            this.cbb_CatServicos.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(SistemaGuincho.DAL.Categoria);
            // 
            // btn_NovoServico
            // 
            this.btn_NovoServico.BackColor = System.Drawing.SystemColors.Control;
            this.btn_NovoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoServico.Location = new System.Drawing.Point(170, 139);
            this.btn_NovoServico.Name = "btn_NovoServico";
            this.btn_NovoServico.Size = new System.Drawing.Size(88, 28);
            this.btn_NovoServico.TabIndex = 8;
            this.btn_NovoServico.Text = "Novo";
            this.btn_NovoServico.UseVisualStyleBackColor = false;
            this.btn_NovoServico.Click += new System.EventHandler(this.btn_NovoServico_Click);
            // 
            // btn_GravServico
            // 
            this.btn_GravServico.BackColor = System.Drawing.SystemColors.Control;
            this.btn_GravServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravServico.Location = new System.Drawing.Point(276, 139);
            this.btn_GravServico.Name = "btn_GravServico";
            this.btn_GravServico.Size = new System.Drawing.Size(88, 28);
            this.btn_GravServico.TabIndex = 9;
            this.btn_GravServico.Text = "Gravar";
            this.btn_GravServico.UseVisualStyleBackColor = false;
            this.btn_GravServico.Click += new System.EventHandler(this.btn_GravServico_Click);
            // 
            // btn_ExcluirServico
            // 
            this.btn_ExcluirServico.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ExcluirServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirServico.Location = new System.Drawing.Point(386, 139);
            this.btn_ExcluirServico.Name = "btn_ExcluirServico";
            this.btn_ExcluirServico.Size = new System.Drawing.Size(88, 28);
            this.btn_ExcluirServico.TabIndex = 10;
            this.btn_ExcluirServico.Text = "Excluir";
            this.btn_ExcluirServico.UseVisualStyleBackColor = false;
            this.btn_ExcluirServico.Click += new System.EventHandler(this.btn_ExcluirServico_Click);
            // 
            // btn_CancServico
            // 
            this.btn_CancServico.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancServico.Location = new System.Drawing.Point(496, 139);
            this.btn_CancServico.Name = "btn_CancServico";
            this.btn_CancServico.Size = new System.Drawing.Size(88, 28);
            this.btn_CancServico.TabIndex = 11;
            this.btn_CancServico.Text = "Cancelar";
            this.btn_CancServico.UseVisualStyleBackColor = false;
            this.btn_CancServico.Click += new System.EventHandler(this.btn_CancServico_Click);
            // 
            // dataGridView_Servico
            // 
            this.dataGridView_Servico.AllowUserToAddRows = false;
            this.dataGridView_Servico.AllowUserToDeleteRows = false;
            this.dataGridView_Servico.AutoGenerateColumns = false;
            this.dataGridView_Servico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Servico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.CodigoCategoria,
            this.categoriaDataGridViewTextBoxColumn});
            this.dataGridView_Servico.DataSource = this.servicoBindingSource;
            this.dataGridView_Servico.Location = new System.Drawing.Point(35, 210);
            this.dataGridView_Servico.Name = "dataGridView_Servico";
            this.dataGridView_Servico.ReadOnly = true;
            this.dataGridView_Servico.Size = new System.Drawing.Size(673, 245);
            this.dataGridView_Servico.TabIndex = 12;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 200;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CodigoCategoria
            // 
            this.CodigoCategoria.DataPropertyName = "CodigoCategoria";
            this.CodigoCategoria.HeaderText = "Código da Categoria";
            this.CodigoCategoria.Name = "CodigoCategoria";
            this.CodigoCategoria.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frm_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 483);
            this.Controls.Add(this.dataGridView_Servico);
            this.Controls.Add(this.btn_CancServico);
            this.Controls.Add(this.btn_ExcluirServico);
            this.Controls.Add(this.btn_GravServico);
            this.Controls.Add(this.btn_NovoServico);
            this.Controls.Add(this.cbb_CatServicos);
            this.Controls.Add(this.lbl_CatServico);
            this.Controls.Add(this.txt_VlrServico);
            this.Controls.Add(this.lbl_VlrServico);
            this.Controls.Add(this.txt_DescServico);
            this.Controls.Add(this.lbl_DescServico);
            this.Controls.Add(this.txt_codServico);
            this.Controls.Add(this.lbl_codServico);
            this.Name = "Frm_Servico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Serviços";
            this.Load += new System.EventHandler(this.Frm_Servico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Servico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codServico;
        private System.Windows.Forms.TextBox txt_codServico;
        private System.Windows.Forms.TextBox txt_DescServico;
        private System.Windows.Forms.Label lbl_DescServico;
        private System.Windows.Forms.TextBox txt_VlrServico;
        private System.Windows.Forms.Label lbl_VlrServico;
        private System.Windows.Forms.Label lbl_CatServico;
        private System.Windows.Forms.ComboBox cbb_CatServicos;
        private System.Windows.Forms.Button btn_NovoServico;
        private System.Windows.Forms.Button btn_GravServico;
        private System.Windows.Forms.Button btn_ExcluirServico;
        private System.Windows.Forms.Button btn_CancServico;
        private System.Windows.Forms.DataGridView dataGridView_Servico;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}