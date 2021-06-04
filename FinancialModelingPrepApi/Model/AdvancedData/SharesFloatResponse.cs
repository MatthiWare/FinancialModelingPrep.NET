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
        public double FreeFloat { get; set; }

        [JsonPropertyName("floatShares")]
        public double FloatShares { get; set; }

        [JsonPropertyName("outstandingShares")]
        public double OutstandingShares { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
