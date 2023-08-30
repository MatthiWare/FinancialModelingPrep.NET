using MatthiWare.FinancialModelingPrep.Abstractions.Model;
using System;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Forex
{
    public class ForexHistoricalQuoteResponse : IHistoricalQuote
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("open")]
        public double? Open { get; set; }

        [JsonPropertyName("high")]
        public double? High { get; set; }

        [JsonPropertyName("low")]
        public double? Low { get; set; }

        [JsonPropertyName("close")]
        public double Close { get; set; }

        [JsonPropertyName("change")]
        public double? Change { get; set; }
        [JsonPropertyName("volume")]
        public double Volume { get; set; }

        [JsonPropertyName("changePercent")]
        public double? ChangePercent { get; set; }
    }
}
