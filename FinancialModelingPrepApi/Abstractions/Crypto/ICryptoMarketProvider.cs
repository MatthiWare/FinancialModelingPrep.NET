using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Crypto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Crypto
{
    public interface ICryptoMarketProvider
    {
        Task<ApiResponse<List<CryptoItem>>> GetAvilableCryptocurrencies();

        Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalPrices(string symbol, HistoricalPricingPeriod period);

        Task<ApiResponse<CryptoHistoricalPriceDailyItem>> GetDailyPrices(string symbol);

        Task<ApiResponse<List<CryptoQuoteResponse>>> GetQuote(string symbol);
    }
}
