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

            var result = await api.CompanyValuation.GetCompanyProfileAsync("AAPL");

            Assert.NotNull(result);
            Assert.False(result.HasError);
            Assert.Equal("AAPL", result.Data.symbol);
        }

        [Fact]
        public async Task GetCompanyProfile_Unknown_Symbol_Returns_HasError_True()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetCompanyProfileAsync("doesnotexist");

            Assert.NotNull(result);
            Assert.True(result.HasError);
        }

        [Fact]
        public async Task GetSymbolsList()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetSymbolsListAsync();

            Assert.NotNull(result);
            Assert.False(result.HasError);
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetETFList()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetETFListAsync();

            Assert.NotNull(result);
            Assert.False(result.HasError);
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetTradableSymbolsList()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetTradableSymbolsListAsync();

            Assert.NotNull(result);
            Assert.False(result.HasError);
            Assert.NotEmpty(result.Data);
        }
    }
}
