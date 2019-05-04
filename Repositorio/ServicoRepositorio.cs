using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class ServicoRepositorio : Repositorio<Servico> {

        #region Implementação Singleton
        private static ServicoRepositorio instance = null;
        public static ServicoRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new ServicoRepositorio();
                }
                return instance;
            }
        }

        private ServicoRepositorio() {

        }
        #endregion

        #region Init
        public void createTable(SQLiteConnection connection) {
            StringBuilder strSQL;

            //Criação da tabela principal
            if (connection.GetSchema("Tables", new[] { null, null, "Servico", null }).Rows.Count == 0) {
                SQLiteCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Servico (");
                strSQL.AppendLine(" id INTEGER PRIMARY KEY AUTOINCREMENT, ");
                strSQL.AppendLine(" descricao TEXT, ");
                strSQL.AppendLine(" _idUnidade INTEGER, ");
                strSQL.AppendLine(" valor REAL) ");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region CRUD
        public bool create(ref Servico servico) {
            StringBuilder strSQL = new StringBuilder();

            SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();

            try {
                // Cria o cliente
                strSQL = new StringBuilder();
                strSQL.AppendLine("INSERT INTO Servico (descricao, _idUnidade, valor) ");
                strSQL.AppendLine("VALUES (@descricao, @_idUnidade, @valor); ");
                strSQL.AppendLine("select last_insert_rowid();");

                int _idUnidade = servico.unidade.id;

                servico.id = connection.Query<int>(strSQL.ToString(),
                    new {
                        servico.descricao,
                        _idUnidade,
                        servico.valor
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public List<Servico> read(){
            try {
                SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();
                connection.Open();

                List<Servico> servicos = connection.Query<Servico>("SELECT * FROM Servico").ToList();
                foreach(Servico servico in servicos) {
                    servico.unidade = UnidadeRepositorio.Instance.read(servico._idUnidade);
                }

                connection.Close();

                return servicos;
            } catch (Exception ex) {
                return null;
            }
        }

        public Servico read(int id) {
            try {
                SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();
                connection.Open();

                Servico servico = connection.Query<Servico>("SELECT * FROM Servico WHERE id = @id", new { id }).First();
                servico.unidade = UnidadeRepositorio.Instance.read(servico._idUnidade);

                connection.Close();

                return servico;
            } catch (Exception ex) {
                return null;
            }
        }

        public bool update(Servico servico) {
            StringBuilder strSQL = new StringBuilder();

            SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("UPDATE   Servico ");
                strSQL.AppendLine("SET      descricao = @descricao, ");
                strSQL.AppendLine("         _idUnidade = @_idUnidade, ");
                strSQL.AppendLine("         valor = @valor ");
                strSQL.AppendLine("WHERE    id = @id");

                int _idUnidade = servico.unidade.id;

                connection.Query(strSQL.ToString(),
                    new {
                        servico.descricao,
                        _idUnidade,
                        servico.valor,
                        servico.id
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(Servico servico) {
            StringBuilder strSQL = new StringBuilder();

            SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("DELETE FROM Servico");
                strSQL.AppendLine("WHERE id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        servico.id
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }
        #endregion

    }
}
