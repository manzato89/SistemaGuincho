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
            DataContextFactory.DataContext.SubmitChanges(); //ATUALIZA AS MUDANÇAS NO BANCO
            MessageBox.Show("A Categoria foi Adicionada com sucesso!");
            }
        }

            private bool valida()
            {
             if (txt_DescCategoria.Text.Trim() == string.Empty) // COMANDO "TRIM" METODO PARA REMOVER ESPAÇO STRING.EMPTY VERIFICA SE A STRING ESTÁ VAZIO
            {
                 MessageBox.Show("O preenchimento do campo é obrigatório.");
                 txt_DescCategoria.Focus(); //APONTA PARA O CAMPO "DESCRIÇÃO DA CATEGORIA" DE PREENCHTO OBRIGATORIO
                return false;
                }
                return true;
            }

        private void btn_ExcluirCategoria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes) //ESTE IF FAZ A VALIDAÇÃO EXIBE UM MSG BOX QUESTIONANDO SE DESEJA REALMENTE EXCLUIR O REGISTRO
            {
                if (this.CategoriaPossuiServico(this.categoriaAtual))
                    MessageBox.Show("Você não pode Excluir a categoria, pois está vínculada a serviços!");
                else
                {
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("A Categoria foi Excluída!");
                }
            }
            
        }

        private void btn_CancCategoria_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
            MessageBox.Show("Inserção/Edição Cancelada!");
        }

        private void categoriaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public Categoria categoriaAtual // ESTE METODO IRÁ VERIFICAR QUAL É A CATEGORIA ATUAL
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }
        private bool CategoriaPossuiServico(Categoria categoria) //VERIFICA SE EXISTE SERVICO VINCULADO PARA VALIDAR EXCLUSÃO
        {
            var servicos = DataContextFactory.DataContext.Servico.Where
                (x => x.CodigoCategoria == categoria.Codigo);

            if (servicos.Count() > 0)
                return true;
            else
                return false;
        }
        
    }
}
