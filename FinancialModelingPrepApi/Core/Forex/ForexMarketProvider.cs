using MatthiWare.FinancialModelingPrep.Abstractions.Forex;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Forex;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.Forex
{
    public class ForexMarketProvider : IForexMarketProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public ForexMarketProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }


        public async Task<ApiResponse<List<ForexBookResponse>>> GetBookAsync(string symbol)
        {
            const string url = "[version]/fx/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            return await client.GetJsonAsync<List<ForexBookResponse>>(url, pathParams, null);
        }


        public async Task<ApiResponse<List<ForexQuoteResponse>>> GetQuoteAsync(string symbol)
        {
            const string url = "[version]/quote/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            return await client.GetJsonAsync<List<ForexQuoteResponse>>(url, pathParams, null);
        }

        public async Task<ApiResponse<List<ForexHistoricalQuoteResponse>>> GetHistoricalQuoteAsync(string symbol, HistoricalPricingPeriod period)
        {
            const string url = "[version]/historical-chart/[pricePeriod]/[symbol]";

            string pricePeriod = EnumMappings.HistoricalPrices[period];

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
                { "pricePeriod", pricePeriod }
            };

            return await client.GetJsonAsync<List<ForexHistoricalQuoteResponse>>(url, pathParams, null);
        }
    }
}
