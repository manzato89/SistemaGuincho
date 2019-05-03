using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private List<Orcamento> orcamentos;

        #region Init
        public void init() {
            orcamentos = new List<Orcamento>();
        }

        public void createTable(SQLiteConnection connection) {

        }
        #endregion

        #region Getters e Setters
        private List<Orcamento> getOrcamentos() {
            return orcamentos;
        }

        private void setOrcamentos(List<Orcamento> newOrcamentos) { orcamentos = newOrcamentos; }
        #endregion

        #region CRUD
        public bool create(ref Orcamento orcamento) {
            orcamento.id = 123;
            orcamentos.Add(orcamento);
            return true;
        }

        public List<Orcamento> read() {
            return getOrcamentos();
        }

        public Orcamento read(int id) {
            return new Orcamento();
        }

        public bool update(List<Orcamento> orcamentos) {
            setOrcamentos(orcamentos);
            return true;
        }

        public bool update(Orcamento orcamento) {
            int indexOrcamento = orcamentos.FindIndex(orcamentoAEncontrar => orcamentoAEncontrar.id == orcamento.id);
            if (indexOrcamento > -1) {
                orcamentos[indexOrcamento] = orcamento;
                return true;
            }
            return false;
        }

        public bool delete(Orcamento orcamento) {
            orcamentos.RemoveAt(orcamentos.FindIndex(orcamentoADeletar => orcamentoADeletar.id == orcamento.id));
            return true;
        }

        public bool delete(int id) {
            return true;
        }
        #endregion

    }
}
