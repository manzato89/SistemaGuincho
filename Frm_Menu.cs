using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGuincho
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_CadServico_Click(object sender, EventArgs e)
        {
            Frm_Servico frm = new Frm_Servico();
            frm.Show();
        }

        private void btn_CadCategoria_Click(object sender, EventArgs e)
        {
            Frm_Categoria frm = new Frm_Categoria();
            frm.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Servico frm = new Frm_Servico();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Categoria frm = new Frm_Categoria();
            frm.Show();
        }

        private void serviçosCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConsultaServicos frm = new Frm_ConsultaServicos();
            frm.Show();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrdemServico frm = new Frm_OrdemServico();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ordemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_OrdemServico frm = new Frm_OrdemServico();
            frm.Show();
        }
    }
}
