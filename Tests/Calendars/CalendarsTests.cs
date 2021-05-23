using MatthiWare.FinancialModelingPrep;
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
        public CalendarsTests(ITestOutputHelper testOutput) : base(testOutput)
        {
        }

        [Theory]
        [InlineData("2021-04-14", null)]
        [InlineData(null, "2021-04-14")]
        [InlineData(null, null)]
        public async Task GetEarningsCalendarFromToAsync_With_Null_Args_Throws(string from, string to)
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            await Assert.ThrowsAsync<ArgumentException>(() => api.Calendars.GetEarningsCalendarAsync(from, to));
        }

        [Fact]
        public async Task GetEarningsCalendarFromToAsync_With_Incorrect_Args_Returns_Error_State()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.Calendars.GetEarningsCalendarAsync("2021-04-21", "2010-01-01");

            Assert.True(result.HasError);
        }

        [Fact]
        public async Task GetEarningsCalendarAsync()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.Calendars.GetEarningsCalendarAsync();

            result.AssertNoErrors();
        }

        [Fact]
        public async Task GetEarningsCalendarFromToAsync()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.Calendars.GetEarningsCalendarAsync("2021-04-14", "2021-04-14");

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
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.Calendars.GetHistoricalEarningsCalendarAsync("AAPL", 5);

            result.AssertNoErrors();
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, _ => Assert.Equal("AAPL", _.Symbol));
        }
    }
}
