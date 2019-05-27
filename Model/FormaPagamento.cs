using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class FormaPagamento {

        public int id { get; set; }
        public string descricao { get; set; }
        public int numParcelas { get; set; }
        public float percJuros { get; set; }
        public bool entrada { get; set; }

        public FormaPagamento() { }

        public FormaPagamento(string descricao, int numParcelas, bool entrada, float percJuros = 0) {
            this.descricao = descricao;
            this.numParcelas = numParcelas;
            this.entrada = entrada;
            this.percJuros = percJuros;
        }

        public override string ToString() {
            return String.Format("{0} - {1}x - {2}", descricao, numParcelas, (entrada? "Com entrada" : "Sem entrada"));
        }
    }
}