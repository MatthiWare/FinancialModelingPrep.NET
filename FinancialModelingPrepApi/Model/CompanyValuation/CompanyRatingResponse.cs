using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class CompanyRatingResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("ratingScore")]
        public int RatingScore { get; set; }

        [JsonPropertyName("ratingRecommendation")]
        public string RatingRecommendation { get; set; }

        [JsonPropertyName("ratingDetailsDCFScore")]
        public int RatingDetailsDCFScore { get; set; }

        [JsonPropertyName("ratingDetailsDCFRecommendation")]
        public string RatingDetailsDCFRecommendation { get; set; }

        [JsonPropertyName("ratingDetailsROEScore")]
        public int RatingDetailsROEScore { get; set; }

        [JsonPropertyName("ratingDetailsROERecommendation")]
        public string RatingDetailsROERecommendation { get; set; }

        [JsonPropertyName("ratingDetailsROAScore")]
        public int RatingDetailsROAScore { get; set; }

        [JsonPropertyName("ratingDetailsROARecommendation")]
        public string RatingDetailsROARecommendation { get; set; }

        [JsonPropertyName("ratingDetailsDEScore")]
        public int RatingDetailsDEScore { get; set; }

        [JsonPropertyName("ratingDetailsDERecommendation")]
        public string RatingDetailsDERecommendation { get; set; }

        [JsonPropertyName("ratingDetailsPEScore")]
        public int RatingDetailsPEScore { get; set; }

        [JsonPropertyName("ratingDetailsPERecommendation")]
        public string RatingDetailsPERecommendation { get; set; }

        [JsonPropertyName("ratingDetailsPBScore")]
        public int RatingDetailsPBScore { get; set; }

        [JsonPropertyName("ratingDetailsPBRecommendation")]
        public string RatingDetailsPBRecommendation { get; set; }
    }
}
