using MatthiWare.FinancialModelingPrep.Abstractions.Futures;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Futures;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.Futures
{
    public class FuturesMarketProvider : IFuturesMarketProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public FuturesMarketProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public async Task<ApiResponse<List<FuturesQuoteResponse>>> GetQuoteAsync(string symbol)
        {
            const string url = "[version]/quote/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            return await client.GetJsonAsync<List<FuturesQuoteResponse>>(url, pathParams, null);
        }

        public async Task<ApiResponse<List<FuturesHistoricalQuoteResponse>>> GetHistoricalQuoteAsync(string symbol, HistoricalPricingPeriod period)
        {
            const string url = "[version]/historical-chart/[pricePeriod]/[symbol]";

            string pricePeriod = EnumMappings.HistoricalPrices[period];

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
                { "pricePeriod", pricePeriod }
            };

            return await client.GetJsonAsync<List<FuturesHistoricalQuoteResponse>>(url, pathParams, null);
        }
    }
}
