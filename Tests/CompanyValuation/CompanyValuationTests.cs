using MatthiWare.FinancialModelingPrep;
using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.CompanyValuation
{
    public class CompanyValuationTests : TestingBase
    {
        private readonly ICompanyValuationProvider api;

        public CompanyValuationTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<ICompanyValuationProvider>();
        }

        [Fact]
        public async Task GetCompanyProfileTests()
        {
            var result = await api.GetCompanyProfileAsync("AAPL");

            result.AssertNoErrors();
            Assert.Equal("AAPL", result.Data.symbol);
        }

        [Fact]
        public async Task GetCompanyProfile_Unknown_Symbol_Returns_HasError_True()
        {
            var result = await api.GetCompanyProfileAsync("doesnotexist");

            Assert.NotNull(result);
            Assert.True(result.HasError);
        }

        [Fact]
        public async Task GetSymbolsList()
        {
            var result = await api.GetSymbolsListAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetETFList()
        {
            var result = await api.GetETFListAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetTradableSymbolsList()
        {
            var result = await api.GetTradableSymbolsListAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetEnterpriseValue()
        {
            var result = await api.GetEnterpriseValueAsync("AAPL", Period.Annual, 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.symbol));
        }

        [Fact]
        public async Task GetIncomeStatement()
        {
            var result = await api.GetIncomeStatementAsync("AAPL", Period.Annual, 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetCashFlowStatement()
        {
            var result = await api.GetCashFlowStatementAsync("AAPL", Period.Annual, 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetBalanceSheetStatement()
        {
            var result = await api.GetBalanceSheetStatementAsync("AAPL", Period.Annual, 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetStockNewsAsync()
        {
            var result = await api.GetStockNewsAsync("AAPL", 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetCompanyRatingAsync()
        {
            var result = await api.GetCompanyRatingAsync("AAPL");

            result.AssertNoErrors();
            Assert.Equal("AAPL", result.Data.Symbol);
        }

        [Fact]
        public async Task GetHistoricalCompanyRatingAsync()
        {
            var result = await api.GetHistoricalCompanyRatingAsync("AAPL", 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetDiscountedCashFlowAsync()
        {
            var result = await api.GetDiscountedCashFlowAsync("AAPL");

            result.AssertNoErrors();
            Assert.Equal("AAPL", result.Data.Symbol);
        }

        [Fact]
        public async Task GetHistoricalDiscountedCashFlowAsync()
        {
            var result = await api.GetHistoricalDiscountedCashFlowAsync("AAPL", Period.Quarter);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetHistoricalDiscountedCashFlowDailyAsync()
        {
            var result = await api.GetHistoricalDiscountedCashFlowDailyAsync("AAPL", 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetCompanyKeyMetricsTTMAsync()
        {
            var result = await api.GetCompanyKeyMetricsTTMAsync("AAPL");

            result.AssertNoErrors();
        }

        [Fact]
        public async Task GetCompanyKeyMetricsAsync()
        {
            var result = await api.GetCompanyKeyMetricsAsync("AAPL", Period.Quarter, 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Theory]
        [MemberData(nameof(AvailableExchanges))]
        public async Task GetQuotesAsync(Exchange exchange)
        {
            var result = await api.GetQuotesAsync(exchange);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetQuoteAsync()
        {
            var result = await api.GetQuoteAsync("AAPL");

            result.AssertNoErrors();
            Assert.Equal("AAPL", result.Data.Symbol);
        }

        [Fact]
        public async Task GetHistoricalMarketCapAsync()
        {
            var result = await api.GetHistoricalMarketCapitalizationAsync("AAPL", 5);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
            Assert.Equal(5, result.Data.Count);
            Assert.All(result.Data, data => Assert.Equal("AAPL", data.Symbol));
        }

        [Fact]
        public async Task GetMarketCapAsync()
        {
            var result = await api.GetMarketCapitalizationAsync("AAPL");

            result.AssertNoErrors();
            Assert.Equal("AAPL", result.Data.Symbol);
        }

        public static IEnumerable<object[]> AvailableExchanges
        {
            get 
            {
                foreach (var enumValue in Enum.GetValues<Exchange>())
                {
                    yield return new object[] { enumValue };
                }
            }
        }
    }
}
