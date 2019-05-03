using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Servicos {
    public class VeiculoServicos {

        #region Implementação Singleton
        private static VeiculoServicos instance = null;
        public static VeiculoServicos Instance {
            get {
                if (instance == null) {
                    instance = new VeiculoServicos();
                }
                return instance;
            }
        }

        private VeiculoServicos() {

        }
        #endregion

        #region Funcionalidades específicas
        #endregion

        #region CRUD
        public bool create(ref Veiculo veiculo) {
            return VeiculoRepositorio.Instance.create(ref veiculo);
        }

        public List<Veiculo> read(Cliente cliente){
            return VeiculoRepositorio.Instance.read(cliente);
        }

        public List<Veiculo> read() {
            return VeiculoRepositorio.Instance.read();
        }

        public Veiculo read(int idVeiculo) {
            return VeiculoRepositorio.Instance.read(idVeiculo);
        }

        public bool update(Veiculo veiculo) {
            return VeiculoRepositorio.Instance.update(veiculo);
        }

        public bool delete(Veiculo veiculo) {
            return VeiculoRepositorio.Instance.delete(veiculo);
        }

        public bool delete(int idCliente) {
            return VeiculoRepositorio.Instance.delete(idCliente);
        }
        #endregion
    }
}