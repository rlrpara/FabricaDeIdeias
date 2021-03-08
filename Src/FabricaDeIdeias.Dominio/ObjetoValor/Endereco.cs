using FabricaDeIdeias.Dominio.ExtensionMethods;
using FluentValidator;

namespace FabricaDeIdeias.Dominio.ObjetoValor
{
    public class Endereco : Notifiable
    {
        public Endereco(
            string cep,
            string logradouro,
            string complemento,
            string bairro,
            string municipio,
            string uf
        )
        {
            CEP = cep.ApenasNumeros();
            Logradouro = logradouro.RemoverAcentos();
            Complemento = complemento.RemoverAcentos();
            Bairro = bairro.RemoverAcentos();
            Municipio = municipio.RemoverAcentos();
            UF = uf.RemoverAcentos();

        }
        public string CEP { get; private set; }
        public string Logradouro { get; private set; }
        public int? Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Municipio { get; private set; }
        public string UF { get; private set; }
    }
}
