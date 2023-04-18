using MatthiWare.FinancialModelingPrep.Abstractions.StockMarket;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.StockMarket;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
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

        public Task<ApiResponse<List<StockScreenerItem>>> StockScreener(int? marketCapMoreThan = null, int? marketCapLowerThan = null, decimal? priceMoreThan = null, decimal? priceLowerThan = null,
            decimal? betaMoreThan = null, decimal? betaLowerThan = null, int? volumeMoreThan = null, int? volumeLowerThan = null, bool? isEtf = null, bool? isActivelyTraded = null,
            Sector? sector = null, Industry? industry = null, Country? country = null, Exchange? exchange = null, int? limit = 30)
        {

            const string url = "[version]/stock-screener";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            var queryString = new QueryStringBuilder();

            if (marketCapMoreThan.HasValue)
            {
                queryString.Add("marketCapMoreThan", marketCapMoreThan.Value.ToString());
            }

            if (marketCapLowerThan.HasValue)
            {
                queryString.Add("marketCapLowerThan", marketCapLowerThan.Value.ToString());
            }

            if (priceMoreThan.HasValue)
            {
                queryString.Add("priceMoreThan", priceMoreThan.Value.ToString());
            }

            if (priceLowerThan.HasValue)
            {
                queryString.Add("priceLowerThan", priceLowerThan.Value.ToString());
            }

            if (betaMoreThan.HasValue)
            {
                queryString.Add("betaMoreThan", betaMoreThan.Value.ToString());
            }

            if (betaLowerThan.HasValue)
            {
                queryString.Add("betaLowerThan", betaLowerThan.Value.ToString());
            }

            if (volumeMoreThan.HasValue)
            {
                queryString.Add("volumeMoreThan", volumeMoreThan.Value.ToString());
            }

            if (isEtf.HasValue)
            {
                queryString.Add("isEtf", isEtf.Value.ToString());
            }

            if (sector.HasValue)
            {
                queryString.Add("sector", EnumMappings.Sectors[sector.Value]);
            }

            if (industry.HasValue)
            {
                queryString.Add("industry", EnumMappings.Industries[industry.Value]);
            }

            if (country.HasValue)
            {
                queryString.Add("country", country.Value.ToString());
            }

            if (exchange.HasValue)
            {
                queryString.Add("exchange", exchange.Value.ToString().ToLower());
            }
                
            queryString.Add("limit", limit.Value.ToString());
            

            return client.GetJsonAsync<List<StockScreenerItem>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<IndexConstituentResponse>>> GetSP500Constituents()
        {
            const string url = "[version]/sp500_constituent";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetJsonAsync<List<IndexConstituentResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<IndexConstituentResponse>>> GetNasdaqConstituents()
        {
            const string url = "[version]/nasdaq_constituent";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetJsonAsync<List<IndexConstituentResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<StockDividendResponse>> GetStockHistoricalDividends(string symbol)
        {
            const string url = "[version]/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
            };

            return client.GetJsonAsync<StockDividendResponse>(url, pathParams, null);
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
