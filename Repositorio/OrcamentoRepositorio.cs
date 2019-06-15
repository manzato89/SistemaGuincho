using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class OrcamentoRepositorio : Repositorio<Orcamento> {

        #region Implementação Singleton
        private static OrcamentoRepositorio instance = null;
        public static OrcamentoRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new OrcamentoRepositorio();
                }
                return instance;
            }
        }

        private OrcamentoRepositorio() {

        }
        #endregion

        #region Init
        public void createTable(SqlConnection connection) {
            StringBuilder strSQL;

            //Criação da tabela principal
            if (connection.GetSchema("Tables", new[] { null, null, "Orcamento", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Orcamento (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" _idCliente INTEGER, ");
                strSQL.AppendLine(" fechado INTEGER, ");
                strSQL.AppendLine(" _idVeiculo INTEGER, ");
                strSQL.AppendLine(" dataCriacao DATETIME, ");
                strSQL.AppendLine(" dataEncerramento DATETIME, ");
                strSQL.AppendLine(" FOREIGN KEY (_idCliente) REFERENCES Cliente (id), ");
                strSQL.AppendLine(" FOREIGN KEY (_idVeiculo) REFERENCES Veiculo (id) )");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }

            // Criação das tabelas auxiliares
            OrcamentoServicoRepositorio.Instance.createTable(connection);
        }
        #endregion

        #region CRUD
        public bool create(ref Orcamento orcamento) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                // Cria o orçamento
                strSQL = new StringBuilder();
                strSQL.AppendLine("INSERT INTO Orcamento (_idCliente, fechado, _idVeiculo, dataCriacao, dataEncerramento) ");
                strSQL.AppendLine("VALUES (@_idCliente, @fechado, @_idVeiculo, @dataCriacao, @dataEncerramento); ");
                strSQL.AppendLine("SELECT @@IDENTITY;");

                orcamento.id = connection.Query<int>(strSQL.ToString(),
                    new {
                        orcamento._idCliente,
                        orcamento.fechado,
                        orcamento._idVeiculo,
                        orcamento.dataCriacao,
                        orcamento.dataEncerramento
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            // Cria os serviços
            for (int iCount = 0; iCount < orcamento.servicos.Count; iCount++) {
                Servico servico = orcamento.servicos[iCount];
                OrcamentoServicoRepositorio.Instance.criaServicosNoOrcamento(orcamento, ref servico, Servico.TipoServico.Servico);
                orcamento.servicos[iCount] = servico;
            }

            // Cria os custos adicionais
            for (int iCount = 0; iCount < orcamento.custosAdicionais.Count; iCount++) {
                Servico servico = orcamento.custosAdicionais[iCount];
                OrcamentoServicoRepositorio.Instance.criaServicosNoOrcamento(orcamento, ref servico, Servico.TipoServico.CustoAdicional);
                orcamento.custosAdicionais[iCount] = servico;
            }

            return true;
        }


        public List<Orcamento> read() {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                List<Orcamento> orcamentos = connection.Query<Orcamento>("SELECT * FROM Orcamento").ToList();
                foreach (Orcamento orcamento in orcamentos) {
                    orcamento.servicos = OrcamentoServicoRepositorio.Instance.getServicosPorOrcamento(orcamento.id, Servico.TipoServico.Servico);
                    orcamento.custosAdicionais = OrcamentoServicoRepositorio.Instance.getServicosPorOrcamento(orcamento.id, Servico.TipoServico.CustoAdicional);
                    orcamento.cliente = ClienteRepositorio.Instance.read(orcamento._idCliente);
                    orcamento.veiculo = VeiculoRepositorio.Instance.read(orcamento._idVeiculo);
                }

                connection.Close();

                return orcamentos;
            } catch (Exception ex) {
                return null;
            }
        }

        public List<Orcamento> read(String complementoWhere) {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                List<Orcamento> orcamentos = connection.Query<Orcamento>(String.Format("SELECT * FROM Orcamento WHERE 1 = 1 AND {0}", complementoWhere)).ToList();
                foreach (Orcamento orcamento in orcamentos) {
                    orcamento.servicos = OrcamentoServicoRepositorio.Instance.getServicosPorOrcamento(orcamento.id, Servico.TipoServico.Servico);
                    orcamento.custosAdicionais = OrcamentoServicoRepositorio.Instance.getServicosPorOrcamento(orcamento.id, Servico.TipoServico.CustoAdicional);
                    orcamento.cliente = ClienteRepositorio.Instance.read(orcamento._idCliente);
                    orcamento.veiculo = VeiculoRepositorio.Instance.read(orcamento._idVeiculo);
                }

                connection.Close();

                return orcamentos;
            } catch (Exception ex) {
                return null;
            }
        }

        public Orcamento read(int id) {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                Orcamento orcamento = connection.Query<Orcamento>("SELECT * FROM Orcamento WHERE id = @id", new { id }).First();
                orcamento.servicos = OrcamentoServicoRepositorio.Instance.getServicosPorOrcamento(orcamento.id, Servico.TipoServico.Servico);
                orcamento.custosAdicionais = OrcamentoServicoRepositorio.Instance.getServicosPorOrcamento(orcamento.id, Servico.TipoServico.CustoAdicional);
                orcamento.cliente = ClienteRepositorio.Instance.read(orcamento._idCliente);
                orcamento.veiculo = VeiculoRepositorio.Instance.read(orcamento._idVeiculo);

                connection.Close();

                return orcamento;
            } catch (Exception ex) {
                return null;
            }
        }

        public bool update(Orcamento orcamento) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("UPDATE   Orcamento ");
                strSQL.AppendLine("SET      _idCliente = @_idCliente, ");
                strSQL.AppendLine("         fechado = @fechado, ");
                strSQL.AppendLine("         _idVeiculo = @_idVeiculo, ");
                strSQL.AppendLine("         dataCriacao = @dataCriacao, ");
                strSQL.AppendLine("         dataEncerramento = @dataEncerramento ");
                strSQL.AppendLine("WHERE    id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        orcamento._idCliente,
                        orcamento.fechado,
                        orcamento._idVeiculo,
                        orcamento.dataCriacao,
                        orcamento.dataEncerramento,
                        orcamento.id
                    });
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(Orcamento orcamento) {
            //TODO
            return true;
        }

        public bool delete(int id) {
            //TODO
            return true;
        }
        #endregion

    }
}
