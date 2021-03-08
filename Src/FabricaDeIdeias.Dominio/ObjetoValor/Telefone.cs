using FabricaDeIdeias.Dominio.Enum;
using FabricaDeIdeias.Dominio.ExtensionMethods;
using FluentValidator;

namespace FabricaDeIdeias.Dominio.ObjetoValor
{
    public class Telefone : Notifiable
    {

        public Telefone(
            string numero,
            ETelefone tipoTelefone,
            bool whatsapp
        ) 
        {
            if (!string.IsNullOrWhiteSpace(numero) && !RegexUtilities.IsValidPhoneNumber(numero))
                AddNotification("Numero", "Número obrigatório");

            Numero = numero.ApenasNumeros();
            TipoTelefone = tipoTelefone;
            Whatsapp = whatsapp;
        }
        public string Numero { get; private set; }
        public ETelefone TipoTelefone { get; private set; }
        public bool Whatsapp { get; private set; }
    }
}
