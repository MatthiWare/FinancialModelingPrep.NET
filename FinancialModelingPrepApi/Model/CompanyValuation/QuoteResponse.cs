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
        public decimal? Price { get; set; }

        [JsonPropertyName("changesPercentage")]
        public decimal? ChangesPercentage { get; set; }

        [JsonPropertyName("change")]
        public decimal? Change { get; set; }

        [JsonPropertyName("dayLow")]
        public decimal? DayLow { get; set; }

        [JsonPropertyName("dayHigh")]
        public decimal? DayHigh { get; set; }

        [JsonPropertyName("yearHigh")]
        public decimal? YearHigh { get; set; }

        [JsonPropertyName("yearLow")]
        public decimal? YearLow { get; set; }

        [JsonPropertyName("marketCap")]
        public decimal? MarketCap { get; set; }

        [JsonPropertyName("priceAvg50")]
        public decimal? PriceAvg50 { get; set; }

        [JsonPropertyName("priceAvg200")]
        public decimal? PriceAvg200 { get; set; }

        [JsonPropertyName("volume")]
        public long? Volume { get; set; }

        [JsonPropertyName("avgVolume")]
        public long? AvgVolume { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("open")]
        public decimal? Open { get; set; }

        [JsonPropertyName("previousClose")]
        public decimal? PreviousClose { get; set; }

        [JsonPropertyName("eps")]
        public decimal? Eps { get; set; }

        [JsonPropertyName("pe")]
        public decimal? Pe { get; set; }

        [JsonPropertyName("earningsAnnouncement")]
        public string EarningsAnnouncement { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long? SharesOutstanding { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }
    }
}
