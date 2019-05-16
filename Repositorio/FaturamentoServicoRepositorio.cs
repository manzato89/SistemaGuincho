using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class FaturamentoServicoRepositorio {

        #region Implementação Singleton
        private static FaturamentoServicoRepositorio instance = null;
        public static FaturamentoServicoRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new FaturamentoServicoRepositorio();
                }
                return instance;
            }
        }

        private FaturamentoServicoRepositorio() {

        }
        #endregion

        public void createTable(SqlConnection connection) {
            StringBuilder strSQL;

            //Criação da tabela auxiliar
            if (connection.GetSchema("Tables", new[] { null, null, "Faturamento_Servicos", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Faturamento_Servicos (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" idFaturamento INTEGER, ");
                strSQL.AppendLine(" idServico INTEGER, ");
                strSQL.AppendLine(" valor REAL, ");
                strSQL.AppendLine(" quantidade INTEGER, ");
                strSQL.AppendLine(" FOREIGN KEY (idFaturamento) REFERENCES Faturamento (id), ");
                strSQL.AppendLine(" FOREIGN KEY (idServico) REFERENCES Servico (id) )");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }

            //Criação da tabela auxiliar
            if (connection.GetSchema("Tables", new[] { null, null, "Faturamento_CustosAdicionais", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Faturamento_CustosAdicionais (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" idFaturamento INTEGER, ");
                strSQL.AppendLine(" idServico INTEGER, ");
                strSQL.AppendLine(" valor REAL, ");
                strSQL.AppendLine(" quantidade INTEGER, ");
                strSQL.AppendLine(" FOREIGN KEY (idFaturamento) REFERENCES Faturamento (id), ");
                strSQL.AppendLine(" FOREIGN KEY (idServico) REFERENCES Servico (id) )");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }
        }

        public bool criaServicosNoFaturamento(Faturamento faturamento, ref Servico servico, Servico.TipoServico tpServico) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            String classe = "";
            if (tpServico == Servico.TipoServico.Servico)
                classe = "Faturamento_Servicos";
            else if (tpServico == Servico.TipoServico.CustoAdicional)
                classe = "Faturamento_CustosAdicionais";

            try {
                // Cria o serviço pro orçamento
                strSQL = new StringBuilder();
                strSQL.AppendLine(String.Format("INSERT INTO {0} (idFaturamento, idServico, valor, quantidade) ", classe));
                strSQL.AppendLine("VALUES (@idFaturamento, @idServico, @valor, @quantidade); ");
                strSQL.AppendLine("SELECT @@IDENTITY;");

                int idFaturamento = faturamento.id;
                int idServico = servico.id;
                int quantidade = servico._quantidade;

                servico._idServicoOrcFat = connection.Query<int>(strSQL.ToString(),
                    new {
                        idFaturamento,
                        idServico,
                        servico.valor,
                        quantidade
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public List<Servico> getServicosPorFaturamento(int idFaturamento, Servico.TipoServico tpServico) {
            String classe = "";
            if (tpServico == Servico.TipoServico.Servico)
                classe = "Faturamento_Servicos";
            else if (tpServico == Servico.TipoServico.CustoAdicional)
                classe = "Faturamento_CustosAdicionais";

            try {
                List<Servico> servicos = new List<Servico>();

                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = String.Format("SELECT * FROM {0} WHERE idFaturamento = {1}", classe, idFaturamento);

                SqlDataReader drServicos = command.ExecuteReader();
                while (drServicos.Read()) {
                    // Pega o ID e cria o serviço com base nele
                    int idServico = -1;
                    int.TryParse(drServicos["idServico"].ToString(), out idServico);
                    Servico servico = ServicoRepositorio.Instance.read(idServico);

                    // Busca quantidade
                    int quantidade = -1;
                    int.TryParse(drServicos["quantidade"].ToString(), out quantidade);
                    servico._quantidade = quantidade;

                    // Busca valor
                    float valor = -1;
                    float.TryParse(drServicos["valor"].ToString(), out valor);
                    servico.valor = valor;

                    // Busca id do serviço/custoadicional nos orçamentos
                    int _idServicoOrcFat = -1;
                    int.TryParse(drServicos["id"].ToString(), out _idServicoOrcFat);
                    servico._idServicoOrcFat = _idServicoOrcFat;
                    
                    servicos.Add(servico);
                }

                connection.Close();

                return servicos;
            } catch (Exception ex) {
                return null;
            }
        }

        public bool update(Servico servico, Servico.TipoServico tpServico) {
            String classe = "";
            if (tpServico == Servico.TipoServico.Servico)
                classe = "Faturamento_Servicos";
            else if (tpServico == Servico.TipoServico.CustoAdicional)
                classe = "Faturamento_CustosAdicionais";

            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            int idServicoOrcFat = servico._idServicoOrcFat;

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine(String.Format("UPDATE   {0} ", classe));
                strSQL.AppendLine("SET      valor = @valor, ");
                strSQL.AppendLine("         quantidade = @_quantidade ");
                strSQL.AppendLine("WHERE    id = @idServicoOrcFat");

                connection.Query(strSQL.ToString(),
                    new {
                        servico.valor,
                        servico._quantidade,
                        idServicoOrcFat
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(Servico servico, Servico.TipoServico tpServico) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            String classe = "";
            if (tpServico == Servico.TipoServico.Servico)
                classe = "Faturamento_Servicos";
            else if (tpServico == Servico.TipoServico.CustoAdicional)
                classe = "Faturamento_CustosAdicionais";

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine(String.Format("DELETE FROM {0}", classe));
                strSQL.AppendLine("WHERE id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        servico._idServicoOrcFat
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

    }
}
