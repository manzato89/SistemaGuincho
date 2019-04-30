using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Servicos {
    public static class ClienteServicos {

        #region Funcionalidades específicas
        #endregion

        #region CRUD
        public static bool create(ref Cliente Cliente) {
            return ClienteRepositorio.create(ref Cliente);
        }

        public static List<Cliente> read() {
            return ClienteRepositorio.read();
        }

        public static Cliente read(int id) {
            return ClienteRepositorio.read(id);
        }

        public static bool update(List<Cliente> Clientes) {
            return ClienteRepositorio.update(Clientes);
        }

        public static bool update(Cliente Cliente) {
            return ClienteRepositorio.update(Cliente);
        }

        public static bool delete(Cliente Cliente) {
            return ClienteRepositorio.delete(Cliente);
        }

        public static bool delete(int id) {
            return true;
        }
        #endregion

    }
}