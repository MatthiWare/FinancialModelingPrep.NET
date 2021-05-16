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
    }
}
