using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Servicos {
    public class FormaPagamentoServicos {

        #region Implementação Singleton
        private static FormaPagamentoServicos instance = null;
        public static FormaPagamentoServicos Instance {
            get {
                if (instance == null) {
                    instance = new FormaPagamentoServicos();
                }
                return instance;
            }
        }

        private FormaPagamentoServicos() {

        }
        #endregion

        #region Funcionalidades específicas
        #endregion

        #region CRUD
        public bool create(ref FormaPagamento formaPagamento) {
            return FormaPagamentoRepositorio.Instance.create(ref formaPagamento);
        }

        public List<FormaPagamento> read() {
            return FormaPagamentoRepositorio.Instance.read();
        }

        public FormaPagamento read(int idServico) {
            return FormaPagamentoRepositorio.Instance.read(idServico);
        }

        public bool update(FormaPagamento formaPagamento) {
            return FormaPagamentoRepositorio.Instance.update(formaPagamento);
        }

        public bool delete(FormaPagamento formaPagamento) {
            return FormaPagamentoRepositorio.Instance.delete(formaPagamento);
        }
        #endregion
    }
}