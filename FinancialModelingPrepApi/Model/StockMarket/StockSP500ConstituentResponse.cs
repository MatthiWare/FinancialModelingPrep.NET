using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Model.StockMarket
{
    public class IndexConstituentResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("sector")]
        public string Sector { get; set; }
        [JsonPropertyName("subSector")]
        public string Subsector { get; set; }
        [JsonPropertyName("headQuarter")]
        public string Headquarter { get; set; }
        [JsonPropertyName("dateFirstAdded")]
        public string DateFirstAdded { get; set; }
        [JsonPropertyName("cik")]
        public string Cik { get; set; }
        [JsonPropertyName("founded")]
        public string Founded { get; set; }
    }
}
