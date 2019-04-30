using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Veiculo {

        public enum TipoVeiculo {
            Carro,
            Moto,
            Van,
            Caminhão
        };

        public int id { get; set; }
        public TipoVeiculo tpVeiculo { get; set; }
        public String modelo { get; set; }
        public int ano { get; set; }
        public String cor { get; set; }

        public String placa { get; set; }
        public String cidadePlaca { get; set; }
        public String ufPlaca { get; set; }
      
        public String modelo_2 { get { return getCustomModelo(); } }
        public String placa_2 { get { return getCustomPlaca(); } }


        public Veiculo() { }

        public Veiculo(TipoVeiculo tpVeiculo, string modelo, int ano, string cor, string placa, string cidadePlaca, string ufPlaca) {
            this.tpVeiculo = tpVeiculo;
            this.modelo = modelo;
            this.ano = ano;
            this.cor = cor;
            this.placa = placa;
            this.cidadePlaca = cidadePlaca;
            this.ufPlaca = ufPlaca;
        }

        public string getCustomModelo() {
            return String.Format("{0} - {1} - {2}",
                        modelo,
                        ano,
                        cor);
        }

        public string getCustomPlaca() {
            return String.Format("{0} ({1} - {2})",
                        placa,
                        cidadePlaca,
                        ufPlaca);
        }

        public override string ToString() {
            return String.Format("{0} - {1} - {2}", id, getCustomModelo(), getCustomPlaca());
        }

        public string getVeiculo() {
            return String.Format("ID: {0}\n" +
                "Modelo: {1}\n" +
                "Placa: {2}\n",
                id, getCustomModelo(), getCustomPlaca());
        }

    }
}