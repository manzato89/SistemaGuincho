namespace SistemaGuincho
{
    partial class Frm_Categoria
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
            this.dataGridView_Categoria = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_CancCategoria = new System.Windows.Forms.Button();
            this.btn_ExcluirCategoria = new System.Windows.Forms.Button();
            this.btn_GravCategoria = new System.Windows.Forms.Button();
            this.btn_NovoCategoria = new System.Windows.Forms.Button();
            this.txt_DescCategoria = new System.Windows.Forms.TextBox();
            this.lbl_DescCategoria = new System.Windows.Forms.Label();
            this.txt_codCategoria = new System.Windows.Forms.TextBox();
            this.lbl_codCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Categoria
            // 
            this.dataGridView_Categoria.AllowUserToAddRows = false;
            this.dataGridView_Categoria.AllowUserToDeleteRows = false;
            this.dataGridView_Categoria.AutoGenerateColumns = false;
            this.dataGridView_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView_Categoria.DataSource = this.categoriaBindingSource;
            this.dataGridView_Categoria.Location = new System.Drawing.Point(49, 194);
            this.dataGridView_Categoria.Name = "dataGridView_Categoria";
            this.dataGridView_Categoria.ReadOnly = true;
            this.dataGridView_Categoria.Size = new System.Drawing.Size(673, 245);
            this.dataGridView_Categoria.TabIndex = 25;
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
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(SistemaGuincho.DAL.Categoria);
            this.categoriaBindingSource.CurrentChanged += new System.EventHandler(this.categoriaBindingSource_CurrentChanged);
            // 
            // btn_CancCategoria
            // 
            this.btn_CancCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancCategoria.Location = new System.Drawing.Point(510, 123);
            this.btn_CancCategoria.Name = "btn_CancCategoria";
            this.btn_CancCategoria.Size = new System.Drawing.Size(88, 28);
            this.btn_CancCategoria.TabIndex = 24;
            this.btn_CancCategoria.Text = "Cancelar";
            this.btn_CancCategoria.UseVisualStyleBackColor = false;
            this.btn_CancCategoria.Click += new System.EventHandler(this.btn_CancCategoria_Click);
            // 
            // btn_ExcluirCategoria
            // 
            this.btn_ExcluirCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ExcluirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirCategoria.Location = new System.Drawing.Point(400, 123);
            this.btn_ExcluirCategoria.Name = "btn_ExcluirCategoria";
            this.btn_ExcluirCategoria.Size = new System.Drawing.Size(88, 28);
            this.btn_ExcluirCategoria.TabIndex = 23;
            this.btn_ExcluirCategoria.Text = "Excluir";
            this.btn_ExcluirCategoria.UseVisualStyleBackColor = false;
            this.btn_ExcluirCategoria.Click += new System.EventHandler(this.btn_ExcluirCategoria_Click);
            // 
            // btn_GravCategoria
            // 
            this.btn_GravCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btn_GravCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravCategoria.Location = new System.Drawing.Point(290, 123);
            this.btn_GravCategoria.Name = "btn_GravCategoria";
            this.btn_GravCategoria.Size = new System.Drawing.Size(88, 28);
            this.btn_GravCategoria.TabIndex = 22;
            this.btn_GravCategoria.Text = "Gravar";
            this.btn_GravCategoria.UseVisualStyleBackColor = false;
            this.btn_GravCategoria.Click += new System.EventHandler(this.btn_GravCategoria_Click);
            // 
            // btn_NovoCategoria
            // 
            this.btn_NovoCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btn_NovoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoCategoria.Location = new System.Drawing.Point(184, 123);
            this.btn_NovoCategoria.Name = "btn_NovoCategoria";
            this.btn_NovoCategoria.Size = new System.Drawing.Size(88, 28);
            this.btn_NovoCategoria.TabIndex = 21;
            this.btn_NovoCategoria.Text = "Novo";
            this.btn_NovoCategoria.UseVisualStyleBackColor = false;
            this.btn_NovoCategoria.Click += new System.EventHandler(this.btn_NovoCategoria_Click);
            // 
            // txt_DescCategoria
            // 
            this.txt_DescCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Descricao", true));
            this.txt_DescCategoria.Location = new System.Drawing.Point(278, 46);
            this.txt_DescCategoria.Name = "txt_DescCategoria";
            this.txt_DescCategoria.Size = new System.Drawing.Size(444, 20);
            this.txt_DescCategoria.TabIndex = 16;
            // 
            // lbl_DescCategoria
            // 
            this.lbl_DescCategoria.AutoSize = true;
            this.lbl_DescCategoria.Location = new System.Drawing.Point(217, 49);
            this.lbl_DescCategoria.Name = "lbl_DescCategoria";
            this.lbl_DescCategoria.Size = new System.Drawing.Size(55, 13);
            this.lbl_DescCategoria.TabIndex = 15;
            this.lbl_DescCategoria.Text = "Descrição";
            // 
            // txt_codCategoria
            // 
            this.txt_codCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Codigo", true));
            this.txt_codCategoria.Location = new System.Drawing.Point(92, 46);
            this.txt_codCategoria.Name = "txt_codCategoria";
            this.txt_codCategoria.Size = new System.Drawing.Size(108, 20);
            this.txt_codCategoria.TabIndex = 14;
            // 
            // lbl_codCategoria
            // 
            this.lbl_codCategoria.AutoSize = true;
            this.lbl_codCategoria.Location = new System.Drawing.Point(46, 49);
            this.lbl_codCategoria.Name = "lbl_codCategoria";
            this.lbl_codCategoria.Size = new System.Drawing.Size(40, 13);
            this.lbl_codCategoria.TabIndex = 13;
            this.lbl_codCategoria.Text = "Código";
            // 
            // Frm_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 469);
            this.Controls.Add(this.dataGridView_Categoria);
            this.Controls.Add(this.btn_CancCategoria);
            this.Controls.Add(this.btn_ExcluirCategoria);
            this.Controls.Add(this.btn_GravCategoria);
            this.Controls.Add(this.btn_NovoCategoria);
            this.Controls.Add(this.txt_DescCategoria);
            this.Controls.Add(this.lbl_DescCategoria);
            this.Controls.Add(this.txt_codCategoria);
            this.Controls.Add(this.lbl_codCategoria);
            this.Name = "Frm_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Frm_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Categoria;
        private System.Windows.Forms.Button btn_CancCategoria;
        private System.Windows.Forms.Button btn_ExcluirCategoria;
        private System.Windows.Forms.Button btn_GravCategoria;
        private System.Windows.Forms.Button btn_NovoCategoria;
        private System.Windows.Forms.TextBox txt_DescCategoria;
        private System.Windows.Forms.Label lbl_DescCategoria;
        private System.Windows.Forms.TextBox txt_codCategoria;
        private System.Windows.Forms.Label lbl_codCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}