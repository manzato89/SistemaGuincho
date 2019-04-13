using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public static class ClienteRepositorio {

        private static List<Cliente> clientes;

        public static List<Cliente> getClientes() {
            if (clientes == null)
                return new List<Cliente>();

            return clientes;
        }

        public static void setClientes(List<Cliente> newClientes) { clientes = newClientes; }

    }
}
