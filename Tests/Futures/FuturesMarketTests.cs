using MatthiWare.FinancialModelingPrep.Abstractions.Futures;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.Futures
{
    public class FuturesMarketTests : TestingBase
    {
        private readonly IFuturesMarketProvider api;

        public FuturesMarketTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IFuturesMarketProvider>();
        }

        [Fact]
        public async Task GetCommodityRealtime()
        {
            var result = await api.GetQuote("LC=F");

            result.AssertNoErrors();
            Assert.NotNull(result.Data);
            // Commodity tickers are painful.
            Assert.Equal("LCUSX", result.Data[0].Symbol);
        }
    }
}
