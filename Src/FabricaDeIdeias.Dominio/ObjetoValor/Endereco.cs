namespace FabricaDeIdeias.Dominio.ObjetoValor
{
    public class Endereco
    {
        public Endereco(
            string cep,
            string logradouro,
            string complemento,
            string bairro,
            string municipio,
            string uF
        )
        {
            CEP = cep;
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            UF = uF;

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
