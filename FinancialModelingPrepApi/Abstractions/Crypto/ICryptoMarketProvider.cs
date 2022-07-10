using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Crypto;
using MatthiWare.FinancialModelingPrep.Model.StockMarket;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.StockMarket
{
    public interface ICryptoMarketProvider
    {
        public Task<ApiResponse<List<CryptoItem>>> GetAvilableCryptocurrencies();

        public Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalPrices(string symbol, HistoricalPricingPeriod period);

        public Task<ApiResponse<CryptoHistoricalPriceDailyItem>> GetDailyPrices(string symbol);
    }
}
