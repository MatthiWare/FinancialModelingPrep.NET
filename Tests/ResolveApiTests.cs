﻿using MatthiWare.FinancialModelingPrep;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class ResolveApiTests : TestingBase
    {
        public ResolveApiTests(ITestOutputHelper testOutput) : base(testOutput)
        {
        }

        [Fact]
        public void ResolveFinancialModelingPrepApi_Works()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api);
        }

        [Fact]
        public void API_Contains_Calendars_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.Calendars);
        }

        [Fact]
        public void API_Contains_Company_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.CompanyValuation);
        }

        [Fact]
        public void API_Contains_AdvancedData_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.AdvancedData);
        }

        [Fact]
        public void API_Contains_MarketIndexes_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.MarketIndexes);
        }

        [Fact]
        public void API_Contains_StockTimeSeries_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.StockTimeSeries);
        }

        [Fact]
        public void API_Contains_StockMarket_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.StockMarket);
        }

        [Fact]
        public void API_Contains_StockStatistics_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.StockStatistics);
        }

        [Fact]
        public void API_Contains_Crypto_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.Crypto);
        }

        [Fact]
        public void API_Contains_Fund_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.Fund);
        }

        [Fact]
        public void API_Contains_Economics_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.Economics);
        }
        
        [Fact]
        public void API_Contains_StatementAnalysis_Provider()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            Assert.NotNull(api.StatementAnalysis);
        }
    }
}
