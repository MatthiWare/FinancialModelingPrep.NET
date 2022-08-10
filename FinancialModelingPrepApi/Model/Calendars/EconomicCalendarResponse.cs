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
        public decimal? Actual { get; set; }

        [JsonPropertyName("previous")]
        public decimal? Previous { get; set; }

        [JsonPropertyName("change")]
        public decimal? Change { get; set; }

        [JsonPropertyName("changePercentage")]
        public decimal? ChangePercentage { get; set; }

        [JsonPropertyName("estimate")]
        public decimal? Estimate { get; set; }
    }
}
