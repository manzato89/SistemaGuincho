using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGuincho.Model;
using SistemaGuincho.Utilidades;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Views {
    public partial class AdicionarVeiculo : Form{

        #region Atributos da classe
        private Util.WindowMode windowMode;

        private Model.Cliente cliente;

        private int index;
        #endregion

        #region Inicialização da classe
        private void init() {
            InitializeComponent();
            CenterToScreen();

            index = -1;

            cboTpVeiculo.Items.Add(Veiculo.TipoVeiculo.Carro);
            cboTpVeiculo.Items.Add(Veiculo.TipoVeiculo.Moto);

            // Atualiza o nome do formulário
            this.Text = String.Format("{0} - Veículos", cliente.nome);

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        public AdicionarVeiculo(Model.Cliente cliente) {
            this.cliente = cliente;

            init();

            getFromRepositorio();
        }

        public AdicionarVeiculo(Model.Cliente cliente, Veiculo veiculo) {
            this.cliente = cliente;

            init();

            getFromRepositorio();

            index = cliente.veiculos.FindIndex(veiculoAEncontrar => veiculoAEncontrar.id == veiculo.id);
            if (index > -1)
                selecionaCliente();
        }

        private void getFromRepositorio() {
            cliente.veiculos = VeiculoRepositorio.read(cliente.id);
        }

        #endregion

        #region Botões de navegação
        private void btnPrimeiro_Click(object sender, EventArgs e) {
            if (cliente.veiculos.Count > 0) {
                if (index != 0) {
                    index = 0;
                    selecionaCliente();
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if (index - 1 >= 0) {
                index--;
                selecionaCliente();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e) {
            if (index + 1 < cliente.veiculos.Count) {
                index++;
                selecionaCliente();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            if (cliente.veiculos.Count > 0) {
                if (index != cliente.veiculos.Count - 1) {
                    index = cliente.veiculos.Count - 1;
                    selecionaCliente();
                }
            }
        }

        private void selecionaCliente() {
            fillFields();
        }
        #endregion

        #region CRUD
        // Aciona a criação de um novo cliente
        private void btnAdicionar_Click(object sender, EventArgs e) {
            index = 0;
            txtModelo.Focus();
            clearFields();

            windowMode = Util.WindowMode.ModoDeInsercao;
            windowModeChanged();
        }


        // Cancela a edição
        private void btnCancelar_Click(object sender, EventArgs e) {
            // Verifica se vai inserir um novo registro ou então salvá-lo
            if (windowMode == Util.WindowMode.ModoDeInsercao) {
                clearFields();
            } else if (windowMode == Util.WindowMode.ModoDeEdicao) {
                fillFields();
            }
        }

        // Salva as alterações do veiculo
        private void btnGravar_Click(object sender, EventArgs e) {
            // Cria um novo veiculo
            Veiculo newVeiculo;

            // Cria os dados básicos do veiculo
            Veiculo.TipoVeiculo tpVeiculo = (Veiculo.TipoVeiculo)cboTpVeiculo.SelectedItem;
            string modelo = txtModelo.Text;
            int ano = -1; int.TryParse(txtAno.Text, out ano);
            string cor = txtCor.Text;

            // Cria os dados da placa do veículo
            string placa = txtPlaca.Text;
            string cidade = txtCidade.Text;
            string uf = txtUF.Text;

            newVeiculo = new Veiculo(tpVeiculo, modelo, ano, cor, placa, cidade, uf);
            
            // Verifica se vai inserir um novo registro ou então salvá-lo
            if (windowMode == Util.WindowMode.ModoDeInsercao) {

                if (VeiculoRepositorio.create(ref newVeiculo, cliente.id)) {
                    getFromRepositorio();
                    btnUltimo_Click(null, null);
                } else {
                    clearFields();
                }

            } else if (windowMode == Util.WindowMode.ModoDeEdicao) {
                newVeiculo.id = cliente.veiculos[index].id;

                if (VeiculoRepositorio.update(cliente.id, newVeiculo)) {
                    getFromRepositorio();
                }

                fillFields();
            }

            windowMode = Util.WindowMode.ModoNormal;
            windowModeChanged();
        }

        // Exclui o cliente
        private void btnExcluir_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Confirma a deleção do registro ?" +
                    Environment.NewLine + Environment.NewLine +
                    cliente.veiculos[index].ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                VeiculoRepositorio.delete(cliente.id, cliente.veiculos[index]);

                getFromRepositorio();
                clearFields();
            }
        }

        // Atualiza as informações dos clientes
        private void btnAtualizar_Click(object sender, EventArgs e) {
            getFromRepositorio();

            if (index > -1)
                index = cliente.veiculos.FindIndex(veiculoAEncontrar => veiculoAEncontrar.id == cliente.veiculos[index].id);
        }

        #endregion

        #region Interfaces - Comum
        private void fillFields() {
            if (index > -1 && cliente.veiculos.Count > 0 && index < cliente.veiculos.Count && cliente.veiculos[index] != null) {
                // Preenche as informações básicas do veículo
                txtID.Text = cliente.veiculos[index].id.ToString();
                cboTpVeiculo.SelectedItem = cliente.veiculos[index].tpVeiculo;
                txtModelo.Text = cliente.veiculos[index].modelo;
                txtAno.Text = cliente.veiculos[index].ano.ToString();
                txtCor.Text = cliente.veiculos[index].cor;

                // Preenche as informações da placa do veículo
                txtPlaca.Text = cliente.veiculos[index].placa;
                txtCidade.Text = cliente.veiculos[index].cidadePlaca;
                txtUF.Text = cliente.veiculos[index].ufPlaca;



                windowMode = Util.WindowMode.ModoNormal;
                windowModeChanged();

            }
        }

        private void windowModeChanged() {
            switch (windowMode) {
                case Util.WindowMode.ModoNormal:
                case Util.WindowMode.ModoCriacaoForm:
                    enableFields(windowMode == Util.WindowMode.ModoNormal);

                    btnAdicionar.Enabled = true;
                    btnExcluir.Enabled = windowMode == Util.WindowMode.ModoNormal;

                    btnCancelar.Enabled = false;
                    btnGravar.Enabled = false;

                    btnAtualizar.Enabled = true;
                    btnPrimeiro.Enabled = true;
                    btnAnterior.Enabled = true;
                    btnProximo.Enabled = true;
                    btnUltimo.Enabled = true;
                    break;

                case Util.WindowMode.ModoDeInsercao:
                case Util.WindowMode.ModoDeEdicao:
                    enableFields(true);

                    btnAdicionar.Enabled = false;
                    btnExcluir.Enabled = false;

                    btnCancelar.Enabled = true;
                    btnGravar.Enabled = true;

                    btnAtualizar.Enabled = false;
                    btnPrimeiro.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnProximo.Enabled = false;
                    btnUltimo.Enabled = false;
                    break;
            }
        }

        private void enableFields(bool enable) {
            cboTpVeiculo.Enabled = enable;

            txtModelo.Enabled = enable;
            txtAno.Enabled = enable;
            txtCor.Enabled = enable;

            txtPlaca.Enabled = enable;
            txtCidade.Enabled = enable;
            txtUF.Enabled = enable;
        }

        private void fields_keyDown(object sender, KeyEventArgs e) {
            if (windowMode != Util.WindowMode.ModoDeInsercao && windowMode != Util.WindowMode.ModoCriacaoForm) {
                windowMode = Util.WindowMode.ModoDeEdicao;
                windowModeChanged();
            }
        }

        private void fields_keyDown(object sender, EventArgs e) {
            fields_keyDown(sender, null);
        }

        private void clearFields() {
            index = -1;

            cboTpVeiculo.SelectedIndex = -1;

            txtID.Text = "";
            txtModelo.Text = "";
            txtAno.Text = "";
            txtCor.Text = "";

            txtPlaca.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";

            windowMode = Util.WindowMode.ModoCriacaoForm;
            windowModeChanged();
        }

        #endregion
    }
}