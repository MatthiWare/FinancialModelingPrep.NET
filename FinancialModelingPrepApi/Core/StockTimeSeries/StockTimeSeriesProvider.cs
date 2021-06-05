using MatthiWare.FinancialModelingPrep.Abstractions.StockTimeSeries;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.StockTimeSeries;
using System;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.StockTimeSeries
{
    public class StockTimeSeriesProvider : IStockTimeSeriesProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public StockTimeSeriesProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalDividendsResponse>> GetHistoricalDividendsAsync(string symbol)
        {
            const string url = "[version]/historical-price-full/stock_dividend/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            return client.GetJsonAsync<HistoricalDividendsResponse>(url, pathParams, null);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalStockSplitResponse>> GetHistoricalStockSplitsAsync(string symbol)
        {
            const string url = "[version]/historical-price-full/stock_split/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            return client.GetJsonAsync<HistoricalStockSplitResponse>(url, pathParams, null);
        }
    }
}
