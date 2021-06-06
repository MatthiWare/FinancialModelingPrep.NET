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

    public class HistoricalPriceItem
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("open")]
        public double Open { get; set; }

        [JsonPropertyName("high")]
        public double High { get; set; }

        [JsonPropertyName("low")]
        public double Low { get; set; }

        [JsonPropertyName("close")]
        public double Close { get; set; }

        [JsonPropertyName("adjClose")]
        public double AdjClose { get; set; }

        [JsonPropertyName("volume")]
        public double Volume { get; set; }

        [JsonPropertyName("unadjustedVolume")]
        public double UnadjustedVolume { get; set; }

        [JsonPropertyName("change")]
        public double Change { get; set; }

        [JsonPropertyName("changePercent")]
        public double ChangePercent { get; set; }

        [JsonPropertyName("vwap")]
        public double Vwap { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("changeOverTime")]
        public double ChangeOverTime { get; set; }
    }
}
