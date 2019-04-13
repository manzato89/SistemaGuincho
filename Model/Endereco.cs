using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Endereco {
        public int id { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public long cep { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }

        public Endereco() { }

        public Endereco(string logradouro, string numero, string bairro, long cep, string complemento, string cidade, string uf) {
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.cep = cep;
            this.complemento = complemento;
            this.cidade = cidade;
            this.uf = uf;
        }

    }
}
