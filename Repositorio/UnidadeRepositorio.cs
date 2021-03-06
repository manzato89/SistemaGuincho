﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class UnidadeRepositorio : Repositorio<Unidade> {

        #region Implementação Singleton
        private static UnidadeRepositorio instance = null;
        public static UnidadeRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new UnidadeRepositorio();
                }
                return instance;
            }
        }

        private UnidadeRepositorio() {

        }
        #endregion

        #region Init
        public void createTable(SqlConnection connection) {
            StringBuilder strSQL;

            //Criação da tabela principal
            if (connection.GetSchema("Tables", new[] { null, null, "Unidade", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Unidade (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" codigo TEXT, ");
                strSQL.AppendLine(" descricao TEXT) ");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region CRUD
        public bool create(ref Unidade unidade) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                // Cria o cliente
                strSQL = new StringBuilder();
                strSQL.AppendLine("INSERT INTO Unidade (codigo, descricao) ");
                strSQL.AppendLine("VALUES (@codigo, @descricao); ");
                strSQL.AppendLine("SELECT @@IDENTITY;");

                unidade.id = connection.Query<int>(strSQL.ToString(),
                    new {
                        unidade.codigo,
                        unidade.descricao
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public List<Unidade> read() {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                List<Unidade> unidades = connection.Query<Unidade>("SELECT * FROM Unidade").ToList();

                connection.Close();

                return unidades;
            } catch (Exception ex) {
                return null;
            }
        }

        public Unidade read(int id) {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                Unidade unidade = connection.Query<Unidade>("SELECT * FROM Unidade WHERE id = @id", new { id }).First();

                connection.Close();

                return unidade;
            } catch (Exception ex) {
                return null;
            }
        }

        public bool update(Unidade unidade) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("UPDATE   Unidade ");
                strSQL.AppendLine("SET      codigo = @codigo, ");
                strSQL.AppendLine("         descricao = @descricao ");
                strSQL.AppendLine("WHERE    id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        unidade.codigo,
                        unidade.descricao,
                        unidade.id
                    });
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(Unidade unidade) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("DELETE FROM Unidade");
                strSQL.AppendLine("WHERE id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        unidade.id
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }
        #endregion

    }
}
