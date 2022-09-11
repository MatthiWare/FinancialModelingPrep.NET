using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Calendars
{
    public class IPOCalendarResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("actions")]
        public string Actions { get; set; }

        [JsonPropertyName("shares")]
        public long? Shares { get; set; }

        [JsonPropertyName("priceRange")]
        public string PriceRange { get; set; }

        [JsonPropertyName("marketCap")]
        public decimal? MarketCap { get; set; }
    }
}
