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
        public double Numerator { get; set; }

        [JsonPropertyName("denominator")]
        public double Denominator { get; set; }
    }
}
