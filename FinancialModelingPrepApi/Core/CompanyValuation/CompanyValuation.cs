using FinancialModelingPrepApi.Abstractions;
using FinancialModelingPrepApi.Abstractions.CompanyValuation;
using FinancialModelingPrepApi.Core.Http;
using FinancialModelingPrepApi.Model;
using FinancialModelingPrepApi.Model.CompanyValuation;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialModelingPrepApi.Core.CompanyValuation
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
    }
}
