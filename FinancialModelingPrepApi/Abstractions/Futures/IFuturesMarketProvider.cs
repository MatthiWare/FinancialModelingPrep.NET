using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Futures;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Futures
{
    public interface IFuturesMarketProvider
    {
        Task<ApiResponse<List<FuturesQuoteResponse>>> GetQuoteAsync(string symbol);

        Task<ApiResponse<List<FuturesHistoricalQuoteResponse>>> GetHistoricalQuoteAsync(string symbol, HistoricalPricingPeriod period);
    }
}
