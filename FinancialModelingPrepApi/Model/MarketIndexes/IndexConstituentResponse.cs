using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.MarketIndexes
{
    public class IndexConstituentResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("subSector")]
        public string SubSector { get; set; }

        [JsonPropertyName("headQuarter")]
        public string HeadQuarter { get; set; }

        [JsonPropertyName("dateFirstAdded")]
        public string DateFirstAdded { get; set; }

        [JsonPropertyName("cik")]
        public string Cik { get; set; }

        [JsonPropertyName("founded")]
        public string Founded { get; set; }
    }
}
