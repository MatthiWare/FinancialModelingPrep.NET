using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Forex;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Forex
{
    public interface IForexMarketProvider
    {
        Task<ApiResponse<List<ForexPairResponse>>> GetPair(string symbol);

        Task<ApiResponse<List<ForexPairQuoteResponse>>> GetQuote(string symbol);
    }
}
