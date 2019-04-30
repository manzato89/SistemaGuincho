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
        #endregion

        #region CRUD
        public static bool create(ref Orcamento orcamento) {
            return OrcamentoRepositorio.create(ref orcamento);
        }

        public static List<Orcamento> read(){
            return OrcamentoRepositorio.read();
        }

        public static Orcamento read(int id) {
            return OrcamentoRepositorio.read(id);
        }

        public static bool update(List<Orcamento> orcamentos) {
            return OrcamentoRepositorio.update(orcamentos);
        }

        public static bool update(Orcamento orcamento) {
            return OrcamentoRepositorio.update(orcamento);
        }

        public static bool delete(Orcamento orcamento) {
            return OrcamentoRepositorio.delete(orcamento);
        }

        public static bool delete(int id) {
            return true;
        }

        public static bool fechaOrcamento(ref Orcamento orcamento) {    String mensagemVazia = "";  return fechaOrcamento(ref orcamento, ref mensagemVazia);    }

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
            return true;
        }

        public static bool reabreOrcamento(ref Orcamento orcamento) { String mensagemVazia = ""; return reabreOrcamento(ref orcamento, ref mensagemVazia); }

        public static bool reabreOrcamento(ref Orcamento orcamento, ref String mensagemRetorno) {
            orcamento.fechado = false;
            return true;
        }

        #endregion

    }
}
