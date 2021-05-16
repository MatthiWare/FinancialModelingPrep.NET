using FinancialModelingPrepApi.Model;
using FinancialModelingPrepApi.Model.CompanyValuation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialModelingPrepApi.Abstractions.CompanyValuation
{
    public interface ICompanyValuation
    {
        public Task<ApiResponse<CompanyProfileResponse>> GetCompanyProfileAsync(string symbol);

        public Task<ApiResponse<List<SymbolResponse>>> GetSymbolsListAsync();
        public Task<ApiResponse<List<SymbolResponse>>> GetTradableSymbolsListAsync();
        public Task<ApiResponse<List<SymbolResponse>>> GetETFListAsync();

        public Task<ApiResponse<List<EnterpriseValueResponse>>> GetEnterpriseValueAsync(string symbol, Period period = Period.Quarter, int limit = 40);
        
        public Task<ApiResponse<List<BalanceSheetResponse>>> GetBalanceSheetStatementAsync(string symbol, Period period = Period.Quarter, int limit = 40);
        public Task<ApiResponse<List<CashFlowResponse>>> GetCashFlowStatementAsync(string symbol, Period period = Period.Quarter, int limit = 40);
        public Task<ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync(string symbol, Period period = Period.Quarter, int limit = 40);
    }
}
