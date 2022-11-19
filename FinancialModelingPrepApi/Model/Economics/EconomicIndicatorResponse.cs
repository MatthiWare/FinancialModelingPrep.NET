using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Economics
{
    public class EconomicIndicatorResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }
    }
}
