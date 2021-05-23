using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Calendars
{
    public class EconomicCalendarResponse
    {
        [JsonPropertyName("event")]
        public string Event { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("actual")]
        public double? Actual { get; set; }

        [JsonPropertyName("previous")]
        public double? Previous { get; set; }

        [JsonPropertyName("change")]
        public double? Change { get; set; }

        [JsonPropertyName("changePercentage")]
        public double? ChangePercentage { get; set; }

        [JsonPropertyName("estimate")]
        public double? Estimate { get; set; }
    }
}
