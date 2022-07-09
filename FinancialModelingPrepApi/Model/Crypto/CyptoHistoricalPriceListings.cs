using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Model.Crypto
{
    public class CryptoHistoricalPricePeriodListing
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("open")]
        public decimal Open { get; set; }

        [JsonPropertyName("high")]
        public decimal High { get; set; }

        [JsonPropertyName("low")]
        public decimal Low { get; set; }

        [JsonPropertyName("close")]
        public decimal Close { get; set; }

        [JsonPropertyName("volume")]
        public long Volume { get; set; }
    }

    public class CyptoHistoricalPriceDailyListing
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("open")]
        public decimal Open { get; set; }

        [JsonPropertyName("high")]
        public decimal High { get; set; }

        [JsonPropertyName("low")]
        public decimal Low { get; set; }

        [JsonPropertyName("close")]
        public decimal Close { get; set; }

        [JsonPropertyName("adjClose")]
        public decimal AdjClose { get; set; }

        [JsonPropertyName("volume")]
        public double Volume { get; set; }

        [JsonPropertyName("unadjustedVolume")]
        public double UnadjustedVolume { get; set; }

        [JsonPropertyName("change")]
        public decimal Change { get; set; }

        [JsonPropertyName("changePercent")]
        public decimal ChangePercent { get; set; }

        [JsonPropertyName("vwap")]
        public decimal VWAP { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("changeOvertime")]
        public double ChangeOvertime { get; set; }
    }
}
