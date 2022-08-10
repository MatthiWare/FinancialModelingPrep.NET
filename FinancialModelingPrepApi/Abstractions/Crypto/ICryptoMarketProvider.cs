﻿using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Crypto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Crypto
{
    public interface ICryptoMarketProvider
    {
        Task<ApiResponse<List<CryptoItem>>> GetAvilableCryptocurrenciesAsync();

        Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalQuoteAsync(string symbol, HistoricalPricingPeriod period);

        Task<ApiResponse<CryptoHistoricalPriceDailyItem>> GetDailyPricesAsync(string symbol);

        Task<ApiResponse<List<CryptoQuoteResponse>>> GetQuoteAsync(string symbol);
    }
}
