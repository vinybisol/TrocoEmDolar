using Newtonsoft.Json;

namespace TrocoEmDolar.Modelos
{
    internal class ModeloCotacao
    {
        [JsonProperty("code")]
        public string CodigoMoeda { get; set; }
        [JsonProperty("codein")]
        public string CodigoMoedaComparada { get; set; }
        [JsonProperty("ask")]
        public decimal Cotacao { get; set; }
        [JsonProperty("create_date")]
        public DateTime DataAtualizado { get; set; }
    }
}
