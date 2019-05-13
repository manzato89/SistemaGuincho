using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaGuincho.Model;

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
        public void createTable(SQLiteConnection connection) {
            StringBuilder strSQL;

            FormaPagamentoRepositorio.Instance.createTable(connection);

            //Criação da tabela principal
            if (connection.GetSchema("Tables", new[] { null, null, "Faturamento", null }).Rows.Count == 0) {
                SQLiteCommand command = connection.CreateCommand();

                strSQL = new StringBuilder();
                strSQL.AppendLine("CREATE TABLE Faturamento (");
                strSQL.AppendLine(" id INTEGER PRIMARY KEY AUTOINCREMENT, ");
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

            SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();

            try {
                // Cria o orçamento
                strSQL = new StringBuilder();
                strSQL.AppendLine("INSERT INTO Faturamento (numOrcamento,   _idCliente,     _idFormaPagamento,  fechado,    _idVeiculo,     dataCriacao,    dataEncerramento) ");
                strSQL.AppendLine("VALUES (                 @numOrcamento,  @_idCliente,    @_idFormaPagamento, @fechado,   @_idVeiculo,    @dataCriacao,   @dataEncerramento); ");
                strSQL.AppendLine("select last_insert_rowid();");

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
                SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();
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
                SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();
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
                SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();
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

            SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();

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

            SQLiteConnection connection = SQLiteDatabase.SQLiteDatabaseConnection();

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
                    }).First();
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

    }
}
