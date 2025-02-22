﻿using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.StockTimeSeries;
using System.Collections.Generic;
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

        /// <summary>
        /// Get Daily Historical Prices
        /// </summary>
        /// <param name="symbol">Ticker symbol</param>
        /// <returns><see cref="HistoricalPriceResponse"/></returns>
        Task<ApiResponse<HistoricalPriceResponse>> GetHistoricalDailyPricesAsync(string symbol);

        /// <summary>
        /// Get Daily Historical Prices
        /// </summary>
        /// <param name="symbol">Ticker symbol</param>        
        /// <param name="from">From date (YYYY-MM-DD)</param>
        /// <param name="to">To date (YYYY-MM-DD)</param>
        /// <returns><see cref="HistoricalPriceResponse"/></returns>
        Task<ApiResponse<HistoricalPriceResponse>> GetHistoricalDailyPricesAsync(string symbol, string from, string to);

        /// <summary>
        /// Get Daily Historical Prices
        /// Should be used to display on a linechart
        /// </summary>
        /// <param name="symbol">Ticker symbol</param>
        /// <returns><see cref="HistoricalPriceForLineChartResponse"/></returns>
        Task<ApiResponse<HistoricalPriceForLineChartResponse>> GetHistoricalDailyPricesForLineChartAsync(string symbol);

        /// <summary>
        /// Get Daily Historical Prices
        /// Should be used to display on a linechart
        /// </summary>
        /// <param name="symbol">Ticker symbol</param>
        /// <param name="from">From date (YYYY-MM-DD)</param>
        /// <param name="to">To date (YYYY-MM-DD)</param>
        /// <returns><see cref="HistoricalPriceForLineChartResponse"/></returns>
        Task<ApiResponse<HistoricalPriceForLineChartResponse>> GetHistoricalDailyPricesForLineChartAsync(string symbol, string from, string to);

        /// <summary>
        /// Get Daily Historical Prices for charts with volume
        /// </summary>
        /// <param name="symbol">Ticker symbol</param>
        /// <param name="series">Time series</param>
        /// <param name="from">From date (YYYY-MM-DD)</param>
        /// <param name="to">To date (YYYY-MM-DD)</param>
        /// <param name="extended">Extended hours</param>
        /// <returns><see cref="HistoricalPriceForLineChartResponse"/></returns>
        Task<ApiResponse<List<HistoricalPriceForChartWithVolumeResponse>>> GetHistoricalPricesForChartWithVolume(string symbol, HistoricalChartSeries series, string from, string to, bool extended);
    }
}
