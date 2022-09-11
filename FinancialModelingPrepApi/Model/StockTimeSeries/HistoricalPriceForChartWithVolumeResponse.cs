﻿using MatthiWare.FinancialModelingPrep.Abstractions.Model;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.StockTimeSeries
{
    public class HistoricalPriceForChartWithVolumeResponse : IHistoricalQuote
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

        [JsonPropertyName("volume")]
        public decimal Volume { get; set; }

        [JsonPropertyName("adjClose")]
        public decimal AdjClose { get; set; }

        [JsonPropertyName("unadjustedVolume")]
        public decimal UnadjustedVolume { get; set; }

        [JsonPropertyName("vwap")]
        public decimal VWAP { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("changeOvertime")]
        public decimal ChangeOvertime { get; set; }
    }
}
