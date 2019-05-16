using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Utilidades {
    public static class GerenciadorArquivos {

        public static string currentPath = System.IO.Directory.GetCurrentDirectory();

        public static bool fileExists(string fileName) {
            return System.IO.File.Exists(fileName);
        }

        public static bool folderExists(string folder) {
            return System.IO.Directory.Exists(folder);
        }

        public static void createFolder(string folder) {
            System.IO.Directory.CreateDirectory(folder);
        }

        public static string readFile(string file) {
            return System.IO.File.ReadAllText(file);
        }
    }
}
