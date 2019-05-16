using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class OrcamentoServicoRepositorio {

        #region Implementação Singleton
        private static OrcamentoServicoRepositorio instance = null;
        public static OrcamentoServicoRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new OrcamentoServicoRepositorio();
                }
                return instance;
            }
        }

        private OrcamentoServicoRepositorio() {

        }
        #endregion

        public void createTable(SqlConnection connection) {
            StringBuilder strSQL;

            //Criação da tabela auxiliar
            if (connection.GetSchema("Tables", new[] { null, null, "Orcamento_Servicos", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Orcamento_Servicos (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" idOrcamento INTEGER, ");
                strSQL.AppendLine(" idServico INTEGER, ");
                strSQL.AppendLine(" valor REAL, ");
                strSQL.AppendLine(" quantidade INTEGER, ");
                strSQL.AppendLine(" FOREIGN KEY (idOrcamento) REFERENCES Orcamento (id), ");
                strSQL.AppendLine(" FOREIGN KEY (idServico) REFERENCES Servico (id) )");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }

            //Criação da tabela auxiliar
            if (connection.GetSchema("Tables", new[] { null, null, "Orcamento_CustosAdicionais", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Orcamento_CustosAdicionais (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" idOrcamento INTEGER, ");
                strSQL.AppendLine(" idServico INTEGER, ");
                strSQL.AppendLine(" valor REAL, ");
                strSQL.AppendLine(" quantidade INTEGER, ");
                strSQL.AppendLine(" FOREIGN KEY (idOrcamento) REFERENCES Orcamento (id), ");
                strSQL.AppendLine(" FOREIGN KEY (idServico) REFERENCES Servico (id) )");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }
        }

        public bool criaServicosNoOrcamento(Orcamento orcamento, ref Servico servico, Servico.TipoServico tpServico) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            String classe = "";
            if (tpServico == Servico.TipoServico.Servico)
                classe = "Orcamento_Servicos";
            else if (tpServico == Servico.TipoServico.CustoAdicional)
                classe = "Orcamento_CustosAdicionais";

            try {
                // Cria o serviço pro orçamento
                strSQL = new StringBuilder();
                strSQL.AppendLine(String.Format("INSERT INTO {0} (idOrcamento, idServico, valor, quantidade) ", classe));
                strSQL.AppendLine("VALUES (@idOrcamento, @idServico, @valor, @quantidade); ");
                strSQL.AppendLine("SELECT @@IDENTITY;");

                int idOrcamento = orcamento.id;
                int idServico = servico.id;
                int quantidade = servico._quantidade;

                servico._idServicoOrcFat = connection.Query<int>(strSQL.ToString(),
                    new {
                        idOrcamento,
                        idServico,
                        servico.valor,
                        quantidade
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public List<Servico> getServicosPorOrcamento(int idOrcamento, Servico.TipoServico tpServico) {
            String classe = "";
            if (tpServico == Servico.TipoServico.Servico)
                classe = "Orcamento_Servicos";
            else if (tpServico == Servico.TipoServico.CustoAdicional)
                classe = "Orcamento_CustosAdicionais";

            try {
                List<Servico> servicos = new List<Servico>();

                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = String.Format("SELECT * FROM {0} WHERE idOrcamento = {1}", classe, idOrcamento);

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
                    int _idServicoOrcamento = -1;
                    int.TryParse(drServicos["id"].ToString(), out _idServicoOrcamento);
                    servico._idServicoOrcFat = _idServicoOrcamento;
                    
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
                classe = "Orcamento_Servicos";
            else if (tpServico == Servico.TipoServico.CustoAdicional)
                classe = "Orcamento_CustosAdicionais";

            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            int idServicoOrcamento = servico._idServicoOrcFat;

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine(String.Format("UPDATE   {0} ", classe));
                strSQL.AppendLine("SET      valor = @valor, ");
                strSQL.AppendLine("         quantidade = @_quantidade ");
                strSQL.AppendLine("WHERE    id = @idServicoOrcamento");

                connection.Query(strSQL.ToString(),
                    new {
                        servico.valor,
                        servico._quantidade,
                        idServicoOrcamento
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

    }
}
