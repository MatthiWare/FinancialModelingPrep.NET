using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.AdvancedData
{
    public class CompanyPeersResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("peersList")]
        public List<string> PeersList { get; set; }
    }
}
