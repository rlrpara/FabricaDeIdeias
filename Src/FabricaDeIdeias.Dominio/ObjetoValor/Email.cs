using FluentValidator;

namespace FabricaDeIdeias.Dominio.ObjetoValor
{
    public class Email : Notifiable
    {
        private string _endereco;
        public Email(string endereco) 
        {
            if (!string.IsNullOrWhiteSpace(endereco) && !RegexUtilities.IsValidEmail(endereco))
                AddNotification("Email", "Email inválido");

            _endereco = endereco;
               
        }
        public string Endereco { get { return _endereco; } }
    }
}
