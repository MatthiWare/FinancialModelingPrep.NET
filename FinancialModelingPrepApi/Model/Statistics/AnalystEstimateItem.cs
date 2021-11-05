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
        public double EstimatedRevenueLow { get; set; }

        [JsonPropertyName("estimatedRevenueHigh")]
        public double EstimatedRevenueHigh { get; set; }

        [JsonPropertyName("estimatedRevenueAvg")]
        public double EstimatedRevenueAvg { get; set; }

        [JsonPropertyName("estimatedEbitdaLow")]
        public double EstimatedEbitdaLow { get; set; }

        [JsonPropertyName("estimatedEbitdaHigh")]
        public double EstimatedEbitdaHigh { get; set; }

        [JsonPropertyName("estimatedEbitdaAvg")]
        public double EstimatedEbitdaAvg { get; set; }

        [JsonPropertyName("estimatedEbitLow")]
        public double EstimatedEbitLow { get; set; }

        [JsonPropertyName("estimatedEbitHigh")]
        public double EstimatedEbitHigh { get; set; }

        [JsonPropertyName("estimatedEbitAvg")]
        public double EstimatedEbitAvg { get; set; }

        [JsonPropertyName("estimatedNetIncomeLow")]
        public double EstimatedNetIncomeLow { get; set; }

        [JsonPropertyName("estimatedNetIncomeHigh")]
        public double EstimatedNetIncomeHigh { get; set; }

        [JsonPropertyName("estimatedNetIncomeAvg")]
        public double EstimatedNetIncomeAvg { get; set; }

        [JsonPropertyName("estimatedSgaExpenseLow")]
        public double EstimatedSgaExpenseLow { get; set; }

        [JsonPropertyName("estimatedSgaExpenseHigh")]
        public double EstimatedSgaExpenseHigh { get; set; }

        [JsonPropertyName("estimatedSgaExpenseAvg")]
        public double EstimatedSgaExpenseAvg { get; set; }

        [JsonPropertyName("estimatedEpsAvg")]
        public double EstimatedEpsAvg { get; set; }

        [JsonPropertyName("estimatedEpsHigh")]
        public double EstimatedEpsHigh { get; set; }

        [JsonPropertyName("estimatedEpsLow")]
        public double EstimatedEpsLow { get; set; }

        [JsonPropertyName("numberAnalystEstimatedRevenue")]
        public int NumberAnalystEstimatedRevenue { get; set; }

        [JsonPropertyName("numberAnalystsEstimatedEps")]
        public int NumberAnalystsEstimatedEps { get; set; }
    }
}
