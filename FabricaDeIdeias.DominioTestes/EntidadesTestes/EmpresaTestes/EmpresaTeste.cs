using FabricaDeIdeias.Dominio.Entidades;
using FabricaDeIdeias.Dominio.Enum;
using FabricaDeIdeias.Dominio.ObjetoValor;
using Xunit;

namespace FabricaDeIdeias.DominioTestes.EntidadesTestes.EmpresaTestes
{
    [Trait("Entidade", "Empresa")]
    public class EmpresaTeste
    {
        [Fact(DisplayName = "Gerar nova instância")]
        public void GerarNovaInstância()
        {
            var endereco = new Endereco("89801-101", "", "", "", "", "");
            var empresa = new Empresa(null, "EMPRESA DE TESTES", "", "17.307.005/0001-64", null, null, null, null,  endereco, null, null);

            Assert.True(empresa != null);
        }

        [Fact(DisplayName = "Deve retornar apenas numeros no cnpj")]
        public void DeveRetornarApenasNumeroNoCnpj()
        {
            var endereco = new Endereco("89801-101", "", "", "", "", "");
            var empresa = new Empresa(null, "EMPRESA DE TESTES", "", "17.307.005/0001-64", null, null, null, null, endereco, null, null);

            Assert.Equal("17307005000164", empresa.CNPJ);
        }

        [Fact(DisplayName = "Deve retornar a razão social maúscula e sem acentos ")]
        public void DeveRetornarRazaoSocialMaiusculaSemAcentos()
        {
            var endereco = new Endereco("89801-101", "", "", "", "", "");
            var empresa = new Empresa(null, "chapecó comércio ltda", "1234", "17.307.005/0001-64", null, null, null, null, endereco, null, null);

            Assert.Equal("CHAPECO COMERCIO LTDA", empresa.RazaoSocial);
        }

        [Fact(DisplayName = "Deve retornar notificacao por telefone invalido")]
        public void DeveRetornarNotificacaoTelefoneInvalido()
        {
            var endereco = new Endereco("89801-101", "", "", "", "", "");
            var telefone = new Telefone("988020959", ETelefone.Celular, true);
            var empresa = new Empresa(null, "chapecó comércio ltda", "1234", "17.307.005/0001-64", null, null, null, null, endereco, telefone, null);

            Assert.False(empresa.Telefone.Valid);
        }

        [Fact(DisplayName = "Deve retornar notificacao por telefone valido")]
        public void DeveRetornarNotificacaoTelefoneValido()
        {
            var endereco = new Endereco("89801-101", "", "", "", "", "");
            var telefone = new Telefone("49988020959", ETelefone.Celular, true);
            var empresa = new Empresa(null, "chapecó comércio ltda", "1234", "17.307.005/0001-64", null, null, null, null, endereco, telefone, null);

            Assert.True(empresa.Telefone.Valid);
        }

        [Fact(DisplayName = "Deve retornar com endereço preenchido")]
        public void DeveRetornarComEnderecoPreenchido()
        {
            var endereco = new Endereco("89801-101", "Rua Guaporé - D", "de 631/632 a 1201/1202", "residente Médici", "Chapecó", "sc");
            var empresa = new Empresa(null, "chapecó comércio ltda", "1234", "17.307.005/0001-64", null, null, null, null, endereco, null, null);

            Assert.Equal("RUA GUAPORE - D", empresa.Endereco.Logradouro);
            Assert.Equal("89801101", empresa.Endereco.CEP);
        }

        [Fact(DisplayName = "Deve retornar os dados completos")]
        public void DeveRetornarDadosCompletos()
        {
            var endereco = new Endereco("89801-101", "Rua Guaporé - D", "de 631/632 a 1201/1202", "residente Médici", "Chapecó", "sc");
            var email = new Email("joelitoncf@gmail.com");
            var celular = new Telefone("(049)98802-0959", ETelefone.Celular, true);
            var empresa = new Empresa(1, "chapecó comércio ltda", "1234", "17.307.005/0001-64", 12345, 12345, "www.teste.com.br", "sem-imagem", endereco, celular, email);

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
