using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Error
{
    public class ErrorResponse
    {
        [JsonPropertyName("Error Message")]
        public string ErrorMessage { get; set; }
    }
}
