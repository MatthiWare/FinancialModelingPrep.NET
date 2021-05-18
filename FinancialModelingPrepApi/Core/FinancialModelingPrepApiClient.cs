using MatthiWare.FinancialModelingPrepApi.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrepApi.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrepApi.Abstractions.MarketIndexes;

namespace MatthiWare.FinancialModelingPrepApi.Core
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
