using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Abstractions.MarketIndexes;

namespace MatthiWare.FinancialModelingPrep.Core
{
    /// <inheritdoc/>
    public class FinancialModelingPrepApiClient : IFinancialModelingPrepApiClient
    {
        /// <inheritdoc/>
        public ICompanyValuation CompanyValuation { get; private set; }

        /// <inheritdoc/>
        public IMarketIndexes MarketIndexes { get; private set; }

        /// <inheritdoc/>
        public IAdvancedData AdvancedData { get; private set; }

        public FinancialModelingPrepApiClient(ICompanyValuation companyValuation, IMarketIndexes marketIndexes, IAdvancedData advancedData)
        {
            CompanyValuation = companyValuation;
            MarketIndexes = marketIndexes;
            AdvancedData = advancedData;
        }
    }
}
