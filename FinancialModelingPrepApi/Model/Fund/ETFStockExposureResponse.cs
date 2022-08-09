using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Fund
{
    public class ETFStockExposureResponse
    {
        [JsonPropertyName("etfSymbol")]
        public string EtfSymbol { get; set; }

        [JsonPropertyName("assetExposure")]
        public string AssetExposure { get; set; }

        [JsonPropertyName("sharesNumber")]
        public int SharesNumber { get; set; }

        [JsonPropertyName("weightPercentage")]
        public double WeightPercentage { get; set; }

        [JsonPropertyName("marketValue")]
        public double MarketValue { get; set; }
    }
}
