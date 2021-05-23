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
        public ICompanyValuation CompanyValuation { get; }

        /// <inheritdoc/>
        public IMarketIndexes MarketIndexes { get; }

        /// <inheritdoc/>
        public IAdvancedData AdvancedData { get; }

        /// <inheritdoc/>
        public ICalendarsProvider Calendars { get; }

        public FinancialModelingPrepApiClient(ICompanyValuation companyValuation,
                                              IMarketIndexes marketIndexes,
                                              IAdvancedData advancedData,
                                              ICalendarsProvider calendars)
        {
            CompanyValuation = companyValuation;
            MarketIndexes = marketIndexes;
            AdvancedData = advancedData;
            Calendars = calendars;
        }
    }
}
