using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Abstractions.Calendars;
using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Abstractions.Crypto;
using MatthiWare.FinancialModelingPrep.Abstractions.Economics;
using MatthiWare.FinancialModelingPrep.Abstractions.Fund;
using MatthiWare.FinancialModelingPrep.Abstractions.InstitutionalFund;
using MatthiWare.FinancialModelingPrep.Abstractions.MarketIndexes;
using MatthiWare.FinancialModelingPrep.Abstractions.StatementAnalysis;
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
        public IAdvancedDataProvider AdvancedData { get; }

        /// <summary>
        /// All Company Valuation Endpoints are grouped here
        /// </summary>
        public ICompanyValuationProvider CompanyValuation { get; }

        /// <summary>
        /// All Market Index Endpoints are grouped here
        /// </summary>
        public IMarketIndexesProvider MarketIndexes { get; }

        /// <summary>
        /// All Calendar related Endpoints are grouped here (Earnings, IPO, stock splits, Dividends, Economic)
        /// </summary>
        public ICalendarsProvider Calendars { get; }

        /// <summary>
        /// All Instituational Fund Endpoints are grouped here
        /// </summary>
        public IInstitutionalFundProvider InstitutionalFund { get; }

        /// <summary>
        /// All Stock Time Series Endpoints are grouped here
        /// </summary>
        public IStockTimeSeriesProvider StockTimeSeries { get; }

        /// <summary>
        /// All Stock Market Related Endpoints are grouped here (Most Active, Gainers, Losers)
        /// </summary>
        public IStockMarketProvider StockMarket { get; }

        /// <summary>
        /// Statistic Related Endpoint are grouped here (Estimates)
        /// </summary>
        public IStockStatisticsProvider StockStatistics { get; }

        /// <summary>
        /// Cryptomarket related enpoints
        /// </summary>
        public ICryptoMarketProvider Crypto { get; }

        /// <summary>
        /// ETF/Mutual Fund related enpoints
        /// </summary>
        public IFundProvider Fund { get; }


        /// <summary>
        /// Economics related endpoints
        /// - Market risk premium
        /// - Treasury rates
        /// - Economic indicators
        /// </summary>
        public IEconomicsProvider Economics { get; }
        
        /// <summary>
        /// Statement Analysis related endpoints
        /// - Financial Growth
        /// </summary>
        public IStatementAnalysisProvider StatementAnalysis { get; }
    }
}
