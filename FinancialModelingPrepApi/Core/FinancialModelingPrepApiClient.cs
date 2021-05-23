using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Abstractions.Calendars;
using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Abstractions.MarketIndexes;

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

        public FinancialModelingPrepApiClient(ICompanyValuationProvider companyValuation,
                                              IMarketIndexesProvider marketIndexes,
                                              IAdvancedDataProvider advancedData,
                                              ICalendarsProvider calendars)
        {
            CompanyValuation = companyValuation;
            MarketIndexes = marketIndexes;
            AdvancedData = advancedData;
            Calendars = calendars;
        }
    }
}
