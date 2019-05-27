using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Faturamento {

        public int id { get; set; }
        public int numOrcamento { get; set; }
        public Cliente cliente { get; set; }
        public List<Servico> servicos { get; set; }
        public List<Servico> custosAdicionais { get; set; }
        public FormaPagamento formaPagamento { get; set; }
        public bool fechado { get; set; }
        public Veiculo veiculo { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime? dataEncerramento { get; set; }

        public int _idCliente { get; set; }
        public int _idVeiculo { get; set; }
        public int _idFormaPagamento { get; set; }

        public Faturamento() {
            dataCriacao = DateTime.Now;
            dataEncerramento = null;
        }

        public Faturamento(Cliente cliente, Veiculo veiculo) {
            this.cliente = cliente;
            this.veiculo = veiculo;

            servicos = new List<Servico>();
            custosAdicionais = new List<Servico>();

            dataCriacao = DateTime.Now;
            dataEncerramento = null;

            if (cliente != null)
                _idCliente = cliente.id;

            if (veiculo != null)
                _idVeiculo = veiculo.id;
        }

        public String servicos_custosAdicionais() {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Servico servico in servicos) {
                stringBuilder.Append(servico.descricao);
                stringBuilder.Append(" (");
                stringBuilder.Append(servico._quantidade);
                stringBuilder.Append(") ");
            }

            foreach (Servico custoAdicional in custosAdicionais) {
                stringBuilder.Append(custoAdicional.descricao);
                stringBuilder.Append(" (");
                stringBuilder.Append(custoAdicional._quantidade);
                stringBuilder.Append(")");
            }

            return stringBuilder.ToString();
        }

        public float valorTotalServicos() {
            float valorTotal = 0;

            foreach (Servico servico in servicos) {
                valorTotal += servico.valor * servico._quantidade;
            }

            return valorTotal;
        }

        public float valorTotalCustosAdicionais() {
            float valorTotal = 0;

            foreach (Servico servico in custosAdicionais) {
                valorTotal += servico.valor * servico._quantidade;
            }

            return valorTotal;
        }

        public float valorTotal() {
            float valorTotal = valorTotalServicos() + valorTotalCustosAdicionais();

            if (!formaPagamento.entrada || formaPagamento.numParcelas > 1) {
                int entrada = formaPagamento.entrada ? 1 : 0;
                for (int iCount = 0; iCount < formaPagamento.numParcelas - entrada; iCount++) {
                    valorTotal += valorTotal * (formaPagamento.percJuros / 100);
                }
            }

            return valorTotal;
        }

    }
}
