using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho{
    public static class Program{

        private static Form formToDebug;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        public static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!(Utilidades.Util.inicializarSistema())) {
                MessageBox.Show(String.Format("Não foi possível inicializar o sistema.\n\nO arquivo {0} deve existir e conter a string de conexão com o banco de dados", Utilidades.Config.connectionStringFile),
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Environment.Exit(1);
            }

            if (Utilidades.Config.debug){

                if (!Utilidades.Config.registrosCriados) {

                    // Cria os clientes de teste
                    List<Cliente> clientesDeTeste = Testes.Debug.getClientesDeTeste();
                    for (int iCount = 0; iCount < clientesDeTeste.Count; iCount++) {
                        Cliente cliente = clientesDeTeste[iCount];
                        ClienteRepositorio.Instance.create(ref cliente);
                        clientesDeTeste[iCount] = cliente;
                    }

                    // Cria as unidades de teste
                    List<Unidade> unidadesDeTeste = Testes.Debug.getUnidadesDeTeste();
                    for (int iCount = 0; iCount < unidadesDeTeste.Count; iCount++) {
                        Unidade unidadeTeste = unidadesDeTeste[iCount];
                        UnidadeRepositorio.Instance.create(ref unidadeTeste);
                        unidadesDeTeste[iCount] = unidadeTeste;
                    }

                    // Cria as formas de pagamento de teste
                    List<FormaPagamento> formasPagamentoDeTeste = Testes.Debug.getFormasDePagamentoDeTeste();
                    for (int iCount = 0; iCount < unidadesDeTeste.Count; iCount++) {
                        FormaPagamento formaDePagamentoDeTeste = formasPagamentoDeTeste[iCount];
                        FormaPagamentoRepositorio.Instance.create(ref formaDePagamentoDeTeste);
                        formasPagamentoDeTeste[iCount] = formaDePagamentoDeTeste;
                    }

                    // Cria os serviços de teste
                    List<Servico> servicosDeTeste = Testes.Debug.getServicosDeTeste();
                    for (int iCount = 0; iCount < servicosDeTeste.Count; iCount++) {
                        Servico servicoDeTeste = servicosDeTeste[iCount];
                        ServicoRepositorio.Instance.create(ref servicoDeTeste);
                        servicosDeTeste[iCount] = servicoDeTeste;
                    }

                    // Cria os orçamentos de teste
                    List<Orcamento> orcamentosDeTeste = Testes.Debug.getOrcamentosDeTeste();
                    for(int iCount = 0; iCount < orcamentosDeTeste.Count; iCount++) {
                        Orcamento orcamentoDeTeste = orcamentosDeTeste[iCount];
                        OrcamentoRepositorio.Instance.create(ref orcamentoDeTeste);
                        orcamentosDeTeste[iCount] = orcamentoDeTeste;
                    }

                    // Cria os faturamentos de teste
                    List<Faturamento> faturamentoDeTeste = Testes.Debug.getFaturamentosDeTeste();
                    for (int iCount = 0; iCount < faturamentoDeTeste.Count; iCount++) {
                        Faturamento faturamentoDeTest = faturamentoDeTeste[iCount];
                        FaturamentoRepositorio.Instance.create(ref faturamentoDeTest);
                        faturamentoDeTeste[iCount] = faturamentoDeTest;
                    }
                }
            }

            Application.Run(new Views.Senha());
        }
    }
}