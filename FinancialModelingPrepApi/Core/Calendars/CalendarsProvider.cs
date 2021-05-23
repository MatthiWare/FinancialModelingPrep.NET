using MatthiWare.FinancialModelingPrep.Abstractions.Calendars;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Calendars;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.Calendars
{
    public class CalendarsProvider : ICalendarsProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public CalendarsProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<EarningsCalendarResponse>>> GetEarningsCalendarAsync(string from, string to)
        {
            if (string.IsNullOrEmpty(from))
            {
                throw new ArgumentException($"'{nameof(from)}' cannot be null or empty.", nameof(from));
            }

            if (string.IsNullOrEmpty(to))
            {
                throw new ArgumentException($"'{nameof(to)}' cannot be null or empty.", nameof(to));
            }

            return GetEarningsCalendarInternalAsync(from, to);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<EarningsCalendarResponse>>> GetEarningsCalendarAsync()
            => GetEarningsCalendarInternalAsync();

        private Task<ApiResponse<List<EarningsCalendarResponse>>> GetEarningsCalendarInternalAsync(string from = null, string to = null)
        {
            const string url = "[version]/earning_calendar";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            var queryString = new QueryStringBuilder();

            if (!string.IsNullOrEmpty(from) && !string.IsNullOrEmpty(to))
            {
                queryString.Add("from", from);
                queryString.Add("to", to);
            }

            return client.GetAsync<List<EarningsCalendarResponse>>(url, pathParams, queryString);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<EarningsCalendarResponse>>> GetHistoricalEarningsCalendarAsync(string symbol, int? limit = null)
        {
            const string url = "[version]/historical/earning_calendar/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetAsync<List<EarningsCalendarResponse>>(url, pathParams, queryString);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<IPOCalendarResponse>>> GetIPOCalendarAsync(string from, string to)
        {
            if (string.IsNullOrEmpty(from))
            {
                throw new ArgumentException($"'{nameof(from)}' cannot be null or empty.", nameof(from));
            }

            if (string.IsNullOrEmpty(to))
            {
                throw new ArgumentException($"'{nameof(to)}' cannot be null or empty.", nameof(to));
            }

            const string url = "[version]/ipo_calendar";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("from", from);
            queryString.Add("to", to);

            return client.GetAsync<List<IPOCalendarResponse>>(url, pathParams, queryString);
        }
    }
}
