using FabricaDeIdeias.Dominio.ObjetoValor;
using System;

namespace FabricaDeIdeias.Dominio.Entidades
{
    public class Usuario
    {
        private Email _email;

        public Usuario(
            int? id,
            string nome,
            string senha,
            Email email
        )
        {
            if (string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("Senha é obrigatória");

            Id = id;
            Nome = nome;
            Senha = Criptografia.Codifica(senha);
            _email = email;
        }
        public int? Id { get; private set; }
        public string Nome { get; private set; }
        public Email Email { get { return _email; } }
        public string Senha { get; private set; }
    }
}
