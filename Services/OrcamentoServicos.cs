using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Servicos {
    public static class OrcamentoServicos {

        #region Funcionalidades específicas
        public static bool fechaOrcamento(ref Orcamento orcamento) { String mensagemVazia = ""; return fechaOrcamento(ref orcamento, ref mensagemVazia); }

        public static bool fechaOrcamento(ref Orcamento orcamento, ref String mensagemRetorno) {
            // Verifica se foi selecionado um veículo
            if (orcamento.veiculo == null) {
                mensagemRetorno = "Deve ser selecionado um veículo";

                return false;
            }

            // Verifica se o valor do orçamento é maior que 0
            if (orcamento.valorTotal() <= 0) {
                mensagemRetorno = "O valor está zerado";

                return false;
            }

            orcamento.fechado = true;
            orcamento.dataEncerramento = DateTime.Now;
            return true;
        }

        public static bool reabreOrcamento(ref Orcamento orcamento) { String mensagemVazia = ""; return reabreOrcamento(ref orcamento, ref mensagemVazia); }

        public static bool reabreOrcamento(ref Orcamento orcamento, ref String mensagemRetorno) {
            orcamento.fechado = false;
            orcamento.dataEncerramento = null;
            return true;
        }
        #endregion

        #region CRUD
        public static bool create(ref Orcamento orcamento) {
            return OrcamentoRepositorio.Instance.create(ref orcamento);
        }

        public static bool createServicosInOrcamento(Orcamento orcamento, ref Servico servico, Servico.TipoServico tpServico) {
            return OrcamentoServicoRepositorio.Instance.criaServicosNoOrcamento(orcamento, ref servico, tpServico);
        }

        public static List<Orcamento> read(){
            return OrcamentoRepositorio.Instance.read();
        }

        public static Orcamento read(int id) {
            return OrcamentoRepositorio.Instance.read(id);
        }

        public static bool update(Orcamento orcamento) {
            return OrcamentoRepositorio.Instance.update(orcamento);
        }

        public static bool updateServicosInOrcamento(Servico servico, Servico.TipoServico tpServico) {
            return OrcamentoServicoRepositorio.Instance.update(servico, tpServico);
        }

        public static bool delete(Orcamento orcamento) {
            return OrcamentoRepositorio.Instance.delete(orcamento);
        }

        public static bool delete(int id) {
            return true;
        }
        #endregion

    }
}