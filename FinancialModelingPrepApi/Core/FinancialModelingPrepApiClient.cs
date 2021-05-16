using FinancialModelingPrepApi.Abstractions.CompanyValuation;

namespace FinancialModelingPrepApi.Core
{
    public class FinancialModelingPrepApiClient : IFinancialModelingPrepApiClient
    {
        public ICompanyValuation CompanyValuation { get; private set; }

        public FinancialModelingPrepApiClient(ICompanyValuation companyValuation)
        {
            this.CompanyValuation = companyValuation;
        }
    }
}
