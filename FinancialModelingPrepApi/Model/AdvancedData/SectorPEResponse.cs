using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.AdvancedData
{
    public class SectorPEResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("pe")]
        public string Pe { get; set; }
    }
}
