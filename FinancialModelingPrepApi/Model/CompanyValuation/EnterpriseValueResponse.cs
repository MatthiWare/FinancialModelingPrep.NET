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
        public double StockPrice { get; set; }

        [JsonPropertyName("numberOfShares")]
        public long NumberOfShares { get; set; }

        [JsonPropertyName("marketCapitalization")]
        public double MarketCapitalization { get; set; }

        [JsonPropertyName("minusCashAndCashEquivalents")]
        public long MinusCashAndCashEquivalents { get; set; }

        [JsonPropertyName("addTotalDebt")]
        public long AddTotalDebt { get; set; }

        [JsonPropertyName("enterpriseValue")]
        public double EnterpriseValue { get; set; }
    }
}
