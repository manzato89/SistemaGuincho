using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Utilidades {
    public static class Config {
        #region Propriedades
        public static string fileNameDB { get; set; }
        public static string fileNameConfig { get; set; }
        public static string folderConfig { get; set; }

        public static bool debug = false;
        #endregion

        public static void init() {
            folderConfig = "Config";
            if (!(System.IO.Directory.Exists(Environment.CurrentDirectory + "\\" + folderConfig)))
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\" + folderConfig);

            if (!debug) {
                fileNameDB = "SistemaGuincho.sqlite";
                fileNameConfig = "SistemaGuincho.txt";
            } else {
                fileNameDB = "_debug_SistemaGuincho.sqlite";
                fileNameConfig = "_debug_SistemaGuincho.txt";
            }
        }

    }
}