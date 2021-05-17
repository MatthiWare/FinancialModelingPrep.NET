using MatthiWare.FinancialModelingPrepApi.Model;
using MatthiWare.FinancialModelingPrepApi.Model.MarketIndexes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrepApi.Abstractions.MarketIndexes
{
    public interface IMarketIndexes
    {
        Task<ApiResponse<List<IndexConstituentResponse>>> GetSP500CompaniesAsync();
        Task<ApiResponse<List<IndexConstituentResponse>>> GetNasdaqCompaniesAsync();
        Task<ApiResponse<List<IndexConstituentResponse>>> GetDowJonesCompaniesAsync();
    }
}
