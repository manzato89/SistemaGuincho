using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class ServicoRepositorio : Repositorio<Servico> {

        #region Implementação Singleton
        private static ServicoRepositorio instance = null;
        public static ServicoRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new ServicoRepositorio();
                }
                return instance;
            }
        }

        private ServicoRepositorio() {

        }
        #endregion

        private  List<Servico> servicos;

        #region Init
        public  void init() {
            servicos = new List<Servico>();
        }

        public void createTable(SQLiteConnection connection) {

        }

        #endregion

        #region Getters e Setters
        private List<Servico> getServicos() {
            return servicos;
        }

        private void setServicos(List<Servico> newServicos) { servicos = newServicos; }
        #endregion

        #region CRUD
        public bool create(ref Servico servico) {
            servico.id = 123;
            servicos.Add(servico);
            return true;
        }

        public List<Servico> read(){
            return getServicos();
        }

        public Servico read(int id) {
            return new Servico();
        }

        public bool update(List<Servico> servicos) {
            setServicos(servicos);
            return true;
        }

        public bool update(Servico servico) {
            int indexServico = servicos.FindIndex(servicoAEncontrar => servicoAEncontrar.id == servico.id);
            if (indexServico > -1) {
                servicos[indexServico] = servico;
                return true;
            }
            return false;
        }

        public bool delete(Servico servico) {
            servicos.RemoveAt(servicos.FindIndex(servicoADeletar => servicoADeletar.id == servico.id));
            return true;
        }

        public bool delete(int id) {
            return true;
        }
        #endregion

    }
}
