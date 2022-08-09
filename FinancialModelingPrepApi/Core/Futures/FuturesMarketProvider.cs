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

        public Task<ApiResponse<List<FuturesQuoteResponse>>> GetQuote(string symbol)
        {
            const string url = "[version]/quote/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            return client.GetJsonAsync<List<FuturesQuoteResponse>>(url, pathParams, null);
        }
    }
}
