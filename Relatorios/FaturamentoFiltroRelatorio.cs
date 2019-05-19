using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Relatorios {
    public class Faturamento_OrcamentoFiltroRelatorio {

        public enum TipoRelatorio {
            Orcamento,
            Faturamento
        };

        public DateTime? dtCriacaoInicio { get; set; }
        public DateTime? dtCriacaoFim { get; set; }

        public DateTime? dtEncerramentoInicio { get; set; }
        public DateTime? dtEncerramentoFim { get; set; }

        public List<FormaPagamento> formasPagamentoSelecionadas { get; set; }

        public List<Servico> servicosSelecionados { get; set; }

        public List<Servico> custosAdicionaisSelecionados { get; set; }

        public List<Cliente> clientesSelecionados { get; set; }

        public bool apenasFechados { get; set; }

        public TipoRelatorio tpRelatorio { get; }

        public Faturamento_OrcamentoFiltroRelatorio(TipoRelatorio tpRelatorio) {
            this.tpRelatorio = tpRelatorio;

            dtCriacaoInicio = null;
            dtCriacaoFim = null;
            dtEncerramentoInicio = null;
            dtEncerramentoFim = null;
            formasPagamentoSelecionadas = null;
            servicosSelecionados = null;
            custosAdicionaisSelecionados = null;
            clientesSelecionados = null;
            apenasFechados = false;
        }
    }
}
