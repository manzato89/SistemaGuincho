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
                List<Model.Cliente> clientesDeTeste = Testes.Debug.getClientesDeTeste();
                Repositorio.ClienteRepositorio.update(clientesDeTeste);

                Dictionary<int, List<Model.Veiculo>> veiculosDeTeste = new Dictionary<int, List<Model.Veiculo>>();
                foreach(Model.Cliente cliente in clientesDeTeste) {
                    veiculosDeTeste.Add(cliente.id, cliente.veiculos);
                }
                Repositorio.VeiculoRepositorio.update(veiculosDeTeste);
                
            }

            Application.Run(new Frm_Menu());
        }

        public static void setDebug(Form form) {
            debug = true;
            formToDebug = form;
        }

    }
}
