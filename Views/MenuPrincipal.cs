using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGuincho.Utilidades;

namespace SistemaGuincho.Views{

    public partial class MenuPrincipal : Form{
        public MenuPrincipal(){
            InitializeComponent();
            CenterToScreen();
        }

        private void btn_CadServico_Click(object sender, EventArgs e){
            new Views.Servicos().ShowDialog();
        }

        private void btn_CadCategoria_Click(object sender, EventArgs e){
            Frm_Categoria frm = new Frm_Categoria();
            frm.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e){
            new Views.Servicos().ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e){
            Frm_Categoria frm = new Frm_Categoria();
            frm.Show();
        }

        private void serviçosCategoriasToolStripMenuItem_Click(object sender, EventArgs e){
            Frm_ConsultaServicos frm = new Frm_ConsultaServicos();
            frm.Show();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e){
            Frm_OrdemServico frm = new Frm_OrdemServico();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e){

        }

        private void ordemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e){
            Frm_OrdemServico frm = new Frm_OrdemServico();
            frm.Show();
        }

        private void btn_Cliente_Click(object sender, EventArgs e) {
            new Clientes().ShowDialog();
        }
    }
}
