namespace SistemaGuincho
{
    partial class Frm_OrdemServico
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_OrdemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OrdemServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tb_ClienteBindingSource;
            this.comboBox1.DisplayMember = "cep_cliente";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "bairro_cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nova Venda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_ClienteBindingSource
            // 
            this.tb_ClienteBindingSource.DataSource = typeof(SistemaGuincho.DAL.tb_Cliente);
            // 
            // tb_OrdemServicoBindingSource
            // 
            this.tb_OrdemServicoBindingSource.DataSource = typeof(SistemaGuincho.DAL.tb_OrdemServico);
            // 
            // Frm_OrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_OrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_OrdemServico";
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OrdemServicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tb_ClienteBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tb_OrdemServicoBindingSource;
    }
}