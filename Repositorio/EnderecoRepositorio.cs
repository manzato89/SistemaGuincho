using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class EnderecoRepositorio : Repositorio<Endereco> {

        #region Implementação Singleton
        private static EnderecoRepositorio instance = null;
        public static EnderecoRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new EnderecoRepositorio();
                }
                return instance;
            }
        }

        private EnderecoRepositorio() {

        }
        #endregion

        #region Init
        public void createTable(SqlConnection connection) {
            StringBuilder strSQL;

            // Criação da tabela Endereço
            if (connection.GetSchema("Tables", new[] { null, null, "Endereco", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Endereco (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" logradouro NVARCHAR(150), ");
                strSQL.AppendLine(" numero NVARCHAR(10), ");
                strSQL.AppendLine(" bairro NVARCHAR(30), ");
                strSQL.AppendLine(" cep INTEGER, ");
                strSQL.AppendLine(" complemento NVARCHAR(100), ");
                strSQL.AppendLine(" cidade NVARCHAR(30), ");
                strSQL.AppendLine(" uf NVARCHAR(30) )");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region CRUD
        public bool create(ref Endereco endereco) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                // Cria o endereço
                strSQL = new StringBuilder();
                strSQL.AppendLine("INSERT INTO Endereco (logradouro, numero, bairro, cep, complemento, cidade, uf) ");
                strSQL.AppendLine("VALUES (@logradouro, @numero, @bairro, @cep, @complemento, @cidade, @uf); ");
                strSQL.AppendLine("SELECT @@IDENTITY;");

                endereco.id = connection.Query<int>(strSQL.ToString(), endereco).First();
                return true;
            } catch (Exception ex) {
                return false;
            }
        }

        public List<Endereco> read() {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                List<Endereco> enderecos = connection.Query<Endereco>("SELECT * FROM Endereco").ToList();

                connection.Close();

                return enderecos;
            } catch (Exception ex) {
                return null;
            }
        }

        public Endereco read(int id) {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                Endereco endereco = connection.Query<Endereco>("SELECT * FROM Endereco WHERE id = @id", new { id }).First();

                connection.Close();

                return endereco;
            } catch (Exception ex) {
                return null;
            }
        }

        public bool update(Endereco endereco) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("UPDATE Endereco ");
                strSQL.AppendLine(" logradouro = @logradouro, ");
                strSQL.AppendLine(" numero = @numero, ");
                strSQL.AppendLine(" bairro = @bairro, ");
                strSQL.AppendLine(" cep = @cep, ");
                strSQL.AppendLine(" complemento = @complemento, ");
                strSQL.AppendLine(" cidade = @cidade, ");
                strSQL.AppendLine(" uf = @uf ");
                strSQL.AppendLine("WHERE id = @id");

                connection.Query(strSQL.ToString(), endereco).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(Endereco endereco) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("DELETE FROM Endereco");
                strSQL.AppendLine("WHERE id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        endereco.id
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }
        #endregion

    }
}