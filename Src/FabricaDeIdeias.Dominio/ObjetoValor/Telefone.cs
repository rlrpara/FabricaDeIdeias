﻿using FabricaDeIdeias.Dominio.Enum;
using FabricaDeIdeias.Dominio.ExtensionMethods;

namespace FabricaDeIdeias.Dominio.ObjetoValor
{
    public class Telefone
    {
        public Telefone(
            string numero,
            ETelefone tipoTelefone,
            bool whatsapp
        ) 
        {
            Numero = numero.ApenasNumeros();
            TipoTelefone = tipoTelefone;
            Whatsapp = whatsapp;
        }
        public string Numero { get; private set; }
        public ETelefone TipoTelefone { get; private set; }
        public bool Whatsapp { get; private set; }
    }
}
