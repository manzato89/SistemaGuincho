namespace SistemaGuincho.Views
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.castrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Orcamento = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_CadServico = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.castrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(123, 374);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // castrosToolStripMenuItem
            // 
            this.castrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.unidadesToolStripMenuItem,
            this.formasDePagamentoToolStripMenuItem});
            this.castrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.castrosToolStripMenuItem.Name = "castrosToolStripMenuItem";
            this.castrosToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.castrosToolStripMenuItem.Text = "Cadastros";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // unidadesToolStripMenuItem
            // 
            this.unidadesToolStripMenuItem.Name = "unidadesToolStripMenuItem";
            this.unidadesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.unidadesToolStripMenuItem.Text = "Unidades";
            this.unidadesToolStripMenuItem.Click += new System.EventHandler(this.unidadesToolStripMenuItem_Click);
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            this.formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            this.formasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.formasDePagamentoToolStripMenuItem.Text = "Formas de pagamento";
            this.formasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formasDePagamentoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturamentosToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // faturamentosToolStripMenuItem
            // 
            this.faturamentosToolStripMenuItem.Name = "faturamentosToolStripMenuItem";
            this.faturamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturamentosToolStripMenuItem.Text = "Faturamentos";
            this.faturamentosToolStripMenuItem.Click += new System.EventHandler(this.consultaFaturamentosToolStripMenuItem_Clic);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SistemaGuincho.Properties.Resources.cashier_machine72;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(532, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 104);
            this.button1.TabIndex = 5;
            this.button1.Text = "FATURAMENTO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Orcamento
            // 
            this.btn_Orcamento.BackColor = System.Drawing.Color.Transparent;
            this.btn_Orcamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Orcamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Orcamento.FlatAppearance.BorderSize = 0;
            this.btn_Orcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Orcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Orcamento.Image = global::SistemaGuincho.Properties.Resources.calculator;
            this.btn_Orcamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Orcamento.Location = new System.Drawing.Point(385, 25);
            this.btn_Orcamento.Name = "btn_Orcamento";
            this.btn_Orcamento.Size = new System.Drawing.Size(141, 104);
            this.btn_Orcamento.TabIndex = 4;
            this.btn_Orcamento.Text = "ORÇAMENTO";
            this.btn_Orcamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Orcamento.UseVisualStyleBackColor = false;
            this.btn_Orcamento.Click += new System.EventHandler(this.btn_Orcamento_Click);
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cliente.FlatAppearance.BorderSize = 0;
            this.btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cliente.Image = global::SistemaGuincho.Properties.Resources.profile_group;
            this.btn_Cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cliente.Location = new System.Drawing.Point(108, 25);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(141, 104);
            this.btn_Cliente.TabIndex = 3;
            this.btn_Cliente.Text = "CLIENTES";
            this.btn_Cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cliente.UseVisualStyleBackColor = false;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // btn_CadServico
            // 
            this.btn_CadServico.BackColor = System.Drawing.Color.Transparent;
            this.btn_CadServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CadServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadServico.FlatAppearance.BorderSize = 0;
            this.btn_CadServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadServico.Image = global::SistemaGuincho.Properties.Resources.wrench_screwdriver;
            this.btn_CadServico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CadServico.Location = new System.Drawing.Point(238, 25);
            this.btn_CadServico.Name = "btn_CadServico";
            this.btn_CadServico.Size = new System.Drawing.Size(141, 104);
            this.btn_CadServico.TabIndex = 0;
            this.btn_CadServico.Text = "SERVIÇOS";
            this.btn_CadServico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CadServico.UseVisualStyleBackColor = false;
            this.btn_CadServico.Click += new System.EventHandler(this.btn_CadServico_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Orcamento);
            this.Controls.Add(this.btn_Cliente);
            this.Controls.Add(this.btn_CadServico);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CadServico;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem castrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Orcamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentosToolStripMenuItem;
    }
}

