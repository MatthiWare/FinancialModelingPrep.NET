using MatthiWare.FinancialModelingPrep.Abstractions.StockTimeSeries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
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
        public async Task GetStockQuote()
        {
            var result = await api.GetQuoteAsync("AAPL");

            result.AssertNoErrors();
            Assert.Equal("AAPL", result.Data[0].Symbol);
        }

        [Fact]
        public async Task GetHistoricalDividendsAsync()
        {
            var result = await api.GetHistoricalDividendsAsync("AAPL");

            result.AssertNoErrors();

            var dividend = result.Data.Historical.First(data => data.Date == "2021-05-07");

            Assert.Equal(0.22m, dividend.Dividend);
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

            Assert.Equal(4.0m, split.Numerator);
            Assert.Equal(1.0m, split.Denominator);
        }

        [Fact]
        public async Task GetHistoricalDailyPricesAsync()
        {
            var result = await api.GetHistoricalDailyPricesAsync("AAPL");

            result.AssertNoErrors();

            var split = result.Data.Historical.First(data => data.Date == "2021-06-04");

            Assert.Equal(125.89d, split.Close, 2);
            Assert.Equal(124.07d, split.Open.Value, 2);
            Assert.Equal(126.16d, split.High.Value, 2);
            Assert.Equal(123.85d, split.Low.Value, 2);
        }

        [Fact]
        public async Task GetHistoricalDailyPricesUsingFromToAsync()
        {
            var result = await api.GetHistoricalDailyPricesAsync("AAPL", "2021-06-03", "2021-06-05");

            result.AssertNoErrors();

            Assert.Equal(2, result.Data.Historical.Count);

            var split = result.Data.Historical.First(data => data.Date == "2021-06-04");

            Assert.Equal(125.89d, split.Close, 2);
            Assert.Equal(124.07d, split.Open.Value, 2);
            Assert.Equal(126.16d, split.High.Value, 2);
            Assert.Equal(123.85d, split.Low.Value, 2);
        }

        [Fact]
        public async Task GetHistoricalDailyPricesForLineChartAsync()
        {
            var result = await api.GetHistoricalDailyPricesForLineChartAsync("AAPL");

            result.AssertNoErrors();

            var split = result.Data.Historical.First(data => data.Date == "2021-06-04");

            Assert.Equal(125.89m, split.Close, 2);
        }

        [Fact]
        public async Task GetHistoricalDailyPricesForLineChartUsingFromToAsync()
        {
            var result = await api.GetHistoricalDailyPricesForLineChartAsync("AAPL", "2021-06-03", "2021-06-05");

            result.AssertNoErrors();

            Assert.Equal(2, result.Data.Historical.Count);

            var split = result.Data.Historical.First(data => data.Date == "2021-06-04");

            Assert.Equal(125.89m, split.Close, 2);
        }
    }
}
