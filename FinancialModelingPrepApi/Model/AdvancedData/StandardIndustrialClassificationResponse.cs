using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.AdvancedData
{
    public class StandardIndustrialClassificationResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("cik")]
        public string Cik { get; set; }

        [JsonPropertyName("sicCode")]
        public string SicCode { get; set; }

        [JsonPropertyName("industryTitle")]
        public string IndustryTitle { get; set; }

        [JsonPropertyName("businessAdress")]
        public string BusinessAdress { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
