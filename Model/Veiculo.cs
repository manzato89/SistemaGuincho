using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Veiculo {

        public enum TipoVeiculo {
            Carro,
            Moto
        };

        public int id { get; set; }
        public TipoVeiculo tpVeiculo { get; set; }
        public String placa { get; set; }
        public String cidadePlaca { get; set; }
        public String ufPlaca { get; set; }
        public String cor { get; set; }
        public String modelo { get; set; }
        public int ano { get; set; }

        public Veiculo() { }

    }
}