using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Servicos {
    public class ClienteServicos {

        #region Implementação Singleton
        private static ClienteServicos instance = null;
        public static ClienteServicos Instance {
            get {
                if (instance == null) {
                    instance = new ClienteServicos();
                }
                return instance;
            }
        }

        private ClienteServicos() {

        }
        #endregion

        #region Funcionalidades específicas
        #endregion

        #region CRUD
        public bool create(ref Cliente cliente) {
            return ClienteRepositorio.Instance.create(ref cliente);
        }

        public List<Cliente> read() {
            return ClienteRepositorio.Instance.read();
        }

        public Cliente read(int id) {
            return ClienteRepositorio.Instance.read(id);
        }

        public bool update(Cliente Cliente) {
            return ClienteRepositorio.Instance.update(Cliente);
        }

        public bool delete(Cliente Cliente) {
            return ClienteRepositorio.Instance.delete(Cliente);
        }

        public bool delete(int id) {
            return true;
        }
        #endregion

    }
}