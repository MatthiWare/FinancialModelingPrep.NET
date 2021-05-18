using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrepApi.Model.CompanyValuation
{
    public class HistoricalDailyDCFResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("dcf")]
        public double Dcf { get; set; }
    }
}
