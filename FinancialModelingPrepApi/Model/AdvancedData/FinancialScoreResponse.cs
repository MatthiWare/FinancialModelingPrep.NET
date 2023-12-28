using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.AdvancedData
{
    public class FinancialScoreResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("altmanZScore")]
        public double AltmanZScore { get; set; }

        [JsonPropertyName("piotroskiScore")]
        public int PiotroskiScore { get; set; }

        [JsonPropertyName("workingCapital")]
        public long WorkingCapital { get; set; }

        [JsonPropertyName("totalAssets")]
        public long TotalAssets { get; set; }

        [JsonPropertyName("retainedEarnings")]
        public long RetainedEarnings { get; set; }

        [JsonPropertyName("ebit")]
        public long Ebit { get; set; }

        [JsonPropertyName("marketCap")]
        public long MarketCap { get; set; }

        [JsonPropertyName("totalLiabilities")]
        public long TotalLiabilities { get; set; }

        [JsonPropertyName("revenue")]
        public long Revenue { get; set; }
    }
}
