using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class EnterpriseValueResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("stockPrice")]
        public decimal StockPrice { get; set; }

        [JsonPropertyName("numberOfShares")]
        public long NumberOfShares { get; set; }

        [JsonPropertyName("marketCapitalization")]
        public decimal MarketCapitalization { get; set; }

        [JsonPropertyName("minusCashAndCashEquivalents")]
        public decimal MinusCashAndCashEquivalents { get; set; }

        [JsonPropertyName("addTotalDebt")]
        public decimal AddTotalDebt { get; set; }

        [JsonPropertyName("enterpriseValue")]
        public decimal EnterpriseValue { get; set; }
    }
}
