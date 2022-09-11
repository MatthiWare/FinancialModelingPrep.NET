using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Model.Crypto
{
    public class CryptoHistoricalPriceDailyItem
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("historical")]
        public List<CyptoHistoricalPriceDailyListing> Historical { get; set; }
    }
}
