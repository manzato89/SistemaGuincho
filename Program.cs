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

            if (debug){
                Repositorio.ClienteRepositorio.setClientes(Testes.Debug.getClientesDeTeste());
            }

            Application.Run(new Frm_Menu());
        }

        public static void setDebug(Form form) {
            debug = true;
            formToDebug = form;
        }

    }
}
