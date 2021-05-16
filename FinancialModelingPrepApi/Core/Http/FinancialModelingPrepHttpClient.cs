using FinancialModelingPrepApi.Model;
using FinancialModelingPrepApi.Model.Error;
using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinancialModelingPrepApi.Core.Http
{
    public class FinancialModelingPrepHttpClient
    {
        private readonly HttpClient client;
        private readonly FinancialModelingPrepOptions options;
        private readonly JsonSerializerOptions jsonSerializerOptions;

        public FinancialModelingPrepHttpClient(HttpClient client, FinancialModelingPrepOptions options)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.options = options ?? throw new ArgumentNullException(nameof(options));
            this.jsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);

            if (string.IsNullOrWhiteSpace(this.options.ApiKey))
            {
                throw new ArgumentException("'ApiKey' can not be null or empty");
            }
        }

        public async Task<ApiResponse<T>> GetAsync<T>(string urlPattern, NameValueCollection pathParams, QueryStringBuilder queryString)
            where T : class
        {
            try
            {
                var response = await CallApiAsync(urlPattern, pathParams, queryString);

                if (response.HasError)
                {
                    ApiResponse.FromError<T>(response.Data);
                }

                if (response.Data.Contains("Error Message"))
                {
                    var errorData = JsonSerializer.Deserialize<ErrorResponse>(response.Data);

                    return ApiResponse.FromError<T>(errorData.ErrorMessage);
                }

                var data = JsonSerializer.Deserialize<T>(response.Data, jsonSerializerOptions);

                return ApiResponse.FromSucces(data);
            }
            catch (JsonException ex)
            {
                return ApiResponse.FromError<T>(ex.ToString());
            }
        }

        private async Task<ApiResponse<string>> CallApiAsync(string urlPattern, NameValueCollection pathParams, QueryStringBuilder queryString)
        {
            PreProcessUrl(ref urlPattern, ref pathParams, ref queryString);

            queryString.Add("apikey", options.ApiKey);

            var requestUrl = $"{urlPattern}{queryString}";

            using var response = await client.GetAsync(requestUrl);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return ApiResponse.FromError<string>($"{response.StatusCode} - {content}");
            }

            return ApiResponse.FromSucces(content);
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
