using FinancialModelingPrepApi.Abstractions;
using FinancialModelingPrepApi.Abstractions.CompanyValuation;
using FinancialModelingPrepApi.Core.Http;
using FinancialModelingPrepApi.Model;
using FinancialModelingPrepApi.Model.CompanyValuation;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        public Task<ApiResponse<List<CompanyProfileResponse>>> GetCompanyProfileAsync(string symbol)
        {
            const string url = "[version]/profile/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            return client.GetAsync<List<CompanyProfileResponse>>(url, pathParams, null);
        }
    }
}
