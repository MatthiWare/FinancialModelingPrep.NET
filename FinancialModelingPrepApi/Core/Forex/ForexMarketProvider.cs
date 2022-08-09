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


        public Task<ApiResponse<List<ForexPairResponse>>> GetPair(string symbol)
        {
            const string url = "[version]/fx/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            return client.GetJsonAsync<List<ForexPairResponse>>(url, pathParams, null);
        }


        public Task<ApiResponse<List<ForexPairQuoteResponse>>> GetQuote(string symbol)
        {
            const string url = "[version]/quote/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            return client.GetJsonAsync<List<ForexPairQuoteResponse>>(url, pathParams, null);
        }
    }
}
