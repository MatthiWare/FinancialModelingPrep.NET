using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Abstractions.MarketIndexes;

namespace MatthiWare.FinancialModelingPrep
{
    public interface IFinancialModelingPrepApiClient
    {
        IAdvancedData AdvancedData { get; }
        ICompanyValuation CompanyValuation { get; }
        IMarketIndexes MarketIndexes { get; }
    }
}
