using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Model
{
    public interface IHistoricalQuote
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("open")]
        public double? Open { get; set; }

        [JsonPropertyName("high")]
        public double? High { get; set; }

        [JsonPropertyName("low")]
        public double? Low { get; set; }

        [JsonPropertyName("close")]
        public double Close { get; set; }

        [JsonPropertyName("change")]
        public double? Change { get; set; }
        [JsonPropertyName("volume")]
        public double Volume { get; set; }

        [JsonPropertyName("changePercent")]
        public double? ChangePercent { get; set; }
    }
}
