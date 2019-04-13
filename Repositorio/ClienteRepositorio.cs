using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public static class ClienteRepositorio {

        private static List<Cliente> clientes;

        #region Init
        public static void init() {
            clientes = new List<Cliente>();
        }
        #endregion

        #region Getters e Setters
        private static List<Cliente> getClientes() {
            return clientes;
        }

        private static void setClientes(List<Cliente> newClientes) { clientes = newClientes; }
        #endregion

        #region CRUD
        public static bool create(ref Cliente cliente) {
            cliente.id = 123;
            clientes.Add(cliente);
            return true;
        }

        public static List<Cliente> read(){
            return getClientes();
        }

        public static Cliente read(int id) {
            return new Cliente();
        }

        public static bool update(List<Cliente> clientes) {
            setClientes(clientes);
            return true;
        }

        public static bool update(Cliente cliente) {
            int indexCliente = clientes.FindIndex(clienteAEncontrar => clienteAEncontrar.id == cliente.id);
            if (indexCliente > -1) {
                clientes[indexCliente] = cliente;
                return true;
            }
            return false;
        }

        public static bool delete(Cliente cliente) {
            clientes.RemoveAt(clientes.FindIndex(clienteADeletar => clienteADeletar.id == cliente.id));
            return true;
        }

        public static bool delete(int id) {
            return true;
        }
        #endregion

    }
}
