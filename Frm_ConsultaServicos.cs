using SistemaGuincho.DAL;
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
    public partial class Frm_ConsultaServicos : Form
    {
        public Frm_ConsultaServicos()
        {
            InitializeComponent();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ConsultaServicos_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btn_PesqServporCategoria_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)cbb_PesqServporCategoria.SelectedValue);
        }

        public void Pesquisar (int codigoCategoria)
        {
            this.servicoBindingSource.DataSource = DataContextFactory.DataContext.Servico.Where
                (x => x.CodigoCategoria == codigoCategoria);
        }
    }
}
