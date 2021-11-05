using MatthiWare.FinancialModelingPrep.Abstractions.Statistics;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Statistics;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.Statistics
{
    /// <inheritdoc/>
    public class StockStatisticsProvider : IStockStatisticsProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public StockStatisticsProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<AnalystEstimateItem>>> GetAnalystEstimatesAsync(string symbol, Period period = Period.Annual, int? limit = 30)
        {
            const string url = "[version]/analyst-estimates/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("period", period);

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<AnalystEstimateItem>>(url, pathParams, queryString);
        }

    }
}
