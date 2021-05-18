using MatthiWare.FinancialModelingPrepApi.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrepApi.Core.Http;
using MatthiWare.FinancialModelingPrepApi.Model;
using MatthiWare.FinancialModelingPrepApi.Model.CompanyValuation;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrepApi.Core.CompanyValuation
{
    public class CompanyValuation : ICompanyValuation
    {
        private readonly FinancialModelingPrepHttpClient client;

        public CompanyValuation(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public async Task<ApiResponse<CompanyProfileResponse>> GetCompanyProfileAsync(string symbol)
        {
            const string url = "[version]/profile/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetAsync<List<CompanyProfileResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<CompanyProfileResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<SymbolResponse>>> GetETFListAsync()
        {
            const string url = "[version]/etf/list";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetAsync<List<SymbolResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<SymbolResponse>>> GetSymbolsListAsync()
        {
            const string url = "[version]/stock/list";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetAsync<List<SymbolResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<SymbolResponse>>> GetTradableSymbolsListAsync()
        {
            const string url = "[version]/available-traded/list";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetAsync<List<SymbolResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<EnterpriseValueResponse>>> GetEnterpriseValueAsync(string symbol, Period period = Period.Quarter, int limit = 40)
        {
            const string url = "[version]/enterprise-values/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("limit", limit);

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetAsync<List<EnterpriseValueResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<BalanceSheetResponse>>> GetBalanceSheetStatementAsync(string symbol, Period period = Period.Quarter, int limit = 40)
        {
            const string url = "[version]/balance-sheet-statement/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("limit", limit);

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetAsync<List<BalanceSheetResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<CashFlowResponse>>> GetCashFlowStatementAsync(string symbol, Period period = Period.Quarter, int limit = 40)
        {
            const string url = "[version]/cash-flow-statement/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("limit", limit);

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetAsync<List<CashFlowResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync(string symbol, Period period = Period.Quarter, int limit = 40)
        {
            const string url = "[version]/income-statement/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("limit", limit);

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetAsync<List<IncomeStatementResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(string symbol, int limit = 50)
        {
            const string url = "[version]/stock_news";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("tickers", symbol);
            queryString.Add("limit", limit);

            return client.GetAsync<List<StockNewsResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<CompanyRatingResponse>> GetCompanyRatingAsync(string symbol)
        {
            const string url = "[version]/rating/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetAsync<List<CompanyRatingResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<CompanyRatingResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<CompanyRatingResponse>>> GetHistoricalCompanyRatingAsync(string symbol, int limit = 140)
        {
            const string url = "[version]/historical-rating/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("limit", limit);

            return client.GetAsync<List<CompanyRatingResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<DCFResponse>> GetDiscountedCashFlowAsync(string symbol)
        {
            const string url = "[version]/discounted-cash-flow/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetAsync<List<DCFResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<DCFResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<HistoricalDCFResponse>>> GetHistoricalDiscountedCashFlowAsync(string symbol, Period period = Period.Annual)
        {
            const string url = "[version]/historical-discounted-cash-flow-statement/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            if (period != Period.Annual)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetAsync<List<HistoricalDCFResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<HistoricalDailyDCFResponse>>> GetHistoricalDiscountedCashFlowDailyAsync(string symbol, int limit = 100)
        {
            const string url = "[version]/historical-discounted-cash-flow-statement/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("limit", limit);

            return client.GetAsync<List<HistoricalDailyDCFResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<KeyMetricsTTMResponse>> GetCompanyKeyMetricsTTMAsync(string symbol)
        {
            const string url = "[version]/key-metrics-ttm/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetAsync<List<KeyMetricsTTMResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<KeyMetricsTTMResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<KeyMetricsResponse>>> GetCompanyKeyMetricsAsync(string symbol, Period period = Period.Annual, int limit = 130)
        {
            const string url = "[version]/key-metrics/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("limit", limit);

            if (period != Period.Annual)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetAsync<List<KeyMetricsResponse>>(url, pathParams, queryString);
        }
    }
}
