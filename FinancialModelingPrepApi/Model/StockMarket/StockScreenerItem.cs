using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.StockMarket
{ 
    public class StockScreenerItem
    {
        [JsonPropertyName("symbol")]
        public string Ticker { get; set; }

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        [JsonPropertyName("marketCap")]
        public decimal MarketCap { get; set; }

        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("beta")]
        public decimal Beta { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("lastAnnualDividend")]
        public decimal LastAnnualDividend { get; set; }

        [JsonPropertyName("volume")]
        public int Volume { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("exchangeShortName")]
        public string ExchangeShortName { get; set; }
    }
}
