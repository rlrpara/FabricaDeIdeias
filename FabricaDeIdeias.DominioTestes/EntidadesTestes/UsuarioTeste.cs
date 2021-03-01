using FabricaDeIdeias.Dominio;
using FabricaDeIdeias.Dominio.Entidades;
using FabricaDeIdeias.Dominio.ObjetoValor;
using System;
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

        [Fact(DisplayName = "Deve gerar nova senha encriptografada")]
        public void DeveGerarNovaSenhaEncriptografada()
        {
            var usuario = new Usuario(null, "Rodrigo Ribeiro", "12345", null);

            Assert.True(Criptografia.Compara("12345", usuario.Senha));
        }

        [Fact(DisplayName = "Deve retornar uma excessão quando não informado o email")]
        public void DeveRetornarExcessaoQuandoNaoInformadoEmail()
        {
            Assert.Throws<ArgumentException>(() => new Usuario(null, "Rodrigo Ribeiro", "", null));
        }

        [Fact(DisplayName = "Deve retornar a classe completa")]
        public void DeveRetornarClasseCompleta()
        {
            var email = new Email("rlr.para@gmail.com");
            var usuario = new Usuario(1, "Rodrigo Ribeiro", "12345", email);

            Assert.Equal(1, usuario.Id);
            Assert.Equal("Rodrigo Ribeiro", usuario.Nome);
            Assert.True(Criptografia.Compara("12345", usuario.Senha));
            Assert.Equal("rlr.para@gmail.com", usuario.Email.Endereco);
        }
    }
}
