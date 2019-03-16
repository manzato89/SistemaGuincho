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
    public partial class Frm_Servico : Form
    {
        public Frm_Servico()
        {
            InitializeComponent();
        }

        private void Frm_Servico_Load(object sender, EventArgs e)
        {
            this.servicoBindingSource.DataSource = DataContextFactory.DataContext.Servico;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;

        }

        private void btn_NovoServico_Click(object sender, EventArgs e)
        {
            this.servicoBindingSource.AddNew();
        }

        private void btn_GravServico_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.servicoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView_Servico.Refresh();
                MessageBox.Show("Serviço adicionado com sucesso!");
            }
        }

        private bool valida()
        {
            if (txt_DescServico.Text.Trim() == string.Empty) // COMANDO "TRIM" METODO PARA REMOVER ESPAÇO STRING.EMPTY VERIFICA SE A STRING ESTÁ VAZIO
            {
                MessageBox.Show("O preenchimento do campo é obrigatório.");
                txt_DescServico.Focus(); //APONTA PARA O CAMPO "DESCRIÇÃO DA CATEGORIA" DE PREENCHTO OBRIGATORIO
                return false;
            }
            return true;
        }

        private void btn_ExcluirServico_Click(object sender, EventArgs e)

        {
            this.servicoBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("O Serviço foi Excluído!");
        }


        private void btn_CancServico_Click(object sender, EventArgs e)
        {
            this.servicoBindingSource.CancelEdit();
            MessageBox.Show("Inserção/Edição Cancelada!");
        }


    }
}
