using MatthiWare.FinancialModelingPrep.Abstractions.InstitutionalFund;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.InstitutionalFund;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
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

        public Task<ApiResponse<List<CikListResponse>>> Get13FListAsync()
        {
            const string url = "[version]/cik_list";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetJsonAsync<List<CikListResponse>>(url, pathParams, null);
        }

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
    }
}
