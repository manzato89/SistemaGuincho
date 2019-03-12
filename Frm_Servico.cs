using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGuincho.DAL;

namespace SistemaGuincho
{
    public partial class Frm_Servico : Form
    {
        public Frm_Servico()
        {
            InitializeComponent();
        }

        private void Frm_Servico_Load(object sender, EventArgs e)
        {
            this.servicoBindingSource.DataSource = DataContextFactory.DataContext.Servico;

        }

        private void btn_NovoServico_Click(object sender, EventArgs e)
        {
            this.servicoBindingSource.AddNew();
        }

        private void btn_GravServico_Click(object sender, EventArgs e)
        {
            this.servicoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Serviço Adicionado com sucesso!");
        }

        private void btn_ExcluirServico_Click(object sender, EventArgs e)
        {
            this.servicoBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("O serviço foi Excluído!");
        }

        private void btn_CancServico_Click(object sender, EventArgs e)
        {
            this.servicoBindingSource.CancelEdit();
            MessageBox.Show("Inserção/Edição Cancelada!");
        }
    }
}
