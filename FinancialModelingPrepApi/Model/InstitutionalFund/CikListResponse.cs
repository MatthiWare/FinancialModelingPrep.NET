using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.InstitutionalFund
{
    public class CikListResponse
    {
        [JsonPropertyName("cik")]
        public string Cik { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}