using FinancialModelingPrepApi.Model;
using FinancialModelingPrepApi.Model.CompanyValuation;
using System.Threading.Tasks;

namespace FinancialModelingPrepApi.Abstractions.CompanyValuation
{
    public interface ICompanyValuation
    {
        public Task<ApiResponse<CompanyProfileResponse>> GetCompanyProfileAsync(string symbol);
    }
}
