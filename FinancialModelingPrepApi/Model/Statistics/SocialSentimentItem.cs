using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.Statistics
{
    /*
     * "date" : "2022-06-30 23:00:00",
    "symbol" : "AAPL",
    "stocktwitsPosts" : 13,
    "twitterPosts" : 163,
    "stocktwitsComments" : 9,
    "twitterComments" : 7769,
    "stocktwitsLikes" : 16,
    "twitterLikes" : 40957,
    "stocktwitsImpressions" : 15141,
    "twitterImpressions" : 1576854,
    "stocktwitsSentiment" : 0.5411,
    "twitterSentiment" : 0.5888
     */
    public class SocialSentimentItem
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("stocktwitsPosts")]
        public int StockTwitsPosts { get; set; }

        [JsonPropertyName("stocktwitsComments")]
        public int StockTwitsComments { get; set; }

        [JsonPropertyName("stocktwitsLikes")]
        public int StockTwitsLikes { get; set; }

        [JsonPropertyName("stocktwitsImpressions")]
        public int StockTwitsImpressions { get; set; }

        [JsonPropertyName("stocktwitsSentiment")]
        public decimal StockTwitsSentiment { get; set; }

        [JsonPropertyName("twitterPosts")]
        public int TwitterPosts { get; set; }

        [JsonPropertyName("twitterComments")]
        public int TwitterComments { get; set; }

        [JsonPropertyName("twitterLikes")]
        public int TwitterLikes { get; set; }

        [JsonPropertyName("twitterImpressions")]
        public int TwitterImpressions { get; set; }

        [JsonPropertyName("twitterSentiment")]
        public decimal TwitterSentiment { get; set; }
    }
}
