using MatthiWare.FinancialModelingPrepApi.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrepApi.Abstractions.MarketIndexes;

namespace MatthiWare.FinancialModelingPrepApi.Core
{
    public class FinancialModelingPrepApiClient : IFinancialModelingPrepApiClient
    {
        public ICompanyValuation CompanyValuation { get; private set; }

        public IMarketIndexes MarketIndexes { get; private set; }

        public FinancialModelingPrepApiClient(ICompanyValuation companyValuation, IMarketIndexes marketIndexes)
        {
            CompanyValuation = companyValuation;
            MarketIndexes = marketIndexes;
        }
    }
}
