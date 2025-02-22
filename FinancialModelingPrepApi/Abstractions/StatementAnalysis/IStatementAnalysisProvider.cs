using System.Collections.Generic;
using System.Threading.Tasks;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.StatementAnalysis;

namespace MatthiWare.FinancialModelingPrep.Abstractions.StatementAnalysis;

public interface IStatementAnalysisProvider
{
    public Task<ApiResponse<List<FinancialGrowthResponse>>> GetFinancialGrowthAsync(string symbol,
        Period period = Period.Annual, int? limit = 30);
}