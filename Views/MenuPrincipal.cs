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
;
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e){
            new Views.Servicos().ShowDialog();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e) {
            new Views.Unidades().ShowDialog();
        }

        private void consultaFaturamentosToolStripMenuItem_Clic(object sender, EventArgs e) {
            new Relatorios.FaturamentoReport().ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e){

        }

        private void serviçosCategoriasToolStripMenuItem_Click(object sender, EventArgs e){

        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e){

        }

        private void button1_Click(object sender, EventArgs e){
            new Faturamentos().ShowDialog();
        }

        private void ordemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e){

        }

        private void btn_Cliente_Click(object sender, EventArgs e) {
            new Clientes().ShowDialog();
        }

        private void btn_Orcamento_Click(object sender, EventArgs e) {
            new Orcamentos().ShowDialog();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e) {
            new FormasPagamento().ShowDialog();
        }
    }
}
