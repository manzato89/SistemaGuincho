using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    internal static class OrcamentoRepositorio {

        private static List<Orcamento> orcamentos;

        #region Init
        public static void init() {
            orcamentos = new List<Orcamento>();
        }
        #endregion

        #region Getters e Setters
        private static List<Orcamento> getOrcamentos() {
            return orcamentos;
        }

        private static void setOrcamentos(List<Orcamento> newOrcamentos) { orcamentos = newOrcamentos; }
        #endregion

        #region CRUD
        public static bool create(ref Orcamento orcamento) {
            orcamento.id = 123;
            orcamentos.Add(orcamento);
            return true;
        }

        public static List<Orcamento> read() {
            return getOrcamentos();
        }

        public static Orcamento read(int id) {
            return new Orcamento();
        }

        public static bool update(List<Orcamento> orcamentos) {
            setOrcamentos(orcamentos);
            return true;
        }

        public static bool update(Orcamento orcamento) {
            int indexOrcamento = orcamentos.FindIndex(orcamentoAEncontrar => orcamentoAEncontrar.id == orcamento.id);
            if (indexOrcamento > -1) {
                orcamentos[indexOrcamento] = orcamento;
                return true;
            }
            return false;
        }

        public static bool delete(Orcamento orcamento) {
            orcamentos.RemoveAt(orcamentos.FindIndex(orcamentoADeletar => orcamentoADeletar.id == orcamento.id));
            return true;
        }

        public static bool delete(int id) {
            return true;
        }
        #endregion

    }
}
