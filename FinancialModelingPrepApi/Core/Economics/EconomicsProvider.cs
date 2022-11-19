using MatthiWare.FinancialModelingPrep.Abstractions.Economics;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Economics;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.Economics
{
    public class EconomicsProvider : IEconomicsProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public EconomicsProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<EconomicIndicatorResponse>>> GetEconomicIndicatorAsync(EconomicIndicator indicator, string from, string to)
        {
            const string url = "[version]/economic";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v4.ToString() },
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("name", indicator.ToFMP());
            queryString.Add("from", from);
            queryString.Add("to", to);

            return client.GetJsonAsync<List<EconomicIndicatorResponse>>(url, pathParams, queryString);
        }
    }
}
