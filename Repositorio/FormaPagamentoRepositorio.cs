using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class FormaPagamentoRepositorio : Repositorio<FormaPagamento> {

        #region Implementação Singleton
        private static FormaPagamentoRepositorio instance = null;
        public static FormaPagamentoRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new FormaPagamentoRepositorio();
                }
                return instance;
            }
        }

        private FormaPagamentoRepositorio() {

        }
        #endregion

        #region Init
        public void createTable(SQLiteConnection connection) {
            StringBuilder strSQL;

            //Criação da tabela principal
            if (connection.GetSchema("Tables", new[] { null, null, "FormaPagamento", null }).Rows.Count == 0) {
                SQLiteCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE FormaPagamento (");
                strSQL.AppendLine(" id INTEGER PRIMARY KEY AUTOINCREMENT, ");
                strSQL.AppendLine(" descricao TEXT, ");
                strSQL.AppendLine(" numParcelas INTEGER, ");
                strSQL.AppendLine(" entrada INTEGER) ");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region CRUD
        public bool create(ref FormaPagamento formaPagamento) {
            StringBuilder strSQL = new StringBuilder();

            SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();

            try {
                // Cria o cliente
                strSQL = new StringBuilder();
                strSQL.AppendLine("INSERT INTO FormaPagamento (descricao, numParcelas, entrada) ");
                strSQL.AppendLine("VALUES (@descricao, @numParcelas, @entrada); ");
                strSQL.AppendLine("select last_insert_rowid();");

                formaPagamento.id = connection.Query<int>(strSQL.ToString(),
                    new {
                        formaPagamento.descricao,
                        formaPagamento.numParcelas,
                        formaPagamento.entrada
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public List<FormaPagamento> read() {
            try {
                SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();
                connection.Open();

                List<FormaPagamento> formaPagamentos = connection.Query<FormaPagamento>("SELECT * FROM FormaPagamento").ToList();

                connection.Close();

                return formaPagamentos;
            } catch (Exception ex) {
                return null;
            }
        }

        public FormaPagamento read(int id) {
            try {
                SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();
                connection.Open();

                FormaPagamento formaPagamento = connection.Query<FormaPagamento>("SELECT * FROM FormaPagamento WHERE id = @id", new { id }).First();

                connection.Close();

                return formaPagamento;
            } catch (Exception ex) {
                return null;
            }
        }

        public bool update(FormaPagamento formaPagamento) {
            StringBuilder strSQL = new StringBuilder();

            SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("UPDATE   FormaPagamento ");
                strSQL.AppendLine("SET      descricao = @descricao, ");
                strSQL.AppendLine("         numParcelas = @numParcelas, ");
                strSQL.AppendLine("         entrada = @entrada ");
                strSQL.AppendLine("WHERE    id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        formaPagamento.descricao,
                        formaPagamento.numParcelas,
                        formaPagamento.entrada,
                        formaPagamento.id
                    });
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(FormaPagamento formaPagamento) {
            StringBuilder strSQL = new StringBuilder();

            SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("DELETE FROM FormaPagamento");
                strSQL.AppendLine("WHERE id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        formaPagamento.id
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }
        #endregion

    }
}
