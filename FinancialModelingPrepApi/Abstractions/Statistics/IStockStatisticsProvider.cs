using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Statistics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Statistics
{
    /// <summary>
    /// Stock related statistics
    /// </summary>
    public interface IStockStatisticsProvider
    {
        /// <summary>
        /// Get analyst estimates
        /// </summary>
        /// <param name="symbol">Stock symbol</param>
        /// <param name="period">Period (Annual or Quarterly)</param>
        /// <param name="limit">Limts the amount of results</param>
        /// <returns></returns>
        public Task<ApiResponse<List<AnalystEstimateItem>>> GetAnalystEstimatesAsync(string symbol, Period period = Period.Annual, int? limit = 30);

        // Social Sentiment
        public Task<ApiResponse<List<SocialSentimentItem>>> GetSocialSentimentAsync(string symbol, int page = 0);
    }
}
