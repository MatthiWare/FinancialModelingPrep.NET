using MatthiWare.FinancialModelingPrep;
using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.AdvancedData;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.AdvancedData
{
    public class CompanyValuationTests : TestingBase
    {
        private readonly IAdvancedDataProvider api;

        public CompanyValuationTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IAdvancedDataProvider>();
        }

        [Fact]
        public async Task GetFinancialReportAnnualAsync()
        {
            var result = await api.GetAnnualReportsForm10KJsonAsync("AAPL", 2020);

            result.AssertNoErrors();
            Assert.Contains("10-K", result.Data);
            Assert.Contains("AAPL", result.Data);
        }

        [Fact]
        public async Task GetFinancialReportQuarterAsync()
        {
            var result = await api.GetQuarterlyReportsForm10QJsonAsync("AAPL", 2020, Quarter.Q1);

            result.AssertNoErrors();
            Assert.Contains("10-Q", result.Data);
            Assert.Contains("AAPL", result.Data);
        }

        [Theory]
        [InlineData("cik", "0000320193")]
        [InlineData("sic", "3571")]
        [InlineData("symbol", "AAPL")]
        public async Task GetStandardIndustrialClassificationByCikAsync(string by, string value)
        {
            var result = await GetStandardIndustrialClassSwitch(by, value);

            result.AssertNoErrors();
            Assert.Equal("AAPL", result.Data.Symbol);
            Assert.Equal("0000320193", result.Data.Cik);
            Assert.Equal("3571", result.Data.SicCode);
        }

        [Fact]
        public async Task GetStockPeersAsync()
        {
            var result = await api.GetStockPeersAsync("AAPL");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data.PeersList);
            Assert.Equal("AAPL", result.Data.Symbol);
        }

        [Fact]
        public async Task GetSectorsPriceEarningsRatioAsync()
        {
            var result = await api.GetSectorsPriceEarningsRatioAsync("2021-05-07", "NYSE");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetIndustriesPriceEarningsRatioAsync()
        {
            var result = await api.GetIndustriesPriceEarningsRatioAsync("2021-05-07", "NYSE");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetSharesFloatAsync()
        {
            var result = await api.GetSharesFloatAsync("AAPL");

            result.AssertNoErrors();
            Assert.True(result.Data.FloatShares > 0);
            Assert.True(result.Data.FreeFloat > 0);
            Assert.True(result.Data.OutstandingShares > 0);
        }

        [Fact]
        public async Task GetESGScoreAsync()
        {
            var result = await api.GetESGScoreAsync("AAPL");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            
        }

        private Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassSwitch(string by, string value)
        {
            return by switch
            {
                "cik" => api.GetStandardIndustrialClassificationByCikAsync(value),
                "sic" => api.GetStandardIndustrialClassificationBySicCodeAsync(value),
                "symbol" => api.GetStandardIndustrialClassificationBySymbolAsync(value),
                _ => null,
            };
        }
    }
}
