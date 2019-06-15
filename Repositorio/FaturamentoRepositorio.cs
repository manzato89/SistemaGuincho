using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaGuincho.Model;
using SistemaGuincho.Utilidades;

namespace SistemaGuincho.Repositorio {
    public class FaturamentoRepositorio : Repositorio<Faturamento> {

        #region Implementação Singleton
        private static FaturamentoRepositorio instance = null;
        public static FaturamentoRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new FaturamentoRepositorio();
                }
                return instance;
            }
        }

        private FaturamentoRepositorio() {

        }
        #endregion

        #region Init
        public void createTable(SqlConnection connection) {
            StringBuilder strSQL;

            FormaPagamentoRepositorio.Instance.createTable(connection);

            //Criação da tabela principal
            if (connection.GetSchema("Tables", new[] { null, null, "Faturamento", null }).Rows.Count == 0) {
                SqlCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Faturamento (");
                strSQL.AppendLine(" id INT NOT NULL IDENTITY PRIMARY KEY, ");
                strSQL.AppendLine(" numOrcamento INTEGER, ");
                strSQL.AppendLine(" _idCliente INTEGER, ");
                strSQL.AppendLine(" _idFormaPagamento INTEGER, ");
                strSQL.AppendLine(" fechado INTEGER, ");
                strSQL.AppendLine(" _idVeiculo INTEGER, ");
                strSQL.AppendLine(" dataCriacao DATETIME, ");
                strSQL.AppendLine(" dataEncerramento DATETIME, ");
                strSQL.AppendLine(" FOREIGN KEY (_idCliente) REFERENCES Cliente (id), ");
                strSQL.AppendLine(" FOREIGN KEY (_idFormaPagamento) REFERENCES FormaPagamento (id), ");
                strSQL.AppendLine(" FOREIGN KEY (_idVeiculo) REFERENCES Veiculo (id) )");

                command.CommandText = strSQL.ToString();
                command.ExecuteNonQuery();
            }

            // Criação das tabelas auxiliares
            FaturamentoServicoRepositorio.Instance.createTable(connection);
        }

        #endregion

        #region CRUD
        public bool create(ref Faturamento faturamento) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            try {
                // Cria o orçamento
                strSQL = new StringBuilder();
                strSQL.AppendLine("INSERT INTO Faturamento (numOrcamento,   _idCliente,     _idFormaPagamento,  fechado,    _idVeiculo,     dataCriacao,    dataEncerramento) ");
                strSQL.AppendLine("VALUES (                 @numOrcamento,  @_idCliente,    @_idFormaPagamento, @fechado,   @_idVeiculo,    @dataCriacao,   @dataEncerramento); ");
                strSQL.AppendLine("SELECT @@IDENTITY;");

                faturamento.id = connection.Query<int>(strSQL.ToString(),
                    new {
                        faturamento.numOrcamento,
                        faturamento._idCliente,
                        faturamento._idFormaPagamento,
                        faturamento.fechado,
                        faturamento._idVeiculo,
                        faturamento.dataCriacao,
                        faturamento.dataEncerramento
                    }).First();
            } catch (Exception ex) {
                return false;
            }

            // Cria os serviços
            for (int iCount = 0; iCount < faturamento.servicos.Count; iCount++) {
                Servico servico = faturamento.servicos[iCount];
                FaturamentoServicoRepositorio.Instance.criaServicosNoFaturamento(faturamento, ref servico, Servico.TipoServico.Servico);
                faturamento.servicos[iCount] = servico;
            }

            // Cria os custos adicionais
            for (int iCount = 0; iCount < faturamento.custosAdicionais.Count; iCount++) {
                Servico servico = faturamento.custosAdicionais[iCount];
                FaturamentoServicoRepositorio.Instance.criaServicosNoFaturamento(faturamento, ref servico, Servico.TipoServico.CustoAdicional);
                faturamento.custosAdicionais[iCount] = servico;
            }

            return true;
        }

        public List<Faturamento> read() {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                List<Faturamento> faturamentos = connection.Query<Faturamento>("SELECT * FROM Faturamento").ToList();
                foreach (Faturamento faturamento in faturamentos) {
                    faturamento.servicos = FaturamentoServicoRepositorio.Instance.getServicosPorFaturamento(faturamento.id, Servico.TipoServico.Servico);
                    faturamento.custosAdicionais = FaturamentoServicoRepositorio.Instance.getServicosPorFaturamento(faturamento.id, Servico.TipoServico.CustoAdicional);
                    faturamento.cliente = ClienteRepositorio.Instance.read(faturamento._idCliente);
                    faturamento.veiculo = VeiculoRepositorio.Instance.read(faturamento._idVeiculo);
                    faturamento.formaPagamento = FormaPagamentoRepositorio.Instance.read(faturamento._idFormaPagamento);
                }

                connection.Close();

                return faturamentos;
            } catch (Exception ex) {
                return null;
            }
        }

        public List<Faturamento> read(String complementoWhere) {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                List<Faturamento> faturamentos = connection.Query<Faturamento>(String.Format("SELECT * FROM Faturamento WHERE 1 = 1 AND {0}", complementoWhere)).ToList();
                foreach (Faturamento faturamento in faturamentos) {
                    faturamento.servicos = FaturamentoServicoRepositorio.Instance.getServicosPorFaturamento(faturamento.id, Servico.TipoServico.Servico);
                    faturamento.custosAdicionais = FaturamentoServicoRepositorio.Instance.getServicosPorFaturamento(faturamento.id, Servico.TipoServico.CustoAdicional);
                    faturamento.cliente = ClienteRepositorio.Instance.read(faturamento._idCliente);
                    faturamento.veiculo = VeiculoRepositorio.Instance.read(faturamento._idVeiculo);
                    faturamento.formaPagamento = FormaPagamentoRepositorio.Instance.read(faturamento._idFormaPagamento);
                }

                connection.Close();

                return faturamentos;
            } catch (Exception ex) {
                return null;
            }
        }

        public Faturamento read(int id) {
            try {
                SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
                connection.Open();

                Faturamento faturamento = connection.Query<Faturamento>("SELECT * FROM Faturamento WHERE id = @id", new { id }).First();
                faturamento.servicos = FaturamentoServicoRepositorio.Instance.getServicosPorFaturamento(faturamento.id, Servico.TipoServico.Servico);
                faturamento.custosAdicionais = FaturamentoServicoRepositorio.Instance.getServicosPorFaturamento(faturamento.id, Servico.TipoServico.CustoAdicional);
                faturamento.cliente = ClienteRepositorio.Instance.read(faturamento._idCliente);
                faturamento.veiculo = VeiculoRepositorio.Instance.read(faturamento._idVeiculo);
                faturamento.formaPagamento = FormaPagamentoRepositorio.Instance.read(faturamento._idFormaPagamento);

                connection.Close();

                return faturamento;
            } catch (Exception ex) {
                return null;
            }
        }

        public bool update(Faturamento faturamento) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            //@numOrcamento,  @_idCliente,    @_idFormaPagamento, @fechado,   @_idVeiculo,    @dataCriacao,   @dataEncerramento); ");

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("UPDATE   Faturamento ");
                strSQL.AppendLine("SET      numOrcamento = @numOrcamento, ");
                strSQL.AppendLine("         _idCliente = @_idCliente, ");
                strSQL.AppendLine("         _idFormaPagamento = @_idFormaPagamento, ");
                strSQL.AppendLine("         fechado = @fechado, ");
                strSQL.AppendLine("         _idVeiculo = @_idVeiculo, ");
                strSQL.AppendLine("         dataCriacao = @dataCriacao, ");
                strSQL.AppendLine("         dataEncerramento = @dataEncerramento ");
                strSQL.AppendLine("WHERE    id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        faturamento.numOrcamento,
                        faturamento._idCliente,
                        faturamento._idFormaPagamento,
                        faturamento.fechado,
                        faturamento._idVeiculo,
                        faturamento.dataCriacao,
                        faturamento.dataEncerramento,
                        faturamento.id
                    });
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(Faturamento faturamento) {
            StringBuilder strSQL = new StringBuilder();

            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();

            foreach(Servico servico in faturamento.servicos)
                FaturamentoServicoRepositorio.Instance.delete(servico, Servico.TipoServico.Servico);

            foreach (Servico custoAdicional in faturamento.custosAdicionais)
                FaturamentoServicoRepositorio.Instance.delete(custoAdicional, Servico.TipoServico.CustoAdicional);

            try {
                strSQL = new StringBuilder();
                strSQL.AppendLine("DELETE FROM Faturamento");
                strSQL.AppendLine("WHERE id = @id");

                connection.Query(strSQL.ToString(),
                    new {
                        faturamento.id
                    });
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public bool delete(int id) {
            // TIDI
            return true;
        }
        #endregion

        #region Relatórios
        public List<int> reportFaturamento(Relatorios.Faturamento_OrcamentoFiltroRelatorio faturamentoFiltroRelatorio) {
            String classePrincipal = "";
            String campoRelacionamentoClasses = "";
            String classeServico = "";
            String classeCustoAdicional = "";

            switch (faturamentoFiltroRelatorio.tpRelatorio) {
                case Relatorios.Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Orcamento:
                    classePrincipal = "Orcamento";
                    campoRelacionamentoClasses = "idOrcamento";
                    classeServico = "Orcamento_Servicos";
                    classeCustoAdicional = "Orcamento_CustosAdicionais";
                    break;
                case Relatorios.Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Faturamento:
                    classePrincipal = "Faturamento";
                    campoRelacionamentoClasses = "idFaturamento";
                    classeServico = "Faturamento_Servicos";
                    classeCustoAdicional = "Faturamento_CustosAdicionais";
                    break;
            }

            StringBuilder strSQLWhere = new StringBuilder();
            strSQLWhere.Append(" 1 = 1\n");

            if (faturamentoFiltroRelatorio.apenasFechados) {
                strSQLWhere.AppendFormat(" AND FaturamentoOrcamento.fechado = 1\n");
            }

            if (faturamentoFiltroRelatorio.dtCriacaoInicio != null && faturamentoFiltroRelatorio.dtCriacaoFim != null) {
                faturamentoFiltroRelatorio.dtCriacaoFim = faturamentoFiltroRelatorio.dtCriacaoFim.Value.AddHours(23).AddMinutes(59);
                strSQLWhere.AppendFormat(" AND FaturamentoOrcamento.dataCriacao BETWEEN '{0}' AND '{1}'\n", Util.dateTimeToSQLDateTimeFormat(faturamentoFiltroRelatorio.dtCriacaoInicio.Value), Util.dateTimeToSQLDateTimeFormat(faturamentoFiltroRelatorio.dtCriacaoFim.Value));
            }

            if (faturamentoFiltroRelatorio.dtEncerramentoInicio != null && faturamentoFiltroRelatorio.dtEncerramentoFim != null) {
                faturamentoFiltroRelatorio.dtEncerramentoFim = faturamentoFiltroRelatorio.dtEncerramentoFim.Value.AddHours(23).AddMinutes(59);
                strSQLWhere.AppendFormat(" AND FaturamentoOrcamento.dataEncerramento BETWEEN '{0}' AND '{1}'\n", Util.dateTimeToSQLDateTimeFormat(faturamentoFiltroRelatorio.dtEncerramentoInicio.Value), Util.dateTimeToSQLDateTimeFormat(faturamentoFiltroRelatorio.dtEncerramentoFim.Value));
            }

            if (faturamentoFiltroRelatorio.servicosSelecionados != null && faturamentoFiltroRelatorio.servicosSelecionados.Count > 0) {
                strSQLWhere.Append("AND (");

                int iCount = 0;
                Servico servico;
                for (; iCount < faturamentoFiltroRelatorio.servicosSelecionados.Count - 1; iCount++) {
                    servico = faturamentoFiltroRelatorio.servicosSelecionados[iCount];
                    strSQLWhere.AppendFormat(" FO_Servico.idServico = {0} OR ", servico.id);
                }
                servico = faturamentoFiltroRelatorio.servicosSelecionados[iCount];
                strSQLWhere.AppendFormat(" FO_Servico.idServico = {0}", servico.id);

                strSQLWhere.Append(")\n");
            }

            if (faturamentoFiltroRelatorio.custosAdicionaisSelecionados != null && faturamentoFiltroRelatorio.custosAdicionaisSelecionados.Count > 0) {
                strSQLWhere.Append("AND (");

                int iCount = 0;
                Servico custoAdicional;
                for (; iCount < faturamentoFiltroRelatorio.custosAdicionaisSelecionados.Count - 1; iCount++) {
                    custoAdicional = faturamentoFiltroRelatorio.custosAdicionaisSelecionados[iCount];
                    strSQLWhere.AppendFormat(" FO_CustoAdicional.idServico = {0} OR ", custoAdicional.id);
                }
                custoAdicional = faturamentoFiltroRelatorio.custosAdicionaisSelecionados[iCount];
                strSQLWhere.AppendFormat(" FO_CustoAdicional.idServico = {0} ", custoAdicional.id);

                strSQLWhere.Append(")\n");
            }

            if (faturamentoFiltroRelatorio.clientesSelecionados != null && faturamentoFiltroRelatorio.clientesSelecionados.Count > 0) {
                strSQLWhere.Append("AND (");

                int iCount = 0;
                Cliente cliente;
                for (; iCount < faturamentoFiltroRelatorio.clientesSelecionados.Count - 1; iCount++) {
                    cliente = faturamentoFiltroRelatorio.clientesSelecionados[iCount];
                    strSQLWhere.AppendFormat(" FaturamentoOrcamento._idCliente = {0} OR ", cliente.id);
                }
                cliente = faturamentoFiltroRelatorio.clientesSelecionados[iCount];
                strSQLWhere.AppendFormat(" FaturamentoOrcamento._idCliente = {0} ", cliente.id);

                strSQLWhere.Append(")\n");
            }

            if (faturamentoFiltroRelatorio.tpRelatorio == Relatorios.Faturamento_OrcamentoFiltroRelatorio.TipoRelatorio.Faturamento) {
                if (faturamentoFiltroRelatorio.formasPagamentoSelecionadas != null && faturamentoFiltroRelatorio.formasPagamentoSelecionadas.Count > 0) {
                    strSQLWhere.Append("AND (");

                    int iCount = 0;
                    FormaPagamento formaPagamento;
                    for (; iCount < faturamentoFiltroRelatorio.clientesSelecionados.Count - 1; iCount++) {
                        formaPagamento = faturamentoFiltroRelatorio.formasPagamentoSelecionadas[iCount];
                        strSQLWhere.AppendFormat(" FaturamentoOrcamento._idFormaPagamento = {0} OR ", formaPagamento.id);
                    }
                    formaPagamento = faturamentoFiltroRelatorio.formasPagamentoSelecionadas[iCount];
                    strSQLWhere.AppendFormat(" FaturamentoOrcamento._idFormaPagamento = {0} ", formaPagamento.id);

                    strSQLWhere.Append(")\n");
                }
            }

            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("SELECT FaturamentoOrcamento.id \n");
            strSQL.AppendFormat("FROM   {0} AS FaturamentoOrcamento \n", classePrincipal);
            strSQL.AppendFormat("       LEFT JOIN {0} AS FO_Servico ON FaturamentoOrcamento.id = FO_Servico.{1} \n", classeServico, campoRelacionamentoClasses);
            strSQL.AppendFormat("       LEFT JOIN {0} AS FO_CustoAdicional ON FaturamentoOrcamento.id = FO_CustoAdicional.{1} \n", classeCustoAdicional, campoRelacionamentoClasses);
            strSQL.AppendFormat("WHERE {0}", strSQLWhere.ToString());


            SqlConnection connection = SQLServerDatabase.Instance.SQLServerDatabaseConnection();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = strSQL.ToString();

            SqlDataReader reader = command.ExecuteReader();
            List<int> registros = new List<int>();
            while (reader.Read()) {
                int idOrcamento = -1;
                int.TryParse(reader["id"].ToString(), out idOrcamento);

                registros.Add(idOrcamento);
            }

            connection.Close();

            return registros;
        }
        #endregion

    }
}
