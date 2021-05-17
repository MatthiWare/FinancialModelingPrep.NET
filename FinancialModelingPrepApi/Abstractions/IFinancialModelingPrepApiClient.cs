using MatthiWare.FinancialModelingPrepApi.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrepApi.Abstractions.MarketIndexes;

namespace MatthiWare.FinancialModelingPrepApi
{
    public interface IFinancialModelingPrepApiClient
    {
        ICompanyValuation CompanyValuation { get; }
        IMarketIndexes MarketIndexes { get; }
    }
}
