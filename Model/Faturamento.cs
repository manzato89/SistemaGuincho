using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Faturamento {

        public int id { get; set; }
        public int numOrcamento { get; set; }
        public int numFaturamento { get; set; }
        public Cliente cliente { get; set; }
        public List<Servico> servicos { get; set; }
        public List<Servico> custosAdicionais { get; set; }
        public FormaPagamento formaPagamento { get; set; }
        public List<DateTime> datasPagamento { get; set; }
        public bool fechado { get; set; }
        public Veiculo veiculo { get; set; }

        public Faturamento() { }

    }
}
