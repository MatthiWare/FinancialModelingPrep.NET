using FinancialModelingPrepApi;
using FinancialModelingPrepApi.Abstractions.CompanyValuation;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.CompanyValuation
{
    public class CompanyValuationTests : TestingBase
    {
        public CompanyValuationTests(ITestOutputHelper testOutput) : base(testOutput)
        {
        }

        [Fact]
        public async Task GetCompanyProfileTests()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetCompanyProfileAsync("AAPL,MSFT");

            Assert.NotNull(result);
            Assert.False(result.HasError);
        }
    }
}
