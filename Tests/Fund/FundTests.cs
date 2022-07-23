using MatthiWare.FinancialModelingPrep.Abstractions.Fund;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.CompanyValuation
{
    public class FundTests : TestingBase
    {
        private readonly IFundProvider api;

        public FundTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IFundProvider>();
        }

        [Theory]
        [InlineData("AAPL")]
        [InlineData("AGS.BR")]
        [InlineData("O")]
        [InlineData("LGEN.L")]
        public async Task GetETFStockExposureAsyncTest(string symbol)
        {
            var result = await api.GetETFStockExposureAsync(symbol);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }
    }
}
