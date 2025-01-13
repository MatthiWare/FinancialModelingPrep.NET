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

namespace MatthiWare.FinancialModelingPrep.Core
{
    /// <inheritdoc/>
    public class FinancialModelingPrepApiClient : IFinancialModelingPrepApiClient
    {
        /// <inheritdoc/>
        public ICompanyValuationProvider CompanyValuation { get; }

        /// <inheritdoc/>
        public IMarketIndexesProvider MarketIndexes { get; }

        /// <inheritdoc/>
        public IAdvancedDataProvider AdvancedData { get; }

        /// <inheritdoc/>
        public ICalendarsProvider Calendars { get; }

        /// <inheritdoc/>
        public IInstitutionalFundProvider InstitutionalFund { get; }

        /// <inheritdoc/>
        public IStockTimeSeriesProvider StockTimeSeries { get; }

        /// <inheritdoc/>
        public IStockMarketProvider StockMarket { get; }

        /// <inheritdoc/>
        public IStockStatisticsProvider StockStatistics { get; }

        /// <inheritdoc/>
        public ICryptoMarketProvider Crypto { get; }

        /// <inheritdoc/>
        public IFundProvider Fund { get; }

        /// <inheritdoc/>
        public IEconomicsProvider Economics { get; }

        public IStatementAnalysisProvider StatementAnalysis { get; }

        /// <inheritdoc/>
        public FinancialModelingPrepApiClient(ICompanyValuationProvider companyValuation,
                                              IMarketIndexesProvider marketIndexes,
                                              IAdvancedDataProvider advancedData,
                                              ICalendarsProvider calendars,
                                              IInstitutionalFundProvider institutionalFund,
                                              IStockTimeSeriesProvider stockTimeSeries,
                                              IStockMarketProvider stockMarket,
                                              IStockStatisticsProvider stockStatistics,
                                              ICryptoMarketProvider cryptoMarket,
                                              IFundProvider fund,
                                              IEconomicsProvider economics,
                                              IStatementAnalysisProvider statementAnalysis)
        {
            CompanyValuation = companyValuation;
            MarketIndexes = marketIndexes;
            AdvancedData = advancedData;
            Calendars = calendars;
            InstitutionalFund = institutionalFund;
            StockTimeSeries = stockTimeSeries;
            StockMarket = stockMarket;
            StockStatistics = stockStatistics;
            Crypto = cryptoMarket;
            Fund = fund;
            Economics = economics;
            StatementAnalysis = statementAnalysis;
        }
    }
}
