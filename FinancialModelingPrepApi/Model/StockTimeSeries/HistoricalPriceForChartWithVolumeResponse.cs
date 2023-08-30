using MatthiWare.FinancialModelingPrep.Abstractions.Model;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.StockTimeSeries
{
    public class HistoricalPriceForChartWithVolumeResponse : IHistoricalQuote
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

        [JsonPropertyName("changePercent")]
        public double? ChangePercent { get; set; }

        [JsonPropertyName("volume")]
        public double Volume { get; set; }

        [JsonPropertyName("adjClose")]
        public double AdjClose { get; set; }

        [JsonPropertyName("unadjustedVolume")]
        public double UnadjustedVolume { get; set; }

        [JsonPropertyName("vwap")]
        public double VWAP { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("changeOvertime")]
        public double ChangeOvertime { get; set; }
    }
}
