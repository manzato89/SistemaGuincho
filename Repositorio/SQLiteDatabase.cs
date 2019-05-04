using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Utilidades;

namespace SistemaGuincho.Repositorio {
    public static class SQLiteDatabase {

        public static string SQLiteDatabaseFile {
            get { return Environment.CurrentDirectory + "\\" +  Config.folderConfig + "\\" + Config.fileNameDB; }
        }

        public static SQLiteConnection SQLiteDatabaseConnection() {
            return new SQLiteConnection("Data Source=" + SQLiteDatabaseFile);
        }

        public static void loadDatabase() {
            createSQLiteDatabase();
            createTables();
        }

        private static void createSQLiteDatabase() {
            string pathDatabase = GerenciadorArquivos.currentPath + "\\" + Config.folderConfig + "\\" + Config.fileNameDB;

            if (!GerenciadorArquivos.fileExists(pathDatabase)) {
                SQLiteConnection.CreateFile(pathDatabase);
            } else {
                if (Config.debug && !Config.registrosCriados)
                    Config.registrosCriados = true;
            }
        }

        public static void createTables() {
            SQLiteConnection connection = SQLiteDatabaseConnection();
            connection.OpenAndReturn();

            EnderecoRepositorio.Instance.createTable(connection);
            ClienteRepositorio.Instance.createTable(connection);
            VeiculoRepositorio.Instance.createTable(connection);
            OrcamentoRepositorio.Instance.createTable(connection);
            ServicoRepositorio.Instance.createTable(connection);
            UnidadeRepositorio.Instance.createTable(connection);

            connection.Close();

        }

    }
}
