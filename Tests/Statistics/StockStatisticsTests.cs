using MatthiWare.FinancialModelingPrep.Abstractions.Statistics;
using MatthiWare.FinancialModelingPrep.Model;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.Statistics
{
    public class StockStatisticsTests : TestingBase
    {
        private readonly IStockStatisticsProvider api;

        public StockStatisticsTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IStockStatisticsProvider>();
        }

        [Fact]
        public async Task GetAnalystEstimatesAsyncAnnualy()
        {
            var result = await api.GetAnalystEstimatesAsync("AAPL", Period.Annual, limit: 1);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetAnalystEstimatesAsyncQuarterly()
        {
            var result = await api.GetAnalystEstimatesAsync("AAPL", Period.Quarter, limit: 1);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetSocialSentimentAsync()
        {
            var result = await api.GetSocialSentimentAsync("AAPL");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }
    }
}
