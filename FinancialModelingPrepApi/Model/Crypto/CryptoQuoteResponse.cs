using MatthiWare.FinancialModelingPrep.Abstractions.Model;
using System;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Crypto
{
    public class CryptoQuoteResponse : ICurrentQuote
    {
        // Crypto
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("open")]
        public double? Open { get; set; }

        [JsonPropertyName("price")]
        public double? Price { get; set; }

        [JsonPropertyName("previousclose")]
        public double? PreviousClose { get; set; }

        [JsonPropertyName("daylow")]
        public double? DayLow { get; set; }

        [JsonPropertyName("dayhigh")]
        public double? DayHigh { get; set; }

        [JsonPropertyName("yearlow")]
        public double? YearlyLow { get; set; }

        [JsonPropertyName("yearhigh")]
        public double? YearlyHigh { get; set; }

        [JsonPropertyName("priceavg50")]
        public double? PriceAvg50 { get; set; }

        [JsonPropertyName("priceavg200")]
        public double? PriceAvg200 { get; set; }

        [JsonPropertyName("change")]
        public double? Change { get; set; }

        [JsonPropertyName("changespercentage")]
        public double? ChangesPercentage { get; set; }

        [JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }
        [JsonPropertyName("volume")]
        public double? Volume { get; set; }
        [JsonPropertyName("avgVolume")]
        public double? AvgVolume { get; set; }

        // Not used by Forex or Futures.

        [JsonPropertyName("eps")]
        public double? Eps { get; set; }

        [JsonPropertyName("pe")]
        public double? Pe { get; set; }

        [JsonPropertyName("earningsAnnouncement")]
        public string? EarningsAnnouncement { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double? SharesOutstanding { get; set; }

        [JsonPropertyName("marketCap")]
        public double? MarketCap { get; set; }
    }
}
