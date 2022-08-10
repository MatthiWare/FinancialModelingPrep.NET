using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class DCFResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("dcf")]
        public decimal Dcf { get; set; }

        [JsonPropertyName("StockPrice")]
        public decimal StockPrice { get; set; }
    }
}
