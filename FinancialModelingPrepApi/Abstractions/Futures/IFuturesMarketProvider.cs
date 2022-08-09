using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Futures;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Futures
{
    public interface IFuturesMarketProvider
    {
        Task<ApiResponse<List<FuturesQuoteResponse>>> GetQuote(string symbol);
    }
}
