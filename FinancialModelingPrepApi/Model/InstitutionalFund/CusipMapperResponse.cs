using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.InstitutionalFund
{
    public class CusipMapperResponse
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }

        [JsonPropertyName("cusip")]
        public string Cusip { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }
    }
}
