using MatthiWare.FinancialModelingPrepApi;
using MatthiWare.FinancialModelingPrepApi.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrepApi.Model;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.CompanyValuation
{
    public class CompanyValuationTests : TestingBase
    {
        public CompanyValuationTests(ITestOutputHelper testOutput) : base(testOutput)
        {
        }

        [Fact]
        public async Task GetCompanyProfileTests()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetCompanyProfileAsync("AAPL");

            result.AssertNoErrors();
            Assert.Equal("AAPL", result.Data.symbol);
        }

        [Fact]
        public async Task GetCompanyProfile_Unknown_Symbol_Returns_HasError_True()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetCompanyProfileAsync("doesnotexist");

            Assert.NotNull(result);
            Assert.True(result.HasError);
        }

        [Fact]
        public async Task GetSymbolsList()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetSymbolsListAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetETFList()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetETFListAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetTradableSymbolsList()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetTradableSymbolsListAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetEnterpriseValue()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetEnterpriseValueAsync("AAPL", Period.Annual, 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.symbol));
        }

        [Fact]
        public async Task GetIncomeStatement()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetIncomeStatementAsync("AAPL", Period.Annual, 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetCashFlowStatement()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetCashFlowStatementAsync("AAPL", Period.Annual, 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetBalanceSheetStatement()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetBalanceSheetStatementAsync("AAPL", Period.Annual, 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetStockNewsAsync()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetStockNewsAsync("AAPL", 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetCompanyRatingAsync()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetCompanyRatingAsync("AAPL");

            result.AssertNoErrors();
            Assert.Equal("AAPL", result.Data.Symbol);
        }

        [Fact]
        public async Task GetHistoricalCompanyRatingAsync()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.CompanyValuation.GetHistoricalCompanyRatingAsync("AAPL", 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }
    }
}
