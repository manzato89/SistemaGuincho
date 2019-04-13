using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Repositorio {
    public static class VeiculoRepositorio {

        private static Dictionary<int, List<Veiculo>> veiculos;

        #region Init
        public static void init() {
            veiculos = new Dictionary<int, List<Veiculo>>();
        }
        #endregion

        #region Getters e Setters
        private static List<Veiculo> getVeiculos(int idCliente) {
            if (veiculos.ContainsKey(idCliente))
                return veiculos[idCliente];

            return null;
        }

        private static void setVeiculos(Dictionary<int, List<Veiculo>> newVeiculos) {
            veiculos = newVeiculos;
        }

        private static void setVeiculos(List<Veiculo> newVeiculos, int idCliente) {
            if (veiculos.ContainsKey(idCliente))
                veiculos[idCliente] = newVeiculos;
            else
                veiculos.Add(idCliente, newVeiculos);
        }
        #endregion

        #region CRUD
        public static bool create(ref Veiculo veiculo, int idCliente) {
            veiculo.id = 123;

            List<Veiculo> veiculosDoCliente = getVeiculos(idCliente);
            if (veiculosDoCliente == null) {
                veiculosDoCliente = new List<Veiculo>();
            }

            veiculosDoCliente.Add(veiculo);

            setVeiculos(veiculosDoCliente, idCliente);
            return true;
        }

        public static List<Veiculo> read(int idCliente){
            return getVeiculos(idCliente);
        }

        public static Veiculo read(int idCliente, int idVeiculo) {
            return read(idCliente).Find(veiculoAEncontrar => veiculoAEncontrar.id == idVeiculo);
        }

        public static void update(Dictionary<int, List<Veiculo>> newVeiculos) {
            setVeiculos(newVeiculos);
        }

        public static bool update(int idCliente, Veiculo newVeiculo) {
            Veiculo veiculo = read(idCliente, newVeiculo.id);
            veiculo = newVeiculo;

            int indexVeiculo = veiculos[idCliente].FindIndex(veiculoAEncontrar => veiculoAEncontrar.id == newVeiculo.id);
            veiculos[idCliente][indexVeiculo] = newVeiculo;

            return true;
        }

        public static bool delete(int idCliente) {
            if (!veiculos.ContainsKey(idCliente))
                return false;

            veiculos.Remove(idCliente);
            return true;
        }

        public static bool delete(int idCliente, Veiculo veiculo) {
            if (!veiculos.ContainsKey(idCliente))
                return false;

            if (veiculos[idCliente].FindIndex(veiculoAEncontrar => veiculoAEncontrar.id == veiculo.id) == -1)
                return false;

            List<Veiculo> veiculosDoCliente = getVeiculos(idCliente);
            veiculosDoCliente.Remove(veiculo);

            setVeiculos(veiculosDoCliente, idCliente);
            return true;
        }
        #endregion

    }
}
