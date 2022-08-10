using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Model.AdvancedData
{
    public class FinancialScoreResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("altmanZScore")]
        public decimal AltmanZScore { get; set; }

        [JsonPropertyName("piotroskiScore")]
        public decimal PiotroskiScore { get; set; }

        [JsonPropertyName("workingCapital")]
        public decimal WorkingCapital { get; set; }

        [JsonPropertyName("totalAssets")]
        public decimal TotalAssets { get; set; }

        [JsonPropertyName("retainedEarnings")]
        public decimal RetainedEarnings { get; set; }

        [JsonPropertyName("ebit")]
        public decimal Ebit { get; set; }

        [JsonPropertyName("totalLiabilities")]
        public decimal TotalLiabilities { get; set; }

        [JsonPropertyName("revenue")]
        public decimal Revenue { get; set; }
    }
}
