using MatthiWare.FinancialModelingPrep;
using MatthiWare.FinancialModelingPrep.Abstractions.Calendars;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.Calendars
{
    public class CalendarsTests : TestingBase
    {
        private readonly ICalendarsProvider api;

        public CalendarsTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<ICalendarsProvider>();
        }

        [Theory]
        [InlineData("2021-04-14", null)]
        [InlineData(null, "2021-04-14")]
        [InlineData(null, null)]
        public async Task GetEarningsCalendarFromToAsync_With_Null_Args_Throws(string from, string to)
        {
            await Assert.ThrowsAsync<ArgumentException>(() => api.GetEarningsCalendarAsync(from, to));
        }

        [Fact]
        public async Task GetEarningsCalendarFromToAsync_With_Incorrect_Args_Returns_Error_State()
        {
            var result = await api.GetEarningsCalendarAsync("2021-04-21", "2010-01-01");

            Assert.True(result.HasError);
        }

        [Fact]
        public async Task GetEarningsCalendarAsync()
        {
            var result = await api.GetEarningsCalendarAsync();

            result.AssertNoErrors();
        }

        [Fact]
        public async Task GetEarningsCalendarFromToAsync()
        {
            var result = await api.GetEarningsCalendarAsync("2021-04-14", "2021-04-14");

            result.AssertNoErrors();
            Assert.All(result.Data, _ => Assert.Equal("2021-04-14", _.Date));

            var earnings = result.Data.First(_ => _.Symbol == "JPM");

            Assert.Equal(4.5, earnings.Eps);
            Assert.Equal(0, earnings.RevenueEstimated);
            Assert.Equal(0, earnings.Revenue);
            Assert.Equal("bmo", earnings.Time);
        }

        [Fact]
        public async Task GetHistoricalEarningsCalendarAsync()
        {
            var result = await api.GetHistoricalEarningsCalendarAsync("AAPL", 5);

            result.AssertNoErrors();
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, _ => Assert.Equal("AAPL", _.Symbol));
        }

        [Theory]
        [InlineData("2021-04-14", null)]
        [InlineData(null, "2021-04-14")]
        public async Task GetIPOCalendarAsync_With_Null_Args_Throws(string from, string to)
        {
            await Assert.ThrowsAsync<ArgumentException>(() => api.GetIPOCalendarAsync(from, to));
        }

        [Fact]
        public async Task GetIPOCalendarAsync()
        {
            var result = await api.GetIPOCalendarAsync("2010-04-01", "2010-04-01");

            result.AssertNoErrors();
            Assert.Single(result.Data);
            var firstResult = result.Data.First();

            Assert.Equal("PRI", firstResult.Symbol);
            Assert.Equal(21360000, firstResult.Shares);
            Assert.Equal(320400000, firstResult.MarketCap);
        }

        [Theory]
        [InlineData("2021-04-14", null)]
        [InlineData(null, "2021-04-14")]
        public async Task GetDividendCalendarAsync_With_Null_Args_Throws(string from, string to)
        {
            await Assert.ThrowsAsync<ArgumentException>(() => api.GetDividendCalendarAsync(from, to));
        }

        [Fact]
        public async Task GetDividendCalendarAsync()
        {
            var result = await api.GetDividendCalendarAsync("2020-11-03", "2020-11-03");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            var firstResult = result.Data.First(_ => _.Symbol == "BRO");

            Assert.Equal("BRO", firstResult.Symbol);
            Assert.Equal(0.0925, firstResult.Dividend.Value, 4);
            Assert.Equal(0.0925, firstResult.AdjDividend, 4);
            Assert.Equal("2020-11-04", firstResult.RecordDate);
            Assert.Equal("2020-11-18", firstResult.PaymentDate);
            Assert.Equal("2020-10-20", firstResult.DeclarationDate);
        }

        [Theory]
        [InlineData("2021-04-14", null)]
        [InlineData(null, "2021-04-14")]
        public async Task GetEconomicCalendarAsync_With_Null_Args_Throws(string from, string to)
        {
            await Assert.ThrowsAsync<ArgumentException>(() => api.GetEconomicCalendarAsync(from, to));
        }

        [Fact]
        public async Task GetEconomicCalendarAsync()
        {
            var result = await api.GetEconomicCalendarAsync("2020-10-19", "2020-10-20");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            var firstResult = result.Data.First(_ => _.Event == "United States NAHB housing market NAHB Housing Market Indx");

            Assert.Equal("US", firstResult.Country);
            Assert.Equal("2020-10-19 14:00:00", firstResult.Date);
            Assert.Equal(85, firstResult.Actual);
            Assert.Equal(83, firstResult.Previous);
            Assert.Equal(2, firstResult.Change);
            Assert.Equal(0.0241, firstResult.ChangePercentage);
            Assert.Equal(83, firstResult.Estimate);
        }

        [Theory]
        [InlineData("2021-04-14", null)]
        [InlineData(null, "2021-04-14")]
        public async Task GetStockSplitCalendarAsync_With_Null_Args_Throws(string from, string to)
        {
            await Assert.ThrowsAsync<ArgumentException>(() => api.GetStockSplitCalendarAsync(from, to));
        }

        [Fact]
        public async Task GetStockSplitCalendarAsync()
        {
            var result = await api.GetStockSplitCalendarAsync("2020-08-31", "2020-08-31");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            var firstResult = result.Data.First(_ => _.Symbol == "AAPL");

            Assert.Equal(4, firstResult.Numerator);
            Assert.Equal(1, firstResult.Denominator);
        }
    }
}
