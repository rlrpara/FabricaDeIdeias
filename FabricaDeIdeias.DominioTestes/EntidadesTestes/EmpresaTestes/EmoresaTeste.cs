using FabricaDeIdeias.Dominio.Entidades;
using FabricaDeIdeias.Dominio.Enum;
using FabricaDeIdeias.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FabricaDeIdeias.DominioTestes.EntidadesTestes.EmpresaTestes
{
    [Trait("Entidade", "Empresa")]
    public class EmoresaTeste
    {
        [Fact(DisplayName = "Gerar nova instância")]
        public void GerarNovaInstância()
        {
            var empresa = new Empresa(null, "EMPRESA DE TESTES", "", "17.307.005/0001-64", null, null, "", "");

            Assert.True(empresa != null);
        }

        [Fact(DisplayName = "Deve retornar apenas numeros no cnpj")]
        public void DeveRetornarApenasNumeroNoCnpj()
        {
            var empresa = new Empresa(null, "EMPRESA DE TESTES", "", "17.307.005/0001-64", null, null, "", "");

            Assert.Equal("17307005000164", empresa.CNPJ);
        }

        [Fact(DisplayName = "Deve retornar a razão social maúscula e sem acentos ")]
        public void DeveRetornarRazaoSocialMaiusculaSemAcentos()
        {
            var empresa = new Empresa(null, "chapecó comércio ltda", "1234", "17.307.005/0001-64", null, null, "", "");

            Assert.Equal("CHAPECO COMERCIO LTDA", empresa.RazaoSocial);
        }

        [Fact(DisplayName = "Deve retornar com endereço preenchido")]
        public void DeveRetornarComEnderecoPreenchido()
        {
            var endereco = new Endereco("89801-101", "Rua Guaporé - D", "de 631/632 a 1201/1202", "residente Médici", "Chapecó", "sc");
            var empresa = new Empresa(null, "chapecó comércio ltda", "1234", "17.307.005/0001-64", null, null, "", "");
            empresa.AddEndereco(endereco);

            Assert.Equal("RUA GUAPORE - D", empresa.Endereco.Logradouro);
            Assert.Equal("89801101", empresa.Endereco.CEP);
        }

        [Fact(DisplayName = "Deve retornar os dados completos")]
        public void DeveRetornarDadosCompletos()
        {
            var endereco = new Endereco("89801-101", "Rua Guaporé - D", "de 631/632 a 1201/1202", "residente Médici", "Chapecó", "sc");
            var email = new Email("joelitoncf@gmail.com");
            var celular = new Telefone("(049)98802-0959", ETelefone.Celular, true);
            var empresa = new Empresa(1, "chapecó comércio ltda", "1234", "17.307.005/0001-64", 12345, 12345, "www.teste.com.br", "sem-imagem");
            empresa.AddEndereco(endereco);
            empresa.AddEmail(email);
            empresa.AddTelefone(celular);

            Assert.Equal(1, empresa.Id);
            Assert.Equal("1234", empresa.CodigoIbge);
            Assert.Equal(12345, empresa.IE);
            Assert.Equal(12345, empresa.IM);
            Assert.Equal("RUA GUAPORE - D", empresa.Endereco.Logradouro);
            Assert.Equal("89801101", empresa.Endereco.CEP);
            Assert.Equal("joelitoncf@gmail.com", empresa.Email.Endereco);
            Assert.Equal("049988020959", empresa.Telefone.Numero);
        }
    }
}
