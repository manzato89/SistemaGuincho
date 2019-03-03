namespace SistemaGuincho
{
    partial class Frm_Menu
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
            this.btn_CadCategoria = new System.Windows.Forms.Button();
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
            this.castrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(95, 465);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // castrosToolStripMenuItem
            // 
            this.castrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.castrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.castrosToolStripMenuItem.Name = "castrosToolStripMenuItem";
            this.castrosToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.castrosToolStripMenuItem.Text = "Cadastros";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // btn_CadCategoria
            // 
            this.btn_CadCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btn_CadCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CadCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadCategoria.FlatAppearance.BorderSize = 0;
            this.btn_CadCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadCategoria.Image = global::SistemaGuincho.Properties.Resources.tag_alt;
            this.btn_CadCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CadCategoria.Location = new System.Drawing.Point(285, 48);
            this.btn_CadCategoria.Name = "btn_CadCategoria";
            this.btn_CadCategoria.Size = new System.Drawing.Size(111, 104);
            this.btn_CadCategoria.TabIndex = 2;
            this.btn_CadCategoria.Text = "CATEGORIAS";
            this.btn_CadCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CadCategoria.UseVisualStyleBackColor = false;
            this.btn_CadCategoria.Click += new System.EventHandler(this.btn_CadCategoria_Click);
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
            this.btn_CadServico.Location = new System.Drawing.Point(119, 48);
            this.btn_CadServico.Name = "btn_CadServico";
            this.btn_CadServico.Size = new System.Drawing.Size(111, 104);
            this.btn_CadServico.TabIndex = 0;
            this.btn_CadServico.Text = "SERVIÇOS";
            this.btn_CadServico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CadServico.UseVisualStyleBackColor = false;
            this.btn_CadServico.Click += new System.EventHandler(this.btn_CadServico_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 465);
            this.Controls.Add(this.btn_CadCategoria);
            this.Controls.Add(this.btn_CadServico);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Frm_Menu";
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
        private System.Windows.Forms.Button btn_CadCategoria;
    }
}

