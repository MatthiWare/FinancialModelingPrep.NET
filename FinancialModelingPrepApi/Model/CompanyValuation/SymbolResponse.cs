using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class SymbolResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("exchangeShortName")]
        public string ExchangeShortName { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
