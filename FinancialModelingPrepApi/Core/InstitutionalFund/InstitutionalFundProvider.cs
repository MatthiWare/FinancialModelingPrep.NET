using MatthiWare.FinancialModelingPrep.Abstractions.InstitutionalFund;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.InstitutionalFund;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.InstitutionalFund
{
    public class InstitutionalFundProvider : IInstitutionalFundProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public InstitutionalFundProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<CikListResponse>>> Get13FListAsync()
        {
            const string url = "[version]/cik_list";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetJsonAsync<List<CikListResponse>>(url, pathParams, null);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<CikListResponse>>> GetCompanyNameByCik(string cik)
        {
            const string url = "[version]/cik/[cik]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "cik", cik }
            };

            return client.GetJsonAsync<List<CikListResponse>>(url, pathParams, null);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<Form13FResponse>>> GetForm13FAsync(string cik, string date)
        {
            const string url = "[version]/form-thirteen/[cik]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "cik", cik }
            };

            var queryString = new QueryStringBuilder();
            queryString.Add("date", date);

            return client.GetJsonAsync<List<Form13FResponse>>(url, pathParams, queryString);
        }

        /// <inheritdoc/>
        public async Task<ApiResponse<CusipMapperResponse>> MapCusipAsync(string cusip)
        {
            const string url = "[version]/cusip/[cusip]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "cusip", cusip }
            };

            var result = await client.GetJsonAsync<List<CusipMapperResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<CusipMapperResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<CikListResponse>>> SearchCikByName(string name)
        {
            const string url = "[version]/cik-search/[name]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "name", name }
            };

            return client.GetJsonAsync<List<CikListResponse>>(url, pathParams, null);
        }
    }
}
