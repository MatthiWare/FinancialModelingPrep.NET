using FinancialModelingPrepApi.Model;
using FinancialModelingPrepApi.Model.CompanyValuation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialModelingPrepApi.Abstractions.CompanyValuation
{
    public interface ICompanyValuation
    {
        public Task<ApiResponse<List<CompanyProfileResponse>>> GetCompanyProfileAsync(string symbol);
    }
}
