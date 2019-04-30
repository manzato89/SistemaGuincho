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
        public List<Servico> custosAdicionais { get; set; }
        public bool fechado { get; set; }
        public Veiculo veiculo { get; set; }

        public Orcamento() { }

        public Orcamento(Cliente cliente, Veiculo veiculo) {
            this.cliente = cliente;
            this.veiculo = veiculo;

            servicos = new List<Servico>();
            custosAdicionais = new List<Servico>();
        }

        public float valorTotal() {
            float valorTotal = 0;

            foreach (Servico servico in servicos) {
                valorTotal += servico.valor * servico._quantidade;
            }

            foreach (Servico servico in custosAdicionais) {
                valorTotal += servico.valor * servico._quantidade;
            }

            return valorTotal;

        }

    }
}
