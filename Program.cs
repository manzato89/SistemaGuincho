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

            Utilidades.Util.inicializarSistema();

            if (Utilidades.Config.debug){
                // Cria os clientes de teste
                List<Cliente> clientesDeTeste = Testes.Debug.getClientesDeTeste();
                for (int iCount = 0; iCount < clientesDeTeste.Count; iCount++) {
                    Cliente cliente = clientesDeTeste[iCount];
                    ClienteRepositorio.Instance.create(ref cliente);
                    clientesDeTeste[iCount] = cliente;
                }

                // Cria os veículos de teste
                Dictionary<int, List<Veiculo>> veiculosDeTeste = new Dictionary<int, List<Model.Veiculo>>();
                foreach(Cliente cliente in clientesDeTeste) {
                    veiculosDeTeste.Add(cliente.id, cliente.veiculos);
                }
                //VeiculoRepositorio.Instance.update(veiculosDeTeste);

                // Cria as unidades de teste
                UnidadeRepositorio.Instance.update(Testes.Debug.getUnidadesDeTeste());

                // Cria os serviços de teste
                ServicoRepositorio.Instance.update(Testes.Debug.getServicosDeTeste());

                // Cria os orçamentos de teste
                OrcamentoRepositorio.Instance.update(Testes.Debug.getOrcamentosDeTeste());
            }

            Application.Run(new Views.MenuPrincipal());
        }
    }
}
