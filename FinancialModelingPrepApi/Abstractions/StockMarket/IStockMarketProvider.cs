using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.StockMarket;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.StockMarket
{
    public interface IStockMarketProvider
    {
        public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetMostActiveStocksAsync();
        public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetBiggestGainerStocksAsync();
        public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetBiggestLoserStocksAsync();
    }
}
