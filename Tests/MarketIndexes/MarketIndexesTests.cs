using MatthiWare.FinancialModelingPrep;
using MatthiWare.FinancialModelingPrep.Abstractions.MarketIndexes;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.MarketIndexes
{
    public class MarketIndexesTests : TestingBase
    {
        private readonly IMarketIndexesProvider api;

        public MarketIndexesTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IMarketIndexesProvider>();
        }

        [Fact]
        public async Task GetDowJonesCompaniesTests()
        {
            var result = await api.GetDowJonesCompaniesAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetNasdaqCompaniesTests()
        {
            var result = await api.GetNasdaqCompaniesAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetSP500CompaniesTests()
        {
            var result = await api.GetSP500CompaniesAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }
    }
}
