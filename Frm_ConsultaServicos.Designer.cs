namespace SistemaGuincho
{
    partial class Frm_ConsultaServicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_PesqServporCategoria = new System.Windows.Forms.Button();
            this.lbl_PesqServporCategoria = new System.Windows.Forms.Label();
            this.cbb_PesqServporCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(SistemaGuincho.DAL.Servico);
            // 
            // servicoDataGridView
            // 
            this.servicoDataGridView.AllowUserToAddRows = false;
            this.servicoDataGridView.AllowUserToDeleteRows = false;
            this.servicoDataGridView.AutoGenerateColumns = false;
            this.servicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.servicoDataGridView.DataSource = this.servicoBindingSource;
            this.servicoDataGridView.Location = new System.Drawing.Point(12, 106);
            this.servicoDataGridView.Name = "servicoDataGridView";
            this.servicoDataGridView.ReadOnly = true;
            this.servicoDataGridView.Size = new System.Drawing.Size(581, 231);
            this.servicoDataGridView.TabIndex = 1;
            // 
            // btn_PesqServporCategoria
            // 
            this.btn_PesqServporCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesqServporCategoria.Location = new System.Drawing.Point(442, 24);
            this.btn_PesqServporCategoria.Name = "btn_PesqServporCategoria";
            this.btn_PesqServporCategoria.Size = new System.Drawing.Size(100, 23);
            this.btn_PesqServporCategoria.TabIndex = 2;
            this.btn_PesqServporCategoria.Text = "Pesquisar";
            this.btn_PesqServporCategoria.UseVisualStyleBackColor = true;
            this.btn_PesqServporCategoria.Click += new System.EventHandler(this.btn_PesqServporCategoria_Click);
            // 
            // lbl_PesqServporCategoria
            // 
            this.lbl_PesqServporCategoria.AutoSize = true;
            this.lbl_PesqServporCategoria.Location = new System.Drawing.Point(55, 29);
            this.lbl_PesqServporCategoria.Name = "lbl_PesqServporCategoria";
            this.lbl_PesqServporCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_PesqServporCategoria.TabIndex = 3;
            this.lbl_PesqServporCategoria.Text = "Categoria";
            this.lbl_PesqServporCategoria.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // cbb_PesqServporCategoria
            // 
            this.cbb_PesqServporCategoria.DataSource = this.categoriaBindingSource;
            this.cbb_PesqServporCategoria.DisplayMember = "Descricao";
            this.cbb_PesqServporCategoria.FormattingEnabled = true;
            this.cbb_PesqServporCategoria.Location = new System.Drawing.Point(113, 26);
            this.cbb_PesqServporCategoria.Name = "cbb_PesqServporCategoria";
            this.cbb_PesqServporCategoria.Size = new System.Drawing.Size(298, 21);
            this.cbb_PesqServporCategoria.TabIndex = 4;
            this.cbb_PesqServporCategoria.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(SistemaGuincho.DAL.Categoria);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Serviço";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Frm_ConsultaServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 358);
            this.Controls.Add(this.cbb_PesqServporCategoria);
            this.Controls.Add(this.lbl_PesqServporCategoria);
            this.Controls.Add(this.btn_PesqServporCategoria);
            this.Controls.Add(this.servicoDataGridView);
            this.Name = "Frm_ConsultaServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Serviços por Categoria";
            this.Load += new System.EventHandler(this.Frm_ConsultaServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.DataGridView servicoDataGridView;
        private System.Windows.Forms.Button btn_PesqServporCategoria;
        private System.Windows.Forms.Label lbl_PesqServporCategoria;
        private System.Windows.Forms.ComboBox cbb_PesqServporCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}