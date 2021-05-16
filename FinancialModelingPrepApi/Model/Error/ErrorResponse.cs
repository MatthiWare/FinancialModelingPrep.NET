using System.Text.Json.Serialization;

namespace FinancialModelingPrepApi.Model.Error
{
    public class ErrorResponse
    {
        [JsonPropertyName("Error Message")]
        public string ErrorMessage { get; set; }
    }
}
