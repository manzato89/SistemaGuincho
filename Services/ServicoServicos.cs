using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Servicos {
    public class ServicoServicos {

        #region Implementação Singleton
        private static ServicoServicos instance = null;
        public static ServicoServicos Instance {
            get {
                if (instance == null) {
                    instance = new ServicoServicos();
                }
                return instance;
            }
        }

        private ServicoServicos() {

        }
        #endregion

        #region Funcionalidades específicas
        #endregion

        #region CRUD
        public bool create(ref Servico servico) {
            return ServicoRepositorio.Instance.create(ref servico);
        }

        public List<Servico> read() {
            return ServicoRepositorio.Instance.read();
        }

        public Servico read(int idServico) {
            return ServicoRepositorio.Instance.read(idServico);
        }

        public bool update(Servico servico) {
            return ServicoRepositorio.Instance.update(servico);
        }

        public bool delete(Servico servico) {
            return ServicoRepositorio.Instance.delete(servico);
        }
        #endregion
    }
}