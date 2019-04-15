using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public static class ServicoRepositorio {

        private static List<Servico> servicos;

        #region Init
        public static void init() {
            servicos = new List<Servico>();
        }
        #endregion

        #region Getters e Setters
        private static List<Servico> getServicos() {
            return servicos;
        }

        private static void setServicos(List<Servico> newServicos) { servicos = newServicos; }
        #endregion

        #region CRUD
        public static bool create(ref Servico servico) {
            servico.id = 123;
            servicos.Add(servico);
            return true;
        }

        public static List<Servico> read(){
            return getServicos();
        }

        public static Servico read(int id) {
            return new Servico();
        }

        public static bool update(List<Servico> servicos) {
            setServicos(servicos);
            return true;
        }

        public static bool update(Servico servico) {
            int indexServico = servicos.FindIndex(servicoAEncontrar => servicoAEncontrar.id == servico.id);
            if (indexServico > -1) {
                servicos[indexServico] = servico;
                return true;
            }
            return false;
        }

        public static bool delete(Servico servico) {
            servicos.RemoveAt(servicos.FindIndex(servicoADeletar => servicoADeletar.id == servico.id));
            return true;
        }

        public static bool delete(int id) {
            return true;
        }
        #endregion

    }
}
