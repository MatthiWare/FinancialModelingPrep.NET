using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.InstitutionalFund
{
    public class Form13FResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("fillingDate")]
        public string FillingDate { get; set; }

        [JsonPropertyName("acceptedDate")]
        public string AcceptedDate { get; set; }

        [JsonPropertyName("cik")]
        public string Cik { get; set; }

        [JsonPropertyName("cusip")]
        public string Cusip { get; set; }

        [JsonPropertyName("tickercusip")]
        public string Tickercusip { get; set; }

        [JsonPropertyName("nameOfIssuer")]
        public string NameOfIssuer { get; set; }

        [JsonPropertyName("shares")]
        public int Shares { get; set; }

        [JsonPropertyName("titleOfClass")]
        public string TitleOfClass { get; set; }

        [JsonPropertyName("value")]
        public long Value { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
