using MatthiWare.FinancialModelingPrep.Abstractions.StockMarket;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.StockMarket
{
    public class StockMarketTests : TestingBase
    {
        private readonly IStockMarketProvider api;

        public StockMarketTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IStockMarketProvider>();
        }

        [Fact]
        public async Task GetMostActiveStocksAsync()
        {
            var result = await api.GetMostActiveStocksAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetBiggestGainerStocksAsync()
        {
            var result = await api.GetBiggestGainerStocksAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetBiggestLoserStocksAsync()
        {
            var result = await api.GetBiggestLoserStocksAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetStockScreen()
        {
            var result = await api.StockScreener(marketCapMoreThan: 1000000000, betaMoreThan: 1, volumeMoreThan: 10000, sector: MatthiWare.FinancialModelingPrep.Sector.Technology, exchange: MatthiWare.FinancialModelingPrep.Model.Exchange.NASDAQ);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }
    }
}
