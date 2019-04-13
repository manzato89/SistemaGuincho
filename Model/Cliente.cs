using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Cliente {

        public int id { get; set; }

        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public Endereco endereco { get; set; }
        public List<Veiculo> veiculos { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }
        public int dddFone1 { get; set; }
        public int fone1 { get; set; }
        public int dddFone2 { get; set; }
        public int fone2 { get; set; }


        public Cliente() {
            veiculos = new List<Veiculo>();
        }

    }
}
