using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public static class UnidadeRepositorio {

        private static List<Unidade> Unidades;

        #region Init
        public static void init() {
            Unidades = new List<Unidade>();
        }
        #endregion

        #region Getters e Setters
        private static List<Unidade> getUnidades() {
            return Unidades;
        }

        private static void setUnidades(List<Unidade> newUnidades) { Unidades = newUnidades; }
        #endregion

        #region CRUD
        public static bool create(ref Unidade Unidade) {
            Unidade.id = 123;
            Unidades.Add(Unidade);
            return true;
        }

        public static List<Unidade> read(){
            return getUnidades();
        }

        public static Unidade read(int id) {
            return new Unidade();
        }

        public static bool update(List<Unidade> Unidades) {
            setUnidades(Unidades);
            return true;
        }

        public static bool update(Unidade Unidade) {
            int indexUnidade = Unidades.FindIndex(UnidadeAEncontrar => UnidadeAEncontrar.id == Unidade.id);
            if (indexUnidade > -1) {
                Unidades[indexUnidade] = Unidade;
                return true;
            }
            return false;
        }

        public static bool delete(Unidade Unidade) {
            Unidades.RemoveAt(Unidades.FindIndex(UnidadeADeletar => UnidadeADeletar.id == Unidade.id));
            return true;
        }

        public static bool delete(int id) {
            return true;
        }
        #endregion

    }
}
