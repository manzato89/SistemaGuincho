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
    public partial class Frm_Categoria : Form
    {
        public Frm_Categoria()
        {
            InitializeComponent();
        }

        private void Frm_Categoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btn_NovoCategoria_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void btn_GravCategoria_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {

            this.categoriaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges(); //Atualiza o Banco de Dados
            MessageBox.Show("A Categoria foi Adicionada com sucesso!");
            }
        }

            private bool valida()
            {
             if (txt_DescCategoria.Text.Trim() == string.Empty) // comando "Trim" metodo para remover espaço string.Empty verifica se a string está vazio
                {
                 MessageBox.Show("O preenchimento do campo é obrigatório.");
                 txt_DescCategoria.Focus(); //Aponta para o campo "descrição da categoria" de preenchto obrigatorio
                 return false;
                }
                return true;
            }

        private void btn_ExcluirCategoria_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("A Categoria foi Excluída!");
        }

        private void btn_CancCategoria_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
            MessageBox.Show("Inserção/Edição Cancelada!");
        }

        private void categoriaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
