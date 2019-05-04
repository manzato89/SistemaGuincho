using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Servico {

        public int id { get; set; }
        public string descricao { get; set; }
        public Unidade unidade { get; set; }
        public float valor { get; set; }

        public int _quantidade { get; set; }
        public string _total { get; set; }
        public int _idUnidade { get; set; }

        public Servico() { }

        public Servico(string descricao, float valor, Unidade unidade) {
            this.descricao = descricao;
            this.valor = valor;
            this.unidade = unidade;

            this._quantidade = 1;
            this._idUnidade = unidade.id;
        }

        public override string ToString() {
            return String.Format("{0} - {1} - R$ {2}", descricao, unidade, valor);
        }

        public string getServico() {
            return String.Format("ID: {0}\n" +
                "Descrição: {1}\n" +
                "Unidade: {2}\n" + 
                "Valor: R$ {3}",
                id, descricao, unidade, valor);
        }

    }
}