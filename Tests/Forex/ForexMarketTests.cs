using MatthiWare.FinancialModelingPrep.Abstractions.Forex;
using Microsoft.Extensions.DependencyInjection;
using System;
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
            var result = await api.GetQuoteAsync("USDJPY");

            result.AssertNoErrors();
            Assert.NotNull(result.Data);
            Assert.Equal("USDJPY", result.Data[0].Symbol);
        }

        [Fact]
        public async Task GetCurrencyPairHistorical()
        {
            var result = await api.GetHistoricalQuoteAsync("USDJPY", MatthiWare.FinancialModelingPrep.Model.HistoricalPricingPeriod.OneMinute);

            result.AssertNoErrors();
            Assert.NotNull(result.Data);
            Assert.NotNull(result.Data[0].Date);
        }
    }
}
