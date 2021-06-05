using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.StockTimeSeries;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.StockTimeSeries
{
    public interface IStockTimeSeriesProvider
    {
        /// <summary>
        /// Get Daily Historical Dividends
        /// </summary>
        /// <param name="symbol">Ticker symbol</param>
        /// <returns><see cref="HistoricalDividendsResponse"/></returns>
        Task<ApiResponse<HistoricalDividendsResponse>> GetHistoricalDividendsAsync(string symbol);

        /// <summary>
        /// Get Daily Historical Stock Splits
        /// </summary>
        /// <param name="symbol">Ticker symbol</param>
        /// <returns><see cref="HistoricalStockSplitResponse"/></returns>
        Task<ApiResponse<HistoricalStockSplitResponse>> GetHistoricalStockSplitsAsync(string symbol);
    }
}
