using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Abstractions.Calendars;
using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Abstractions.InstitutionalFund;
using MatthiWare.FinancialModelingPrep.Abstractions.MarketIndexes;
using MatthiWare.FinancialModelingPrep.Abstractions.Statistics;
using MatthiWare.FinancialModelingPrep.Abstractions.StockMarket;
using MatthiWare.FinancialModelingPrep.Abstractions.StockTimeSeries;

namespace MatthiWare.FinancialModelingPrep
{
    /// <summary>
    /// FMP Client that exposes different sections of Endpoints
    /// </summary>
    public interface IFinancialModelingPrepApiClient
    {
        /// <summary>
        /// Advanced Data Endpoints are grouped here
        /// Note: most of these endpoints require a premium API Key
        /// </summary>
        IAdvancedDataProvider AdvancedData { get; }

        /// <summary>
        /// All Company Valuation Endpoints are grouped here
        /// </summary>
        ICompanyValuationProvider CompanyValuation { get; }

        /// <summary>
        /// All Market Index Endpoints are grouped here
        /// </summary>
        IMarketIndexesProvider MarketIndexes { get; }

        /// <summary>
        /// All Calendar related Endpoints are grouped here (Earnings, IPO, stock splits, Dividends, Economic)
        /// </summary>
        ICalendarsProvider Calendars { get; }

        /// <summary>
        /// All Instituational Fund Endpoints are grouped here
        /// </summary>
        IInstitutionalFundProvider InstitutionalFund { get; }

        /// <summary>
        /// All Stock Time Series Endpoints are grouped here
        /// </summary>
        IStockTimeSeriesProvider StockTimeSeries { get; }

        /// <summary>
        /// All Stock Market Related Endpoints are grouped here (Most Active, Gainers, Losers)
        /// </summary>
        IStockMarketProvider StockMarket { get; }

        /// <summary>
        /// Statistic Related Endpoint are grouped here (Estimates)
        /// </summary>
        IStockStatisticsProvider StockStatistics { get; }
    }
}
