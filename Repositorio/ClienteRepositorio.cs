using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class ClienteRepositorio : Repositorio<Cliente> {

        #region Implementação Singleton
        private static ClienteRepositorio instance = null;
        public static ClienteRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new ClienteRepositorio();
                }
                return instance;
            }
        }

        private ClienteRepositorio() {

        }
        #endregion

        #region Init
        public void createTable(SqlConnection connection) {
            StringBuilder strSQL;

            // Criação da tabela auxiliar Endereço - É necessário criá-la primeiro pois a tabela Cliente a referencia
            if (connection.GetSchema("Tables", new[] { null, null, "Endereco", null }).Rows.Count == 0) {
                EnderecoRepositorio.Instance.createTable(connection);
            }

            //Criação da tabela principal
            if (connection.GetSchema("Tables", new[] { null, null, "Cliente", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Cliente (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" nome NVARCHAR(50), ");
                strSQL.AppendLine(" cpf NVARCHAR(11), ");
                strSQL.AppendLine(" rg NVARCHAR(15), ");
                strSQL.AppendLine(" _idEndereco INTEGER, ");
                strSQL.AppendLine(" dataNascimento DateTime, ");
                strSQL.AppendLine(" email NVARCHAR(100), ");
                strSQL.AppendLine(" fone1 NVARCHAR(20), ");
                strSQL.AppendLine(" fone2 NVARCHAR(20), ");
                strSQL.AppendLine(" FOREIGN KEY (_idEndereco) REFERENCES Endereco (id) )");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region CRUD
        public bool create(ref Cliente cliente) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();;

            // Cria o endereço
            Endereco clienteEndereco = cliente.endereco;
            EnderecoRepositorio.Instance.create(ref clienteEndereco);
            cliente.endereco = clienteEndereco;

            try {
                // Cria o cliente
                strSQL = new StringBuilder();
                strSQL.AppendLine("INSERT INTO Cliente (nome, cpf, rg, _idEndereco, dataNascimento, email, fone1, fone2) ");
                strSQL.AppendLine("VALUES (@nome, @cpf, @rg, @_idEndereco, @dataNascimento, @email, @fone1, @fone2); ");
                strSQL.AppendLine("SELECT @@IDENTITY;");

                int _idEndereco = cliente.endereco.id;

                cliente.id = connection.Query<int>(strSQL.ToString(),
                    new {
                        cliente.nome,
                        cliente.cpf,
                        cliente.rg,
                        _idEndereco,
                        cliente.dataNascimento,
                        cliente.email,
                        cliente.fone1,
                        cliente.fone2
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            // Cria os veículos
            for (int iCount = 0; iCount < cliente.veiculos.Count; iCount++) {
                Veiculo veiculo = cliente.veiculos[iCount];
                VeiculoRepositorio.Instance.create(ref veiculo);
                cliente.veiculos[iCount] = veiculo;
            }

            return true;
        }

        public List<Cliente> read(){
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();;
                connection.Open();

                List<Cliente> clientes = connection.Query<Cliente>("SELECT * FROM Cliente").ToList();
                foreach(Cliente cliente in clientes) {
                    cliente.endereco = EnderecoRepositorio.Instance.read(cliente._idEndereco);
                    cliente.veiculos = VeiculoRepositorio.Instance.read(cliente);
                }

                connection.Close();

                return clientes;
            } catch (Exception ex) {
                return null;
            }
        }
        
        public Cliente read(int id) {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();;
                connection.Open();

                Cliente cliente = connection.Query<Cliente>("SELECT * FROM Cliente WHERE id = @id", new { id }).First();
                cliente.endereco = EnderecoRepositorio.Instance.read(cliente._idEndereco);
                cliente.veiculos = VeiculoRepositorio.Instance.read(cliente);

                connection.Close();

                return cliente;
            } catch (Exception ex) {
                return null;
            }
        }
        
        public bool update(Cliente cliente) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();;

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("UPDATE   Cliente ");
                strSQL.AppendLine("SET      nome = @nome, ");
                strSQL.AppendLine("         cpf = @cpf, ");
                strSQL.AppendLine("         rg = @rg, ");
                strSQL.AppendLine("         _idEndereco = @_idEndereco, ");
                strSQL.AppendLine("         dataNascimento = @dataNascimento, ");
                strSQL.AppendLine("         email = @email, ");
                strSQL.AppendLine("         fone1 = @fone1, ");
                strSQL.AppendLine("         fone2 = @fone2, ");
                strSQL.AppendLine("         email = @email ");
                strSQL.AppendLine("WHERE    id = @id");

                int _idEndereco = cliente.endereco.id;

                connection.Query(strSQL.ToString(),
                    new {
                        cliente.nome,
                        cliente.cpf,
                        cliente.rg,
                        _idEndereco,
                        cliente.dataNascimento,
                        cliente.email,
                        cliente.fone1,
                        cliente.fone2,
                        cliente.id
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            // Atualiza o endereço
            EnderecoRepositorio.Instance.update(cliente.endereco);

            // Atualiza os veículos
            foreach(Veiculo veiculo in cliente.veiculos) {
                VeiculoRepositorio.Instance.update(veiculo);
            }

            return true;
        }
        
        public bool delete(Cliente cliente) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();;

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("DELETE FROM Cliente");
                strSQL.AppendLine("WHERE id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        cliente.id
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            // Deleta o endereço
            EnderecoRepositorio.Instance.delete(cliente.endereco);

            // Deleta os veículos
            VeiculoRepositorio.Instance.delete(cliente.id);

            return true;
        }
        #endregion

    }
}