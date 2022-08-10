using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Statistics
{
    public class AnalystEstimateItem
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("estimatedRevenueLow")]
        public decimal EstimatedRevenueLow { get; set; }

        [JsonPropertyName("estimatedRevenueHigh")]
        public decimal EstimatedRevenueHigh { get; set; }

        [JsonPropertyName("estimatedRevenueAvg")]
        public decimal EstimatedRevenueAvg { get; set; }

        [JsonPropertyName("estimatedEbitdaLow")]
        public decimal EstimatedEbitdaLow { get; set; }

        [JsonPropertyName("estimatedEbitdaHigh")]
        public decimal EstimatedEbitdaHigh { get; set; }

        [JsonPropertyName("estimatedEbitdaAvg")]
        public decimal EstimatedEbitdaAvg { get; set; }

        [JsonPropertyName("estimatedEbitLow")]
        public decimal EstimatedEbitLow { get; set; }

        [JsonPropertyName("estimatedEbitHigh")]
        public decimal EstimatedEbitHigh { get; set; }

        [JsonPropertyName("estimatedEbitAvg")]
        public decimal EstimatedEbitAvg { get; set; }

        [JsonPropertyName("estimatedNetIncomeLow")]
        public decimal EstimatedNetIncomeLow { get; set; }

        [JsonPropertyName("estimatedNetIncomeHigh")]
        public decimal EstimatedNetIncomeHigh { get; set; }

        [JsonPropertyName("estimatedNetIncomeAvg")]
        public decimal EstimatedNetIncomeAvg { get; set; }

        [JsonPropertyName("estimatedSgaExpenseLow")]
        public decimal EstimatedSgaExpenseLow { get; set; }

        [JsonPropertyName("estimatedSgaExpenseHigh")]
        public decimal EstimatedSgaExpenseHigh { get; set; }

        [JsonPropertyName("estimatedSgaExpenseAvg")]
        public decimal EstimatedSgaExpenseAvg { get; set; }

        [JsonPropertyName("estimatedEpsAvg")]
        public decimal EstimatedEpsAvg { get; set; }

        [JsonPropertyName("estimatedEpsHigh")]
        public decimal EstimatedEpsHigh { get; set; }

        [JsonPropertyName("estimatedEpsLow")]
        public decimal EstimatedEpsLow { get; set; }

        [JsonPropertyName("numberAnalystEstimatedRevenue")]
        public int NumberAnalystEstimatedRevenue { get; set; }

        [JsonPropertyName("numberAnalystsEstimatedEps")]
        public int NumberAnalystsEstimatedEps { get; set; }
    }
}
