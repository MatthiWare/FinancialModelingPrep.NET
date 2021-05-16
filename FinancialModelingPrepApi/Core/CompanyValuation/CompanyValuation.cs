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
    }
}
