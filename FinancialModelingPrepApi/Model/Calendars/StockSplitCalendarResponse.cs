using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Calendars
{
    public class StockSplitCalendarResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("numerator")]
        public decimal Numerator { get; set; }

        [JsonPropertyName("denominator")]
        public decimal Denominator { get; set; }
    }
}
