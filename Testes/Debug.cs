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
            veiculo._idCliente = cliente.id;
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
            veiculo._idCliente = cliente.id;
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
            veiculo._idCliente = cliente.id;
            cliente.veiculos.Add(veiculo);

            clientes.Add(cliente);
            #endregion

            #region Cliente 3
            cliente = new Cliente();
            cliente.id = 3;
            cliente.nome = "Osvaldo Elias Henrique Souza";
            cliente.cpf = "40327876620";
            cliente.rg = "451522539";
            cliente.dataNascimento = new DateTime(1980, 06, 15);
            cliente.email = "osvaldoeliashenriquesouza__osvaldoeliashenriquesouza@cerimoniallis.com.br";
            cliente.fone1 = "(35) 35655229";
            cliente.fone2 = "(35) 984255472";

            endereco = new Endereco();
            endereco.logradouro = "Rua Júlio de Melo Braga";
            endereco.numero = "506";
            endereco.bairro = "Jardim Itamaraty II";
            endereco.cep = 37710225;
            endereco.cidade = "Poços de Caldas";
            endereco.uf = "MG";
            cliente.endereco = endereco;

            veiculo = new Veiculo();
            veiculo.id = 4;
            veiculo.tpVeiculo = Veiculo.TipoVeiculo.Van;
            veiculo.placa = "CCC1298";
            veiculo.cidadePlaca = endereco.cidade;
            veiculo.ufPlaca = endereco.uf;
            veiculo.cor = "Cinza";
            veiculo.modelo = "Renault Master 2.3 Standard L2h2 16l 5p";
            veiculo.ano = 2014;
            veiculo._idCliente = cliente.id;
            cliente.veiculos.Add(veiculo);

            clientes.Add(cliente);
            #endregion

            return clientes;
        }

        public static List<Unidade> getUnidadesDeTeste() {
            List<Unidade> unidades = new List<Unidade>();

            Unidade unidade1 = new Unidade("UN", "Unidade");    unidade1.id = 1;
            Unidade unidade2 = new Unidade("KM", "Kilômetro");  unidade2.id = 2;
            Unidade unidade3 = new Unidade("MT", "Metro");      unidade3.id = 3;
            Unidade unidade4 = new Unidade("LT", "Litros");     unidade4.id = 4;
            Unidade unidade5 = new Unidade("KG", "Quilos");     unidade5.id = 5;

            unidades.Add(unidade1);
            unidades.Add(unidade2);
            unidades.Add(unidade3);
            unidades.Add(unidade4);
            unidades.Add(unidade5);

            return unidades;
        }

        public static List<FormaPagamento> getFormasDePagamentoDeTeste() {
            List<FormaPagamento> formasDePagamento = new List<FormaPagamento>();

            FormaPagamento formaPagamento1 = new FormaPagamento("Á vista", 1, true);   formaPagamento1.id = 1;
            FormaPagamento formaPagamento2 = new FormaPagamento("3x", 3, false);       formaPagamento2.id = 2;
            FormaPagamento formaPagamento3 = new FormaPagamento("6x", 6, false);       formaPagamento3.id = 3;
            FormaPagamento formaPagamento4 = new FormaPagamento("1 + 9x", 10, true);   formaPagamento4.id = 4;
            FormaPagamento formaPagamento5 = new FormaPagamento("1 + 11x", 12, true);  formaPagamento5.id = 5;

            formasDePagamento.Add(formaPagamento1);
            formasDePagamento.Add(formaPagamento2);
            formasDePagamento.Add(formaPagamento3);
            formasDePagamento.Add(formaPagamento4);
            formasDePagamento.Add(formaPagamento5);

            return formasDePagamento;
        }

        public static List<Servico> getServicosDeTeste() {
            Unidade unidade1 = new Unidade("UN", "Unidade");    unidade1.id = 1;
            Unidade unidade2 = new Unidade("KM", "Kilômetro");  unidade2.id = 2;
            Unidade unidade3 = new Unidade("MT", "Metro");      unidade3.id = 3;
            Unidade unidade4 = new Unidade("LT", "Litros");     unidade4.id = 4;
            Unidade unidade5 = new Unidade("KG", "Quilos");     unidade5.id = 5;

            List<Servico> servicos = new List<Servico>();
            Servico servico1 = new Servico("Busca de carro", 15.75f, unidade2);  servico1.id = 1;
            Servico servico2 = new Servico("Reboque", 40.15f, unidade1);           servico2.id = 2;
            Servico servico3 = new Servico("Troca de pneu", 9.90f, unidade1);      servico3.id = 3;
            Servico servico4 = new Servico("Troca de óleo", 22.49f, unidade4);     servico4.id = 4;

            servicos.Add(servico1);
            servicos.Add(servico2);
            servicos.Add(servico3);
            servicos.Add(servico4);

            return servicos;
        }

        public static List<Orcamento> getOrcamentosDeTeste() {
            List<Orcamento> orcamentos = new List<Orcamento>();

            List<Cliente> clientes = getClientesDeTeste();
            List<Servico> servicos = getServicosDeTeste();
            Servico servico, custoAdicional;

            // Orçamento 1
            Orcamento orcamento = new Orcamento(clientes[0], clientes[0].veiculos[0]);

            servico = servicos[0];
            servico._quantidade = 3;
            servico._idServicoOrcFat = 1;
            orcamento.servicos.Add(servico);

            servico = servicos[3];
            servico._quantidade = 1;
            servico._idServicoOrcFat = 2;
            orcamento.servicos.Add(servico);

            orcamento.fechado = true;
            orcamento.id = 1;
            orcamentos.Add(orcamento);

            // Orçamento 2
            orcamento = new Orcamento(clientes[1], clientes[1].veiculos[0]);

            servico = servicos[2];
            servico._quantidade = 5;
            servico._idServicoOrcFat = 3;
            orcamento.servicos.Add(servico);

            custoAdicional = servicos[1];
            custoAdicional._quantidade = 10;
            custoAdicional._idServicoOrcFat = 1;
            orcamento.custosAdicionais.Add(custoAdicional);

            orcamento.id = 2;
            orcamentos.Add(orcamento);

            // Orçamento 3
            orcamento = new Orcamento(clientes[1], clientes[1].veiculos[1]);

            custoAdicional = servicos[2];
            custoAdicional._quantidade = 3;
            custoAdicional._idServicoOrcFat = 2;
            orcamento.custosAdicionais.Add(custoAdicional);

            orcamento.id = 3;
            orcamentos.Add(orcamento);            

            // Orçamento 4
            orcamento = new Orcamento(clientes[2], null);
            orcamento.id = 4;
            orcamentos.Add(orcamento);

            return orcamentos;
        }

        public static List<Faturamento> getFaturamentosDeTeste() {
            List<Faturamento> faturamentos = new List<Faturamento>();

            List<Cliente> clientes = getClientesDeTeste();
            List<Servico> servicos = getServicosDeTeste();
            List<Orcamento> orcamentos = getOrcamentosDeTeste().FindAll(find => find.fechado);
            List<FormaPagamento> formasDePagamento = getFormasDePagamentoDeTeste();
            Servico servico, custoAdicional;

            // Faturamento 1
            Faturamento faturamento = new Faturamento(clientes[0], clientes[0].veiculos[0]);

            servico = servicos[2];
            servico._quantidade = 5;
            servico._idServicoOrcFat = 3;
            faturamento.servicos.Add(servico);

            custoAdicional = servicos[1];
            custoAdicional._quantidade = 10;
            custoAdicional._idServicoOrcFat = 1;
            faturamento.custosAdicionais.Add(custoAdicional);

            faturamento.fechado = false;
            faturamento.formaPagamento = formasDePagamento[2];
            faturamento._idFormaPagamento = formasDePagamento[2].id;
            faturamento.id = 1;
            faturamentos.Add(faturamento);

            // Faturamento 2
            faturamento = Servicos.FaturamentoServicos.criaFaturamentoComBaseEmOrcamento(orcamentos[0]);

            faturamento.formaPagamento = formasDePagamento[0];
            faturamento._idFormaPagamento = formasDePagamento[0].id;
            faturamento.id = 2;
            faturamentos.Add(faturamento);

            return faturamentos;
        }

    }
}