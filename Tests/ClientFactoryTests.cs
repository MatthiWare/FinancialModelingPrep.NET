using MatthiWare.FinancialModelingPrep;
using Xunit;

namespace Tests
{
    public class ClientFactoryTests
    {
        private readonly IFinancialModelingPrepApiClient api;

        public ClientFactoryTests()
        {
            this.api = FinancialModelingPrepApiClientFactory.CreateClient(new());
        }

        [Fact]
        public void ResolveFinancialModelingPrepApi_Works()
        {
            Assert.NotNull(api);
        }

        [Fact]
        public void API_Contains_Calendars_Provider()
        {
            Assert.NotNull(api.Calendars);
        }

        [Fact]
        public void API_Contains_Company_Provider()
        {
            Assert.NotNull(api.CompanyValuation);
        }

        [Fact]
        public void API_Contains_AdvancedData_Provider()
        {
            Assert.NotNull(api.AdvancedData);
        }

        [Fact]
        public void API_Contains_MarketIndexes_Provider()
        {
            Assert.NotNull(api.MarketIndexes);
        }

        [Fact]
        public void API_Contains_StockTimeSeries_Provider()
        {
            Assert.NotNull(api.StockTimeSeries);
        }

        [Fact]
        public void API_Contains_StockMarket_Provider()
        {
            Assert.NotNull(api.StockMarket);
        }

        [Fact]
        public void API_Contains_CryptoMarket_Provider()
        {
            Assert.NotNull(api.Crypto);
        }

        [Fact]
        public void API_Contains_Fund_Provider()
        {
            Assert.NotNull(api.Fund);
        }

        [Fact]
        public void API_Contains_Economics_Provider()
        {
            Assert.NotNull(api.Economics);
        }
        
        [Fact]
        public void API_Contains_StatementAnalysis_Provider()
        {
            Assert.NotNull(api.StatementAnalysis);
        }
    }
}
