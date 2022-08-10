using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Forex;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Forex
{
    public interface IForexMarketProvider
    {
        Task<ApiResponse<List<ForexBookResponse>>> GetBookAsync(string symbol);

        Task<ApiResponse<List<ForexQuoteResponse>>> GetQuoteAsync(string symbol);

        Task<ApiResponse<List<ForexHistoricalQuoteResponse>>> GetHistoricalQuoteAsync(string symbol, HistoricalPricingPeriod period);
    }
}
