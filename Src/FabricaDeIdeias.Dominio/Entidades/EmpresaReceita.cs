using Newtonsoft.Json;
using System;

namespace FabricaDeIdeias.Dominio.Entidades
{
    public class EmpresaReceita
    {
        [JsonProperty("data_situacao")]
        public DateTime DataSituacao { get; set; }
        
        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("nome")]
        public string RazaoSocial { get; set; }

        [JsonProperty("uf")]
        public string UF { get; set; }

        [JsonProperty("telefone")]
        public string Telefone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("atividades_secundarias")]
        public AtividadesSecundarias Atividades { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("cep")]
        public string CEP { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("porte")]
        public string Porte { get; set; }

        [JsonProperty("abertura")]
        public DateTime DataAbertura { get; set; }

        [JsonProperty("natureza_juridica")]
        public string Natureza { get; set; }

        [JsonProperty("fantasia")]
        public string NomeFantasia { get; set; }

        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }
    }
}
