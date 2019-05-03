using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Model {
    public class Cliente {

        public int id { get; set; }

        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public Endereco endereco { get; set; }
        public List<Veiculo> veiculos { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }
        public string fone1 { get; set; }
        public string fone2 { get; set; }

        public int _idEndereco { get; set; }

        // Construtor básico
        public Cliente(string nome, string cpf, Endereco endereco, List<Veiculo> veiculos, string fone1) {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.veiculos = veiculos;
            this.fone1 = fone1;
        }

        // Construtor completo
        public Cliente(string nome, string cpf, string rg, Endereco endereco, List<Veiculo> veiculos, DateTime dataNascimento, string email, string fone1, string fone2) {
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.endereco = endereco;
            this.veiculos = veiculos;
            this.dataNascimento = dataNascimento;
            this.email = email;
            this.fone1 = fone1;
            this.fone2 = fone2;
        }
        

        // Construtor em branco
        public Cliente() {
            veiculos = new List<Veiculo>();
        }

        public override string ToString() {
            return String.Format("{0} - {1} - {2}", id, nome, cpf);
        }

        public string getCliente() {
            return String.Format("ID: {0}\n" +
                "Nome: {1}\n" +
                "CPF: {2}",
                id, nome, cpf);
        }

        public string getModeloVeiculos() {
            String modeloVeiculos = "";

            foreach(Veiculo veiculo in veiculos) {
                modeloVeiculos = String.Format("{0}{1}, ",
                    modeloVeiculos, veiculo.getCustomModelo());
            }

            if (modeloVeiculos.Length > 0)
                modeloVeiculos = modeloVeiculos.Substring(0, modeloVeiculos.Length - 2); // Remove a última vírgula e espaço

            return modeloVeiculos;
        }

        public string getPlacaVeiculos() {
            String placaVeiculos = "";

            foreach (Veiculo veiculo in veiculos) {
                placaVeiculos = String.Format("{0}{1}, ",
                    placaVeiculos, veiculo.getCustomPlaca());
            }

            if (placaVeiculos.Length > 0)
                placaVeiculos = placaVeiculos.Substring(0, placaVeiculos.Length - 2); // Remove a última vírgula e espaço

            return placaVeiculos;
        }

    }
}
