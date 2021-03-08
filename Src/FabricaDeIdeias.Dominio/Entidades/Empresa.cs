using FabricaDeIdeias.Dominio.ExtensionMethods;
using FabricaDeIdeias.Dominio.ObjetoValor;
using FluentValidator;
using FluentValidator.Validation;

namespace FabricaDeIdeias.Dominio.Entidades
{
    public class Empresa : Notifiable
    {
        private Endereco _endereco;
        private Telefone _telefone;
        private Email _email;

        public Empresa(
            int? id,
            string razaoSocial,
            string codigoIbge,
            string cnpj,
            int? ie,
            int? im,
            string site,
            string imagem,
            Endereco endereco,
            Telefone telefone,
            Email email
        )
        {
            Id = id;
            RazaoSocial = razaoSocial.RemoverAcentos();
            CodigoIbge = codigoIbge;
            CNPJ = cnpj.ApenasNumeros();
            IE = ie;
            IM = im;
            Site = site;
            Imagem = imagem;
            _endereco = endereco;
            _telefone = telefone;
            _email = email;

            AddNotifications(new ValidationContract()
                .HasMinLen(razaoSocial, 4, "RazaoSocial", "A Razão Social deve conter no mínimo 3 caracteres")
                .IsFalse(cnpj.IsCnpj(), "CNPJ", "O CNPJ deve ser válido")
                .HasLen(endereco.CEP, 8, "CEP", "O CEP deve ter 8 caracteres")
            );

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
    }
}
