using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;

namespace FinancialModelingPrepApi.Core.Http
{
    public class FinancialModelingPrepHttpClient
    {
        private readonly HttpClient client;
        private readonly FinancialModelingPrepOptions options;

        public FinancialModelingPrepHttpClient(HttpClient client, FinancialModelingPrepOptions options)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.options = options ?? throw new ArgumentNullException(nameof(options));

            if (string.IsNullOrWhiteSpace(this.options.ApiKey))
            {
                throw new ArgumentException("'ApiKey' can not be null or empty");
            }
        }

        public async Task<string> CallApiAsync(string urlPattern, NameValueCollection pathParams, QueryStringBuilder queryString)
        {
            PreProcessUrl(ref urlPattern, ref pathParams, ref queryString);

            queryString.Add("apikey", options.ApiKey);

            var requestUrl = $"{urlPattern}{queryString}";

            using var response = await client.GetAsync(requestUrl);
            return await response.EnsureSuccessStatusCode().Content.ReadAsStringAsync();
        }

        private static void PreProcessUrl(ref string url, ref NameValueCollection pathParams, ref QueryStringBuilder qsb)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException(nameof(url));
            }

            if (pathParams == null)
            {
                throw new ArgumentNullException(nameof(pathParams));
            }

            qsb ??= new QueryStringBuilder();

            if (pathParams.Count == 0)
            {
                return;
            }

            foreach (string key in pathParams.Keys)
            {
                if (string.IsNullOrWhiteSpace(key))
                {
                    throw new ArgumentException("Provided path parameter was null or empty");
                }
                else if (string.IsNullOrWhiteSpace(pathParams[key]))
                {
                    throw new ArgumentException($"Provided path parameter value for {key} was null or empty");
                }
                else if (url.IndexOf($"[{key}]") < 0)
                {
                    throw new ArgumentException($"Url pattern doesn't contain [{key}]");
                }

                url = url.Replace($"[{key}]", pathParams[key]);
            }
        }
    }
}
