using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.CompanyValuation;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.CompanyValuation
{
    public class CompanyValuationProvider : ICompanyValuationProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public CompanyValuationProvider(FinancialModelingPrepHttpClient client)
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

            var result = await client.GetJsonAsync<List<CompanyProfileResponse>>(url, pathParams, null);

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

            return client.GetJsonAsync<List<SymbolResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<SymbolResponse>>> GetSymbolsListAsync()
        {
            const string url = "[version]/stock/list";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetJsonAsync<List<SymbolResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<SymbolResponse>>> GetTradableSymbolsListAsync()
        {
            const string url = "[version]/available-traded/list";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetJsonAsync<List<SymbolResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<string>>> GetSymbolsWithFinancialStatementsAsync()
        {
            const string url = "[version]/financial-statement-symbol-lists";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetJsonAsync<List<string>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<EnterpriseValueResponse>>> GetEnterpriseValueAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
        {
            const string url = "[version]/enterprise-values/[symbol]";

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

            // mandatory
            queryString.Add("period", period.ToString().ToLower());
            

            return client.GetJsonAsync<List<EnterpriseValueResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<BalanceSheetResponse>>> GetBalanceSheetStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
        {
            const string url = "[version]/balance-sheet-statement/[symbol]";

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

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetJsonAsync<List<BalanceSheetResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<CashFlowResponse>>> GetCashFlowStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
        {
            const string url = "[version]/cash-flow-statement/[symbol]";

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

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetJsonAsync<List<CashFlowResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
        {
            const string url = "[version]/income-statement/[symbol]";

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

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetJsonAsync<List<IncomeStatementResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(string symbol, int? limit = 50)
        {
            const string url = "[version]/stock_news";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("tickers", symbol);
            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<StockNewsResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<StockNewsResponse>>> GetLatestStockNewsAsync(int? limit = 50)
        {
            const string url = "[version]/stock_news";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
            };

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<StockNewsResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(IEnumerable<string> symbols, int? limit = 50)
        {
            const string url = "[version]/stock_news";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("tickers", string.Join(',', symbols));

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<StockNewsResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<CompanyRatingResponse>> GetCompanyRatingAsync(string symbol)
        {
            const string url = "[version]/rating/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<CompanyRatingResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<CompanyRatingResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<CompanyRatingResponse>>> GetHistoricalCompanyRatingAsync(string symbol, int? limit = 140)
        {
            const string url = "[version]/historical-rating/[symbol]";

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

            return client.GetJsonAsync<List<CompanyRatingResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<DCFResponse>> GetDiscountedCashFlowAsync(string symbol)
        {
            const string url = "[version]/discounted-cash-flow/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<DCFResponse>>(url, pathParams, null);

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

            return client.GetJsonAsync<List<HistoricalDCFResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<HistoricalDailyDCFResponse>>> GetHistoricalDiscountedCashFlowDailyAsync(string symbol, int? limit = 100)
        {
            const string url = "[version]/historical-discounted-cash-flow-statement/[symbol]";

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

            return client.GetJsonAsync<List<HistoricalDailyDCFResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<RatiosTTMResponse>> GetRatiosTTMAsync(string symbol)
        {
            const string url = "[version]/ratios-ttm/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<RatiosTTMResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<RatiosTTMResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public async Task<ApiResponse<KeyMetricsTTMResponse>> GetCompanyKeyMetricsTTMAsync(string symbol)
        {
            const string url = "[version]/key-metrics-ttm/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<KeyMetricsTTMResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<KeyMetricsTTMResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<KeyMetricsResponse>>> GetCompanyKeyMetricsAsync(string symbol, Period period = Period.Annual, int? limit = 130)
        {
            const string url = "[version]/key-metrics/[symbol]";

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

            if (period != Period.Annual)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetJsonAsync<List<KeyMetricsResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<QuoteResponse>> GetQuoteAsync(string symbol)
        {
            const string url = "[version]/quote/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<QuoteResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<QuoteResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<QuoteResponse>>> GetQuotesAsync(IEnumerable<string> symbols)
        {
            const string url = "[version]/quote/[symbols]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbols", string.Join(',', symbols) }
            };

            if (string.IsNullOrEmpty(pathParams["symbols"]))
            {
                throw new ArgumentException(
                    "List of symbols cannot result in an empty string. At least one ticker symbol needs to be added.",
                    nameof(symbols));
            }

            return client.GetJsonAsync<List<QuoteResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<QuoteResponse>>> GetQuotesAsync(Exchange exchange)
        {
            const string url = "[version]/quotes/[exchange]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "exchange", exchange.ToString() }
            };

            return client.GetJsonAsync<List<QuoteResponse>>(url, pathParams, null);
        }

        public async Task<ApiResponse<MarketCapResponse>> GetMarketCapitalizationAsync(string symbol)
        {
            const string url = "[version]/historical-market-capitalization/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<MarketCapResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<MarketCapResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<MarketCapResponse>>> GetHistoricalMarketCapitalizationAsync(string symbol, int? limit = 100)
        {
            const string url = "[version]/historical-market-capitalization/[symbol]";

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

            return client.GetJsonAsync<List<MarketCapResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<TickerSearchResponse>>> SearchAsync(string query, Exchange? exchange, int? limit = null)
            => SearchInternalAsync(query, exchange, false, limit);

        public Task<ApiResponse<List<TickerSearchResponse>>> SearchByTickerAsync(string query, Exchange? exchange, int? limit = null)
            => SearchInternalAsync(query, exchange, true, limit);

        private Task<ApiResponse<List<TickerSearchResponse>>> SearchInternalAsync(string query, Exchange? exchange, bool byTicker, int? limit)
        {
            const string url = "[version]/search";
            const string urlByTicker = "[version]/search-ticker";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("query", query);
            if (exchange.HasValue) queryString.Add("exchange", exchange.Value.ToString());

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<TickerSearchResponse>>(byTicker ? urlByTicker : url, pathParams, queryString);
        }

        public Task<ApiResponse<List<PressReleasesResponse>>> GetPressReleasesAsync(string symbol, int? limit = null)
        {
            const string url = "[version]/press-releases/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol},
            };

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<PressReleasesResponse>>(url, pathParams, queryString);
        }

        /// <inheritdoc />
        public Task<ApiResponse<List<SymbolChangeResponse>>> GetSymbolChangesAsync()
        {
            const string url = "[version]/symbol_change";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v4.ToString() }
            };

            return client.GetJsonAsync<List<SymbolChangeResponse>>(url, pathParams, null);

        }
    }
}
