using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaGuincho.Utilidades;

namespace SistemaGuincho.Repositorio {
    public class SQLServerDatabase {

        #region Implementação Singleton
        private static SQLServerDatabase instance = null;
        public static SQLServerDatabase Instance {
            get {
                if (instance == null) {
                    string connectionStringFileContent = GerenciadorArquivos.readFile(Config.connectionStringFile);

                    string servidor = Util.getContentBetween(connectionStringFileContent, "SERVIDOR");
                    string bancoDeDados = Util.getContentBetween(connectionStringFileContent, "BANCO DE DADOS");
                    string usuario = Util.getContentBetween(connectionStringFileContent, "USUARIO");
                    string senha = Util.getContentBetween(connectionStringFileContent, "SENHA");

                    if (servidor == null || bancoDeDados == null || usuario == null || senha == null)
                        return null;

                    instance = new SQLServerDatabase(servidor, bancoDeDados, usuario, senha);
                }
                return instance;
            }
        }

        private SQLServerDatabase(string servidor, string bancoDeDados, string usuario, string senha) {
            this.servidor = servidor;
            this.bancoDeDados = bancoDeDados;
            this.usuario = usuario;
            this.senha = senha;
        }
        #endregion

        private string servidor;
        private string bancoDeDados;
        private string usuario;
        private string senha;

        public string SQLServerConnectionString {
            get {
                StringBuilder connectionString = new StringBuilder();

                connectionString.AppendFormat("Data Source={0};", servidor);
                connectionString.AppendFormat("Initial Catalog={0};", bancoDeDados);
                connectionString.AppendFormat("Integrated Security=SSPI;");
                connectionString.AppendFormat("User ID={0};", usuario);
                connectionString.AppendFormat("Password={0};", senha);

                return connectionString.ToString();
            }
        }

        public SqlConnection SQLServerDatabaseConnection() {
            return new SqlConnection(SQLServerConnectionString);
        }

        public void loadDatabase() {
            createTables();
        }

        public void createTables() {
            SqlConnection connection = SQLServerDatabaseConnection();
            connection.Open();

            UnidadeRepositorio.Instance.createTable(connection);
            EnderecoRepositorio.Instance.createTable(connection);
            ClienteRepositorio.Instance.createTable(connection);
            VeiculoRepositorio.Instance.createTable(connection);
            ServicoRepositorio.Instance.createTable(connection);
            FormaPagamentoRepositorio.Instance.createTable(connection);
            FaturamentoRepositorio.Instance.createTable(connection);
            OrcamentoRepositorio.Instance.createTable(connection);

            connection.Close();
        }

    }
}