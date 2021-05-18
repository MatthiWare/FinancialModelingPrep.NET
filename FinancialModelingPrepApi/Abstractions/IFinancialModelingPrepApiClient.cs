using MatthiWare.FinancialModelingPrepApi.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrepApi.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrepApi.Abstractions.MarketIndexes;

namespace MatthiWare.FinancialModelingPrepApi
{
    public interface IFinancialModelingPrepApiClient
    {
        IAdvancedData AdvancedData { get; }
        ICompanyValuation CompanyValuation { get; }
        IMarketIndexes MarketIndexes { get; }
    }
}
