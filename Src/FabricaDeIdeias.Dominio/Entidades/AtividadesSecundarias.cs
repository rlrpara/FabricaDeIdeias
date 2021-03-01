using Newtonsoft.Json;

namespace FabricaDeIdeias.Dominio.Entidades
{
    public class AtividadesSecundarias
    {
        [JsonProperty("code")]
        public int Codigo { get; set; }

        [JsonProperty("text")]
        public int Descricao { get; set; }
    }
}
