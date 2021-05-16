using MatthiWare.FinancialModelingPrepApi.Abstractions.CompanyValuation;

namespace MatthiWare.FinancialModelingPrepApi
{
    public interface IFinancialModelingPrepApiClient
    {
        ICompanyValuation CompanyValuation { get; }
    }
}
