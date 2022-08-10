using MatthiWare.FinancialModelingPrep.Abstractions.StockTimeSeries;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.StockMarket;
using MatthiWare.FinancialModelingPrep.Model.StockTimeSeries;
using System;
using System.Collections.Generic;
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

        public async Task<ApiResponse<List<StockQuoteResponse>>> GetQuoteAsync(string symbol)
        {
            const string url = "[version]/quote/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            return await client.GetJsonAsync<List<StockQuoteResponse>>(url, pathParams, null);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalPriceResponse>> GetHistoricalDailyPricesAsync(string symbol)
        {
            const string url = "[version]/historical-price-full/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            return client.GetJsonAsync<HistoricalPriceResponse>(url, pathParams, null);
        }
        
        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalPriceResponse>> GetHistoricalDailyPricesAsync(string symbol, string from, string to)
        {
            const string url = "[version]/historical-price-full/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();
            queryString.Add("from", from);
            queryString.Add("to", to);

            return client.GetJsonAsync<HistoricalPriceResponse>(url, pathParams, queryString);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalPriceForLineChartResponse>> GetHistoricalDailyPricesForLineChartAsync(string symbol)
        {
            const string url = "[version]/historical-price-full/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("serietype", "line");

            return client.GetJsonAsync<HistoricalPriceForLineChartResponse>(url, pathParams, queryString);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalPriceForLineChartResponse>> GetHistoricalDailyPricesForLineChartAsync(string symbol, string from, string to)
        {
            const string url = "[version]/historical-price-full/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("serietype", "line");
            queryString.Add("from", from);
            queryString.Add("to", to);

            return client.GetJsonAsync<HistoricalPriceForLineChartResponse>(url, pathParams, queryString);
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
        public Task<ApiResponse<List<HistoricalPriceForChartWithVolumeResponse>>> GetHistoricalPricesForChartWithVolume(string symbol, HistoricalChartSeries series)
        {
            const string url = "[version]/historical-chart/[series]/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "series", HistoricalChartSeriesToString(series) },
                { "symbol", symbol }
            };

            return client.GetJsonAsync<List<HistoricalPriceForChartWithVolumeResponse>>(url, pathParams, null);
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

        private static string HistoricalChartSeriesToString(HistoricalChartSeries series)
        {
            return series switch
            {
                HistoricalChartSeries.OneMinute => "1min",
                HistoricalChartSeries.FiveMinutes => "5min",
                HistoricalChartSeries.FifteenMinutes => "15min",
                HistoricalChartSeries.ThirtyMinutes => "30min",
                HistoricalChartSeries.Hourly => "1hour",
                HistoricalChartSeries.FourHours => "4hour",
                _ => throw new NotImplementedException(),
            };
        }
    }
}
