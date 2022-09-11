using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.AdvancedData
{
    public class SharesFloatResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("freeFloat")]
        public decimal FreeFloat { get; set; }

        [JsonPropertyName("floatShares")]
        public decimal FloatShares { get; set; }

        [JsonPropertyName("outstandingShares")]
        public decimal OutstandingShares { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
