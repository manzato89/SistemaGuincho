using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class VeiculoRepositorio : Repositorio<Veiculo> {

        #region Implementação Singleton
        private static VeiculoRepositorio instance = null;
        public static VeiculoRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new VeiculoRepositorio();
                }
                return instance;
            }
        }

        private VeiculoRepositorio() {

        }
        #endregion

        #region Init
        public void createTable(SqlConnection connection) {
            StringBuilder strSQL;

            // Criação da tabela auxiliar Veiculos
            if (connection.GetSchema("Tables", new[] { null, null, "Veiculo", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Veiculo (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" idCliente INTEGER, ");
                strSQL.AppendLine(" tpVeiculo INTEGER, ");
                strSQL.AppendLine(" modelo NVARCHAR(30), ");
                strSQL.AppendLine(" cor NVARCHAR(20), ");
                strSQL.AppendLine(" ano INTEGER, ");
                strSQL.AppendLine(" placa NVARCHAR(10), ");
                strSQL.AppendLine(" cidadePlaca NVARCHAR(30), ");
                strSQL.AppendLine(" ufPlaca NVARCHAR(30), ");
                strSQL.AppendLine(" FOREIGN KEY (idCliente) REFERENCES Cliente(id) )");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region CRUD
        public bool create(ref Veiculo newVeiculo) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("INSERT INTO Veiculo (idCliente, tpVeiculo, modelo, cor, ano, placa, cidadePlaca, ufPlaca) ");
                strSQL.AppendLine("VALUES (@_idCliente, @tpVeiculo, @modelo, @cor, @ano, @placa, @cidadePlaca, @ufPlaca); ");
                strSQL.AppendLine("SELECT @@IDENTITY;");

                newVeiculo.id = connection.Query<int>(strSQL.ToString(),
                    new {
                        newVeiculo._idCliente,
                        newVeiculo.tpVeiculo,
                        newVeiculo.modelo,
                        newVeiculo.ano,
                        newVeiculo.cor,
                        newVeiculo.placa,
                        newVeiculo.cidadePlaca,
                        newVeiculo.ufPlaca
                    }).First();

                return true;
            } catch (Exception ex) {
                return false;
            }
        }

        public List<Veiculo> read(Cliente cliente) {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                List<Veiculo> veiculos = connection.Query<Veiculo>("SELECT * FROM Veiculo WHERE idCliente = @id", new { cliente.id }).ToList();

                connection.Close();

                return veiculos;
            } catch (Exception ex) {
                return null;
            }
        }

        public List<Veiculo> read() {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                List<Veiculo> veiculos = connection.Query<Veiculo>("SELECT * FROM Veiculo").ToList();

                connection.Close();

                return veiculos;
            } catch (Exception ex) {
                return null;
            }
        }

        public Veiculo read(int idVeiculo) {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                Veiculo veiculo = connection.Query<Veiculo>("SELECT * FROM Veiculo WHERE id = @idVeiculo",
                    new {
                        idVeiculo
                    }).First();

                connection.Close();

                return veiculo;
            } catch (Exception ex) {
                return null;
            }
        }

        public bool update(Veiculo newVeiculo) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("UPDATE   Veiculo ");
                strSQL.AppendLine("SET      tpVeiculo = @tpVeiculo, ");
                strSQL.AppendLine("         modelo = @modelo, ");
                strSQL.AppendLine("         cor = @cor, ");
                strSQL.AppendLine("         ano = @ano, ");
                strSQL.AppendLine("         placa = @placa, ");
                strSQL.AppendLine("         cidadePlaca = @cidadePlaca, ");
                strSQL.AppendLine("         ufPlaca = @ufPlaca ");
                strSQL.AppendLine("WHERE    id = @id AND idCliente = @_idCliente");

                connection.Query(strSQL.ToString(), new {
                    newVeiculo.tpVeiculo,
                    newVeiculo.modelo,
                    newVeiculo.cor,
                    newVeiculo.ano,
                    newVeiculo.placa,
                    newVeiculo.cidadePlaca,
                    newVeiculo.ufPlaca,
                    newVeiculo.id,
                    newVeiculo._idCliente
                });
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(Veiculo veiculo) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("DELETE FROM Veiculo");
                strSQL.AppendLine("WHERE id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        veiculo.id
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(int idCliente) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("DELETE FROM Veiculo");
                strSQL.AppendLine("WHERE idCliente = @idCliente");

                connection.Query(strSQL.ToString(),
                    new {
                        idCliente
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }
        #endregion

    }
}