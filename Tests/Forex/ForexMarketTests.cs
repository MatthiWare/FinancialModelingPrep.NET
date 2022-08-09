using MatthiWare.FinancialModelingPrep.Abstractions.Forex;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.Forex
{
    public class ForexMarketTests : TestingBase
    {
        private readonly IForexMarketProvider api;

        public ForexMarketTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IForexMarketProvider>();
        }

        [Fact]
        public async Task GetCurrencyPairRealtime()
        {
            var result = await api.GetQuote("USDJPY");

            result.AssertNoErrors();
            Assert.NotNull(result.Data);
            Assert.Equal("USDJPY", result.Data[0].Symbol);
        }
    }
}
