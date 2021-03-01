using FabricaDeIdeias.Dominio.ObjetoValor;

namespace FabricaDeIdeias.Dominio.Entidades
{
    public class Empresa
    {
        private Endereco _endereco;
        private Telefone _telefone;
        private Email _email;
        public Empresa(
            int? id,
            string razaoSocial,
            string codigoIbge,
            string cNPJ,
            string site,
            string imagem
        )
        {
            Id = id;
            RazaoSocial = razaoSocial;
            CodigoIbge = codigoIbge;
            CNPJ = cNPJ;
            Site = site;
            Imagem = imagem;

        }
        public int? Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public string CodigoIbge { get; private set; }
        public string CNPJ { get; private set; }
        public int? IE { get; private set; }
        public int? IM { get; private set; }
        public Endereco Endereco { get { return _endereco; } }
        public Telefone Telefone { get { return _telefone; } }
        public Email Email { get { return _email; } }
        public string Site { get; private set; }
        public string Imagem { get; private set; }

        public void AddEndereco(Endereco endereco)
        {
            _endereco = endereco;
        }

        public void AddTelefone(Telefone telefone)
        {
            _telefone = telefone;
        }

        public void AddEmail(Email email)
        {
            _email = email;
        }
    }
}
