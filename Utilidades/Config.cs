using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Utilidades {
    public static class Config {
        #region Propriedades
        public static string fileNameConfig { get; set; }
        public static string folderConfig { get; set; }
        public static string connectionStringFile { get; set; }
        public static string connectionStringFolder { get; set; }

        public static bool debug = false;
        public static bool registrosCriados = false;
        #endregion

        public static bool init() {
            folderConfig = "Config";
            if (!(GerenciadorArquivos.folderExists(Environment.CurrentDirectory + "\\" + folderConfig)))
                GerenciadorArquivos.createFolder(Environment.CurrentDirectory + "\\" + folderConfig);

            //connectionStringFolder = Environment.CurrentDirectory + "\\" + folderConfig;
            connectionStringFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            connectionStringFile = connectionStringFolder + "\\" + nameof(connectionStringFile) + ".txt";
            if (!(GerenciadorArquivos.fileExists(connectionStringFile)))
                return false;

            return true;
        }

    }
}