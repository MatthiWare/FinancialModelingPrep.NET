using MatthiWare.FinancialModelingPrep.Abstractions.Crypto;
using MatthiWare.FinancialModelingPrep.Abstractions.StockMarket;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Crypto;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.StockMarket
{
    public sealed class CryptoMarketProvider : ICryptoMarketProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public CryptoMarketProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public async Task<ApiResponse<List<CryptoItem>>> GetAvilableCryptocurrenciesAsync()
        {
            const string url = "[version]/symbol/available-cryptocurrencies";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return await client.GetJsonAsync<List<CryptoItem>>(url, pathParams, null);
        }

        public async Task<ApiResponse<List<CryptoQuoteResponse>>> GetDailyQuotes()
        {
            const string url = "[version]/quotes/crypto";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return await client.GetJsonAsync<List<CryptoQuoteResponse>>(url, pathParams, null);
        }

        public async Task<ApiResponse<List<CryptoQuoteResponse>>> GetQuoteAsync(string symbol)
        {
            const string url = "[version]/quote/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            return await client.GetJsonAsync<List<CryptoQuoteResponse>>(url, pathParams, null);
        }

        public async Task<ApiResponse<CryptoHistoricalPriceDailyItem>> GetHistoricalQuoteAsync(string symbol)
        {
            const string url = "[version]/historical-price-full/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            return await client.GetJsonAsync<CryptoHistoricalPriceDailyItem>(url, pathParams, null);
        }


        public async Task<ApiResponse<CryptoHistoricalPriceDailyItem>> GetHistoricalQuoteAsync(string symbol, string from, string to)
        {
            const string url = "[version]/historical-price-full/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            QueryStringBuilder queryString = new QueryStringBuilder();

            queryString.Add("from", from);
            queryString.Add("to", to);

            return await client.GetJsonAsync<CryptoHistoricalPriceDailyItem>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalQuoteAsync(string symbol, HistoricalPricingPeriod period)
        {
            const string url = "[version]/historical-chart/[pricePeriod]/[symbol]";

            string pricePeriod = EnumMappings.HistoricalPrices[period];

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
                { "pricePeriod", pricePeriod }
            };

            return await client.GetJsonAsync<List<CryptoHistoricalPricePeriodListing>>(url, pathParams, null);
        }
    }
}
