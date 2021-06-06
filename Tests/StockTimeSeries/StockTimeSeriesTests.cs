using MatthiWare.FinancialModelingPrep.Abstractions.StockTimeSeries;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.StockTimeSeries
{
    public class StockTimeSeriesTests : TestingBase
    {
        private readonly IStockTimeSeriesProvider api;

        public StockTimeSeriesTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IStockTimeSeriesProvider>();
        }

        [Fact]
        public async Task GetHistoricalDividendsAsync()
        {
            var result = await api.GetHistoricalDividendsAsync("AAPL");

            result.AssertNoErrors();

            var dividend = result.Data.Historical.First(data => data.Date == "2021-05-07");

            Assert.Equal(0.22, dividend.Dividend);
            Assert.Equal("2021-05-10", dividend.RecordDate);
            Assert.Equal("2021-05-13", dividend.PaymentDate);
            Assert.Equal("2021-04-28", dividend.DeclarationDate);
        }

        [Fact]
        public async Task GetHistoricalStockSplitsAsync()
        {
            var result = await api.GetHistoricalStockSplitsAsync("AAPL");

            result.AssertNoErrors();

            var split = result.Data.Historical.First(data => data.Date == "2020-08-31");

            Assert.Equal(4.0, split.Numerator);
            Assert.Equal(1.0, split.Denominator);
        }

        [Fact]
        public async Task GetHistoricalDailyPricesAsync()
        {
            var result = await api.GetHistoricalDailyPricesAsync("AAPL");

            result.AssertNoErrors();

            var split = result.Data.Historical.First(data => data.Date == "2021-06-04");

            Assert.Equal(125.89, split.Close);
            Assert.Equal(124.07, split.Open);
            Assert.Equal(126.16, split.High);
            Assert.Equal(123.85, split.Low);
        }

        [Fact]
        public async Task GetHistoricalDailyPricesForLineChartAsync()
        {
            var result = await api.GetHistoricalDailyPricesForLineChartAsync("AAPL");

            result.AssertNoErrors();

            var split = result.Data.Historical.First(data => data.Date == "2021-06-04");

            Assert.Equal(125.89, split.Close);
        }
    }
}
