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
        [InlineData("AAPL")]
        [InlineData("SHUR.BR", 10)]
        public async Task GetAnalystEstimatesAsyncAnnualy(string ticker, int limit = 1)
        {
            var result = await api.GetAnalystEstimatesAsync(ticker, Period.Annual, limit: limit);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Theory]
        [InlineData("AAPL")]
        [InlineData("SHUR.BR")]
        public async Task GetAnalystEstimatesAsyncQuarterly(string ticker)
        {
            var result = await api.GetAnalystEstimatesAsync(ticker, Period.Quarter, limit: 1);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Theory]
        [InlineData("AAPL")]
        [InlineData("SHUR.BR")]
        public async Task GetSocialSentimentAsync(string ticker)
        {
            var result = await api.GetSocialSentimentAsync(ticker);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }
    }
}
