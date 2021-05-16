using FinancialModelingPrepApi.Abstractions.CompanyValuation;

namespace FinancialModelingPrepApi
{
    public interface IFinancialModelingPrepApiClient
    {
        ICompanyValuation CompanyValuation { get; }
    }
}
