using MatthiWare.FinancialModelingPrep.Abstractions.Model;
using System;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Forex
{
    public class ForexQuoteResponse : ICurrentQuote
    {
        // FX
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("open")]
        public decimal Open { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("previousclose")]
        public decimal PreviousClose { get; set; }

        [JsonPropertyName("daylow")]
        public decimal DayLow { get; set; }

        [JsonPropertyName("dayhigh")]
        public decimal DayHigh { get; set; }

        [JsonPropertyName("yearlow")]
        public decimal YearlyLow { get; set; }

        [JsonPropertyName("yearhigh")]
        public decimal YearlyHigh { get; set; }

        [JsonPropertyName("priceavg50")]
        public decimal PriceAvg50 { get; set; }

        [JsonPropertyName("priceavg200")]
        public decimal PriceAvg200 { get; set; }

        [JsonPropertyName("change")]
        public decimal Change { get; set; }

        [JsonPropertyName("changespercentage")]
        public decimal ChangesPercentage { get; set; }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        // Not used by Forex or Futures.

        [JsonPropertyName("eps")]
        public decimal? Eps { get; set; }

        [JsonPropertyName("pe")]
        public decimal? Pe { get; set; }

        [JsonPropertyName("earningsAnnouncement")]
        public string? EarningsAnnouncement { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long? SharesOutstanding { get; set; }

        [JsonPropertyName("marketCap")]
        public decimal? MarketCap { get; set; }
    }
}
