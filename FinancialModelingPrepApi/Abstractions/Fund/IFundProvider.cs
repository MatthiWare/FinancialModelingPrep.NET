using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Fund;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Fund
{
    public interface IFundProvider
    {
        public Task<ApiResponse<List<ETFStockExposureResponse>>> GetETFStockExposureAsync(string symbol);

    }
}
