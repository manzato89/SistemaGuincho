using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class CustoAdicional {

        public int id { get; set; }
        public string descricao { get; set; }
        public int qtde { get; set; }
        public Unidade unidade { get; set; }
        public float valor { get; set; }

        public CustoAdicional() { }

    }
}
