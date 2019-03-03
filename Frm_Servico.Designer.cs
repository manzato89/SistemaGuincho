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
            this.lbl_codServico = new System.Windows.Forms.Label();
            this.txt_codServico = new System.Windows.Forms.TextBox();
            this.txt_DescServico = new System.Windows.Forms.TextBox();
            this.lbl_DescServico = new System.Windows.Forms.Label();
            this.txt_VlrServico = new System.Windows.Forms.TextBox();
            this.lbl_VlrServico = new System.Windows.Forms.Label();
            this.lbl_CatServico = new System.Windows.Forms.Label();
            this.cbb_CatServicos = new System.Windows.Forms.ComboBox();
            this.btn_NovoServico = new System.Windows.Forms.Button();
            this.btn_CadServico = new System.Windows.Forms.Button();
            this.btn_ExcluirServico = new System.Windows.Forms.Button();
            this.btn_CancServico = new System.Windows.Forms.Button();
            this.dataGridView_Servico = new System.Windows.Forms.DataGridView();
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
            this.txt_codServico.Location = new System.Drawing.Point(78, 46);
            this.txt_codServico.Name = "txt_codServico";
            this.txt_codServico.Size = new System.Drawing.Size(108, 20);
            this.txt_codServico.TabIndex = 1;
            // 
            // txt_DescServico
            // 
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
            this.cbb_CatServicos.FormattingEnabled = true;
            this.cbb_CatServicos.Location = new System.Drawing.Point(265, 84);
            this.cbb_CatServicos.Name = "cbb_CatServicos";
            this.cbb_CatServicos.Size = new System.Drawing.Size(121, 21);
            this.cbb_CatServicos.TabIndex = 7;
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
            // 
            // btn_CadServico
            // 
            this.btn_CadServico.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CadServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadServico.Location = new System.Drawing.Point(276, 139);
            this.btn_CadServico.Name = "btn_CadServico";
            this.btn_CadServico.Size = new System.Drawing.Size(88, 28);
            this.btn_CadServico.TabIndex = 9;
            this.btn_CadServico.Text = "Cadastrar";
            this.btn_CadServico.UseVisualStyleBackColor = false;
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
            // 
            // dataGridView_Servico
            // 
            this.dataGridView_Servico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Servico.Location = new System.Drawing.Point(35, 210);
            this.dataGridView_Servico.Name = "dataGridView_Servico";
            this.dataGridView_Servico.Size = new System.Drawing.Size(673, 245);
            this.dataGridView_Servico.TabIndex = 12;
            // 
            // Frm_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 483);
            this.Controls.Add(this.dataGridView_Servico);
            this.Controls.Add(this.btn_CancServico);
            this.Controls.Add(this.btn_ExcluirServico);
            this.Controls.Add(this.btn_CadServico);
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
        private System.Windows.Forms.Button btn_CadServico;
        private System.Windows.Forms.Button btn_ExcluirServico;
        private System.Windows.Forms.Button btn_CancServico;
        private System.Windows.Forms.DataGridView dataGridView_Servico;
    }
}