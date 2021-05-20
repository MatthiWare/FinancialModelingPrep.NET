using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Abstractions.MarketIndexes;

namespace MatthiWare.FinancialModelingPrep.Core
{
    public class FinancialModelingPrepApiClient : IFinancialModelingPrepApiClient
    {
        public ICompanyValuation CompanyValuation { get; private set; }

        public IMarketIndexes MarketIndexes { get; private set; }

        public IAdvancedData AdvancedData { get; private set; }

        public FinancialModelingPrepApiClient(ICompanyValuation companyValuation, IMarketIndexes marketIndexes, IAdvancedData advancedData)
        {
            CompanyValuation = companyValuation;
            MarketIndexes = marketIndexes;
            AdvancedData = advancedData;
        }
    }
}
