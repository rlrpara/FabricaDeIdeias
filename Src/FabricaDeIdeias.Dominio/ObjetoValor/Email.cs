using System;

namespace FabricaDeIdeias.Dominio.ObjetoValor
{
    public class Email
    {
        private string _endereco;
        public Email(string endereco) 
        {
            if (!string.IsNullOrWhiteSpace(endereco) && !RegexUtilities.IsValidEmail(endereco))
                throw new Exception("Email inválido");

            _endereco = endereco;
               
        }
        public string Endereco { get { return _endereco; } }
    }
}
