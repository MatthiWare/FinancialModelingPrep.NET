using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.StockTimeSeries
{
    public class HistoricalPriceForLineChartResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("historical")]
        public List<HistoricalPriceForLineChartItem> Historical { get; set; }
    }

    public class HistoricalPriceForLineChartItem
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("close")]
        public double Close { get; set; }
    }
}
