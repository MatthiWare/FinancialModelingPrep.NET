using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class CompanyProfileResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("beta")]
        public double Beta { get; set; }

        [JsonPropertyName("volAvg")]
        public int VolAvg { get; set; }

        [JsonPropertyName("mktCap")]
        public long MktCap { get; set; }

        [JsonPropertyName("lastDiv")]
        public double LastDiv { get; set; }

        [JsonPropertyName("range")]
        public string Range { get; set; }

        [JsonPropertyName("changes")]
        public double Changes { get; set; }

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("cik")]
        public string Cik { get; set; }

        [JsonPropertyName("isin")]
        public string Isin { get; set; }

        [JsonPropertyName("cusip")]
        public string Cusip { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("exchangeShortName")]
        public string ExchangeShortName { get; set; }

        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("ceo")]
        public string Ceo { get; set; }

        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("fullTimeEmployees")]
        public string FullTimeEmployees { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        [JsonPropertyName("dcfDiff")]
        public double? DcfDiff { get; set; }

        [JsonPropertyName("dcf")]
        public double? Dcf { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("ipoDate")]
        public string IpoDate { get; set; }

        [JsonPropertyName("defaultImage")]
        public bool DefaultImage { get; set; }

        [JsonPropertyName("isEtf")]
        public bool IsEtf { get; set; }

        [JsonPropertyName("isActivelyTrading")]
        public bool IsActivelyTrading { get; set; }

        [JsonPropertyName("isAdr")]
        public bool IsAdr { get; set; }

        [JsonPropertyName("isFund")]
        public bool IsFund { get; set; }
    }
}
