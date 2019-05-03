using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public class UnidadeRepositorio : Repositorio<Unidade> {

        #region Implementação Singleton
        private static UnidadeRepositorio instance = null;
        public static UnidadeRepositorio Instance {
            get {
                if (instance == null) {
                    instance = new UnidadeRepositorio();
                }
                return instance;
            }
        }

        private UnidadeRepositorio() {

        }
        #endregion

        private List<Unidade> Unidades;

        #region Init
        public void init() {
            Unidades = new List<Unidade>();
        }

        public void createTable(SQLiteConnection connection) {

        }
        #endregion

        #region Getters e Setters
        private List<Unidade> getUnidades() {
            return Unidades;
        }

        private void setUnidades(List<Unidade> newUnidades) { Unidades = newUnidades; }
        #endregion

        #region CRUD
        public bool create(ref Unidade Unidade) {
            Unidade.id = 123;
            Unidades.Add(Unidade);
            return true;
        }

        public List<Unidade> read(){
            return getUnidades();
        }

        public Unidade read(int id) {
            return new Unidade();
        }

        public bool update(List<Unidade> Unidades) {
            setUnidades(Unidades);
            return true;
        }

        public bool update(Unidade Unidade) {
            int indexUnidade = Unidades.FindIndex(UnidadeAEncontrar => UnidadeAEncontrar.id == Unidade.id);
            if (indexUnidade > -1) {
                Unidades[indexUnidade] = Unidade;
                return true;
            }
            return false;
        }

        public bool delete(Unidade Unidade) {
            Unidades.RemoveAt(Unidades.FindIndex(UnidadeADeletar => UnidadeADeletar.id == Unidade.id));
            return true;
        }

        public bool delete(int id) {
            return true;
        }
        #endregion

    }
}
