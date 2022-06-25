using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class SymbolChangeResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("oldSymbol")]
        public string OldSymbol { get; set; }

        [JsonPropertyName("newSymbol")]
        public string NewSymbol { get; set; }
    }
}
