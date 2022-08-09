using MatthiWare.FinancialModelingPrep.Abstractions.Fund;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Fund;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.Fund
{
    public class FundProvider : IFundProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public FundProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public Task<ApiResponse<List<ETFStockExposureResponse>>> GetETFStockExposureAsync(string symbol)
        {
            const string url = "[version]/etf-stock-exposure/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            return client.GetJsonAsync<List<ETFStockExposureResponse>>(url, pathParams, null);
        }
    }
}
