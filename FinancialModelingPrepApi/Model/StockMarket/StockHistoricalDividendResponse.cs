using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Model.StockMarket
{
    public class StockDividendResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("historical")]
        public List<StockHistoricalDividendResponse> HistoricalDividends { get; set; }
    }

    public class StockHistoricalDividendResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }
        [JsonPropertyName("label")]
        public string Label { get; set; }
        [JsonPropertyName("adjDividend")]
        public string AdjDividend { get; set; }
        [JsonPropertyName("dividend")]
        public string Dividend { get; set; }
        [JsonPropertyName("recordDate")]
        public string RecordDate { get; set; }
        [JsonPropertyName("paymentDate")]
        public string PaymentDate { get; set; }
        [JsonPropertyName("declarationDate")]
        public string DeclarationDate { get; set; }
    }
}
