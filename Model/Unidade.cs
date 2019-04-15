using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Unidade {

        public int id { get; set; }

        public string codigo { get; set; }
        public string descricao { get; set; }

        public Unidade() { }

        public Unidade(string codigo, string descricao) {
            this.codigo = codigo;
            this.descricao = descricao;
        }

        public override string ToString() {
            return String.Format("{0} - {1}", codigo, descricao);
        }

        public string getUnidade() {
            return String.Format("ID: {0}\n" +
                "Código: {1}\n" +
                "Descrição: {2}",
                id, codigo, descricao);
        }

    }
}
