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
        public decimal Open { get; set; }

        [JsonPropertyName("high")]
        public decimal? High { get; set; }

        [JsonPropertyName("low")]
        public decimal? Low { get; set; }

        [JsonPropertyName("close")]
        public decimal Close { get; set; }

        [JsonPropertyName("change")]
        public decimal? Change { get; set; }

        [JsonPropertyName("changePercent")]
        public decimal? ChangePercent { get; set; }
    }
}
