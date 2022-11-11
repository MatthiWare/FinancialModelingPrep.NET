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

        [Theory]
        [InlineData("AAPL", 10)]
        [InlineData("SHUR.BR", 10)]
        public async Task GetAnalystEstimatesAsyncAnnualy(string ticker, int limit = 1)
        {
            var result = await api.GetAnalystEstimatesAsync(ticker, Period.Annual, limit: limit);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Theory]
        [InlineData("AAPL", 10)]
        [InlineData("SHUR.BR", 10)]
        public async Task GetAnalystEstimatesAsyncQuarterly(string ticker, int limit = 1)
        {
            var result = await api.GetAnalystEstimatesAsync(ticker, Period.Quarter, limit: limit);

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
