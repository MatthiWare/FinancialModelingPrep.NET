using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.StockTimeSeries
{
    public class HistoricalStockSplitItem
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("numerator")]
        public decimal Numerator { get; set; }

        [JsonPropertyName("denominator")]
        public decimal Denominator { get; set; }
    }
}
