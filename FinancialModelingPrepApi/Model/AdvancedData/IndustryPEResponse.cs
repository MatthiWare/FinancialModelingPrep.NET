using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.AdvancedData
{
    public class IndustryPEResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("pe")]
        public string Pe { get; set; }
    }
}
