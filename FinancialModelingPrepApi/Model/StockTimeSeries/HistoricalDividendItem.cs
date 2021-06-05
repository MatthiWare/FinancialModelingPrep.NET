using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.StockTimeSeries
{
    public class HistoricalDividendItem
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("adjDividend")]
        public double AdjDividend { get; set; }

        [JsonPropertyName("dividend")]
        public double Dividend { get; set; }

        [JsonPropertyName("recordDate")]
        public string RecordDate { get; set; }

        [JsonPropertyName("paymentDate")]
        public string PaymentDate { get; set; }

        [JsonPropertyName("declarationDate")]
        public string DeclarationDate { get; set; }
    }
}
