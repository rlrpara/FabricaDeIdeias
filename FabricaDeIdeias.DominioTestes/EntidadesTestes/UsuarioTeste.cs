using FabricaDeIdeias.Dominio;
using FabricaDeIdeias.Dominio.Entidades;
using FabricaDeIdeias.Dominio.ObjetoValor;
using Xunit;

namespace FabricaDeIdeias.DominioTestes.EntidadesTestes
{
    [Trait("Entidade", "Usuario")]
    public class UsuarioTeste
    {
        [Fact(DisplayName = "Gerar nova instância")]
        public void GerarNovaInstância()
        {
            var usuario = new Usuario(null, "Rodrigo Ribeiro", "12345", null);

            Assert.True(usuario != null);
        }

        [Fact(DisplayName = "Deve validar instancia de email preenchida")]
        public void DeveValidarInstanciaEmailPreenchida()
        {
            var email = new Email("rlr.para@gmail.com");

            Assert.True(RegexUtilities.IsValidEmail(email.Endereco));
        }

        [Fact(DisplayName = "Deve validar instancia vazia")]
        public void DeveValidarInstanciaVazia()
        {
            var email = new Email(null);

            Assert.True(email != null);
        }
    }
}
