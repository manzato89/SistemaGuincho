using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGuincho{
    public static class Program{

        private static bool debug = true;
        private static Form formToDebug;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        public static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Utilidades.Util.inicializarRepositorios();

            if (debug){
                // Cria os clientes de teste
                List<Model.Cliente> clientesDeTeste = Testes.Debug.getClientesDeTeste();
                Repositorio.ClienteRepositorio.update(clientesDeTeste);

                // Cria os veículos de teste
                Dictionary<int, List<Model.Veiculo>> veiculosDeTeste = new Dictionary<int, List<Model.Veiculo>>();
                foreach(Model.Cliente cliente in clientesDeTeste) {
                    veiculosDeTeste.Add(cliente.id, cliente.veiculos);
                }
                Repositorio.VeiculoRepositorio.update(veiculosDeTeste);

                // Cria as unidades de teste
                Repositorio.UnidadeRepositorio.update(Testes.Debug.getUnidadesDeTeste());

                // Cria os serviços de teste
                Repositorio.ServicoRepositorio.update(Testes.Debug.getServicosDeTeste());

                // Cria os orçamentos de teste
                Repositorio.OrcamentoRepositorio.update(Testes.Debug.getOrcamentosDeTeste());
            }

            Application.Run(new Views.MenuPrincipal());
        }

        public static void setDebug(Form form) {
            debug = true;
            formToDebug = form;
        }

    }
}
