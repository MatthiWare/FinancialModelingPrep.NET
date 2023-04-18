using MatthiWare.FinancialModelingPrep.Abstractions.Model;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.StockTimeSeries
{
    public class HistoricalPriceResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("historical")]
        public List<HistoricalPriceItem> Historical { get; set; }
    }

    public class HistoricalPriceItem : IHistoricalQuote
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("open")]
        public decimal? Open { get; set; }

        [JsonPropertyName("high")]
        public decimal? High { get; set; }

        [JsonPropertyName("low")]
        public decimal? Low { get; set; }

        [JsonPropertyName("close")]
        public decimal Close { get; set; }

        [JsonPropertyName("adjClose")]
        public decimal AdjClose { get; set; }

        [JsonPropertyName("volume")]
        public decimal Volume { get; set; }

        [JsonPropertyName("unadjustedVolume")]
        public decimal UnadjustedVolume { get; set; }

        [JsonPropertyName("change")]
        public decimal? Change { get; set; }

        [JsonPropertyName("changePercent")]
        public decimal? ChangePercent { get; set; }

        [JsonPropertyName("vwap")]
        public decimal Vwap { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("changeOverTime")]
        public decimal ChangeOverTime { get; set; }
    }
}
