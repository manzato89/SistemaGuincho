using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Servicos {
    public class UnidadeServicos {

        #region Implementação Singleton
        private static UnidadeServicos instance = null;
        public static UnidadeServicos Instance {
            get {
                if (instance == null) {
                    instance = new UnidadeServicos();
                }
                return instance;
            }
        }

        private UnidadeServicos() {

        }
        #endregion

        #region Funcionalidades específicas
        #endregion

        #region CRUD
        public bool create(ref Unidade unidade) {
            return UnidadeRepositorio.Instance.create(ref unidade);
        }

        public List<Unidade> read() {
            return UnidadeRepositorio.Instance.read();
        }

        public Unidade read(int idServico) {
            return UnidadeRepositorio.Instance.read(idServico);
        }

        public bool update(Unidade unidade) {
            return UnidadeRepositorio.Instance.update(unidade);
        }

        public bool delete(Unidade unidade) {
            return UnidadeRepositorio.Instance.delete(unidade);
        }
        #endregion
    }
}