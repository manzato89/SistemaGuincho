using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Servicos {
    public static class FaturamentoServicos {

        #region Funcionalidades específicas
        public static bool fechaFaturamento(ref Faturamento faturamento) { String mensagemVazia = ""; return fechaFaturamento(ref faturamento, ref mensagemVazia); }

        public static bool fechaFaturamento(ref Faturamento faturamento, ref String mensagemRetorno) {
            // Verifica se foi selecionado um veículo
            if (faturamento.veiculo == null) {
                mensagemRetorno = "Deve ser selecionado um veículo";

                return false;
            }

            // Verifica se o valor do orçamento é maior que 0
            if (faturamento.valorTotal() <= 0) {
                mensagemRetorno = "O valor está zerado";

                return false;
            }

            faturamento.fechado = true;
            faturamento.dataEncerramento = DateTime.Now;
            FaturamentoRepositorio.Instance.update(faturamento);
            return true;
        }

        public static bool reabreFaturamento(ref Faturamento faturamento) { String mensagemVazia = ""; return reabreFaturamento(ref faturamento, ref mensagemVazia); }

        public static bool reabreFaturamento(ref Faturamento faturamento, ref String mensagemRetorno) {
            faturamento.fechado = false;
            faturamento.dataEncerramento = null;
            FaturamentoRepositorio.Instance.update(faturamento);
            return true;
        }

        public static Faturamento criaFaturamentoComBaseEmOrcamento(Orcamento orcamentoSelecionado) {
            Faturamento newFaturamento = new Faturamento(orcamentoSelecionado.cliente, orcamentoSelecionado.veiculo);

            foreach (Servico servico in orcamentoSelecionado.servicos)
                newFaturamento.servicos.Add(servico);

            foreach (Servico custoAdicional in orcamentoSelecionado.custosAdicionais)
                newFaturamento.custosAdicionais.Add(custoAdicional);

            newFaturamento.numOrcamento = orcamentoSelecionado.id;

            return newFaturamento;
        }

        public static List<Faturamento> reportFaturamento(Relatorios.Faturamento_OrcamentoFiltroRelatorio faturamentoFiltroRelatorio) {
            List<Faturamento> faturamentos = new List<Faturamento>();
            List<int> idsFaturamentos = FaturamentoRepositorio.Instance.reportFaturamento(faturamentoFiltroRelatorio);

            foreach (int id in idsFaturamentos)
                faturamentos.Add(read(id));

            return faturamentos;
        }
        #endregion

        #region CRUD
        public static bool create(ref Faturamento faturamento) {
            return FaturamentoRepositorio.Instance.create(ref faturamento);
        }

        public static bool createServicosInFaturamento(Faturamento faturamento, ref Servico servico, Servico.TipoServico tpServico) {
            return FaturamentoServicoRepositorio.Instance.criaServicosNoFaturamento(faturamento, ref servico, tpServico);
        }

        public static List<Faturamento> read(){
            return FaturamentoRepositorio.Instance.read();
        }

        public static Faturamento read(int id) {
            return FaturamentoRepositorio.Instance.read(id);
        }

        public static bool update(Faturamento faturamento) {
            return FaturamentoRepositorio.Instance.update(faturamento);
        }

        public static bool updateServicosInFaturamento(Servico servico, Servico.TipoServico tpServico) {
            return FaturamentoServicoRepositorio.Instance.update(servico, tpServico);
        }

        public static bool delete(Faturamento faturamento) {
            return FaturamentoRepositorio.Instance.delete(faturamento);
        }

        public static bool delete(int id) {
            return true;
        }
        #endregion

    }
}