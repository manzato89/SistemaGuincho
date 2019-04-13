using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Model;

namespace SistemaGuincho.Testes {
    public static class Debug {
        public static List<Cliente> getClientesDeTeste() {
            // Cria clientes https://www.4devs.com.br/gerador_de_pessoas
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente;
            Endereco endereco;
            Veiculo veiculo;

            #region Cliente 1
            cliente = new Cliente();
            cliente.id = 1;
            cliente.nome = "Diego Filipe Theo Pinto";
            cliente.cpf = "53690728843";
            cliente.rg = "105553864";
            cliente.dataNascimento = new DateTime(1997, 11, 10);
            cliente.email = "diegofilipetheopinto-95@konekoshouten.com.br";
            cliente.fone1 = "(14) 37746161";
            cliente.fone2 = "(14) 995650146";

            endereco = new Endereco();
            endereco.logradouro = "Avenida Doutor Rafael Paes de Barros";
            endereco.numero = "209";
            endereco.bairro = "Centro";
            endereco.cep = 17400000;
            endereco.cidade = "Garça";
            endereco.uf = "SP";
            cliente.endereco = endereco;

            veiculo = new Veiculo();
            veiculo.id = 1;
            veiculo.tpVeiculo = Veiculo.TipoVeiculo.Carro;
            veiculo.placa = "AAA1234";
            veiculo.cidadePlaca = endereco.cidade;
            veiculo.ufPlaca = endereco.uf;
            veiculo.cor = "Preto";
            veiculo.modelo = "Volkswagen Gol";
            veiculo.ano = 2013;
            cliente.veiculos.Add(veiculo);

            clientes.Add(cliente);
            #endregion

            #region Cliente 2
            cliente = new Cliente();
            cliente.id = 2;
            cliente.nome = "Francisca Emilly Giovana Sales";
            cliente.cpf = "11015661831";
            cliente.rg = "234430497";
            cliente.dataNascimento = new DateTime(1984, 08, 17);
            cliente.email = "franciscaemilly@cntbrasil.com.br";
            cliente.fone1 = "(14) 29813704";
            cliente.fone2 = "(14) 985762740";

            endereco = new Endereco();
            endereco.logradouro = "Praça Gustavo Morales Agulhari";
            endereco.numero = "703";
            endereco.bairro = "Jardim Progresso";
            endereco.complemento = "Apto 23";
            endereco.cep = 17064253;
            endereco.cidade = "Bauru";
            endereco.uf = "SP";
            cliente.endereco = endereco;

            veiculo = new Veiculo();
            veiculo.id = 2;
            veiculo.tpVeiculo = Veiculo.TipoVeiculo.Carro;
            veiculo.placa = "BBB9717";
            veiculo.cidadePlaca = endereco.cidade;
            veiculo.ufPlaca = endereco.uf;
            veiculo.cor = "Vermelho";
            veiculo.modelo = "Honda Civic";
            veiculo.ano = 2018;
            cliente.veiculos.Add(veiculo);

            veiculo = new Veiculo();
            veiculo.id = 3;
            veiculo.tpVeiculo = Veiculo.TipoVeiculo.Moto;
            veiculo.placa = "ASJ9006";
            veiculo.cidadePlaca = endereco.cidade;
            veiculo.ufPlaca = endereco.uf;
            veiculo.cor = "Amarela";
            veiculo.modelo = "Honda CB 300";
            veiculo.ano = 2018;
            cliente.veiculos.Add(veiculo);

            clientes.Add(cliente);
            #endregion

            return clientes;
        }
    }
}