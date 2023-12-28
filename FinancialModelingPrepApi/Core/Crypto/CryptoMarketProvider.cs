using MatthiWare.FinancialModelingPrep.Abstractions.Crypto;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Crypto;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.Crypto
{
    public sealed class CryptoMarketProvider : ICryptoMarketProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public CryptoMarketProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public Task<ApiResponse<List<CryptoItem>>> GetAvilableCryptocurrencies()
        {

            const string url = "[version]/symbol/available-cryptocurrencies";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetJsonAsync<List<CryptoItem>>(url, pathParams, null);
        }

        public Task<ApiResponse<CryptoHistoricalPriceDailyItem>> GetDailyPrices(string symbol)
        {
            const string url = "[version]/historical-price-full/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            return client.GetJsonAsync<CryptoHistoricalPriceDailyItem>(url, pathParams, null);
        }

        public Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalPrices(string symbol, HistoricalPricingPeriod period)
        {
            const string url = "[version]/historical-chart/[pricePeriod]/[symbol]";

            string pricePeriod = EnumMappings.HistoricalPrices[period];

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
                { "pricePeriod", pricePeriod }
            };

            var queryString = new QueryStringBuilder();

            return client.GetJsonAsync<List<CryptoHistoricalPricePeriodListing>>(url, pathParams, queryString);
        }
    }
}
