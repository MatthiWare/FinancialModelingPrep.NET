using System;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class QuoteResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("price")]
        public double? Price { get; set; }

        [JsonPropertyName("changesPercentage")]
        public double? ChangesPercentage { get; set; }

        [JsonPropertyName("change")]
        public double? Change { get; set; }

        [JsonPropertyName("dayLow")]
        public double? DayLow { get; set; }

        [JsonPropertyName("dayHigh")]
        public double? DayHigh { get; set; }

        [JsonPropertyName("yearHigh")]
        public double? YearHigh { get; set; }

        [JsonPropertyName("yearLow")]
        public double? YearLow { get; set; }

        [JsonPropertyName("marketCap")]
        public double? MarketCap { get; set; }

        [JsonPropertyName("priceAvg50")]
        public double? PriceAvg50 { get; set; }

        [JsonPropertyName("priceAvg200")]
        public double? PriceAvg200 { get; set; }

        [JsonPropertyName("volume")]
        public long? Volume { get; set; }

        [JsonPropertyName("avgVolume")]
        public long? AvgVolume { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("open")]
        public double? Open { get; set; }

        [JsonPropertyName("previousClose")]
        public double? PreviousClose { get; set; }

        [JsonPropertyName("eps")]
        public double? Eps { get; set; }

        [JsonPropertyName("pe")]
        public double? Pe { get; set; }

        [JsonPropertyName("earningsAnnouncement")]
        public string EarningsAnnouncement { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long? SharesOutstanding { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }
    }
}
