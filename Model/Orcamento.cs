using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Orcamento {

        public int id { get; set; }
        public int numOrcamento { get; set; }
        public Cliente cliente { get; set; }
        public List<Servico> servicos { get; set; }
        public List<CustoAdicional> custosAdicionais { get; set; }
        public bool fechado { get; set; }
        public Veiculo veiculo { get; set; }

        public Orcamento() { }

    }
}
