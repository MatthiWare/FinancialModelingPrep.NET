using MatthiWare.FinancialModelingPrep.Abstractions.StockMarket;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.StockMarket;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.StockMarket
{
    public sealed class StockMarketProvider : IStockMarketProvider
    {
        private const string ActivesEndpoint = "actives";
        private const string GainersEndpoint = "gainers";
        private const string LosersEndpoint = "losers";

        private readonly FinancialModelingPrepHttpClient client;

        public StockMarketProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetBiggestGainerStocksAsync()
            => GetStockMarketData(GainersEndpoint);

        public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetBiggestLoserStocksAsync()
            => GetStockMarketData(LosersEndpoint);

        public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetMostActiveStocksAsync()
            => GetStockMarketData(ActivesEndpoint);

        private Task<ApiResponse<List<StockMarketSymbolResponse>>> GetStockMarketData(string endpoint)
        {
            const string url = "[version]/[endpoint]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "endpoint", endpoint },
            };

            return client.GetJsonAsync<List<StockMarketSymbolResponse>>(url, pathParams, null);
        }
    }
}
