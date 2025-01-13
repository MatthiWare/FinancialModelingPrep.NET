using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using MatthiWare.FinancialModelingPrep.Abstractions.StatementAnalysis;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.StatementAnalysis;

namespace MatthiWare.FinancialModelingPrep.Core.StatementAnalysis;

public class StatementAnalysisProvider : IStatementAnalysisProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public StatementAnalysisProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<FinancialGrowthResponse>>> GetFinancialGrowthAsync(string symbol, Period period = Period.Annual, int? limit = 30)
    {
        const string url = "[version]/financial-growth/[symbol]";

        var pathParams = new NameValueCollection()
        {
            { "version", ApiVersion.v3.ToString() },
            { "symbol", symbol },
        };

        var queryString = new QueryStringBuilder();

        queryString.Add("period", period.ToString().ToLower());

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        return client.GetJsonAsync<List<FinancialGrowthResponse>>(url, pathParams, queryString);
    }
}