using MatthiWare.FinancialModelingPrep;
using Xunit;

namespace Tests
{
    public class ClientFactoryTests
    {
        [Fact]
        public void ResolveFinancialModelingPrepApi_Works()
        {
            var api = FinancialModelingPrepApiClientFactory.CreateClient(new FinancialModelingPrepOptions());

            Assert.NotNull(api);
        }

        [Fact]
        public void API_Contains_Calendars_Provider()
        {
            var api = FinancialModelingPrepApiClientFactory.CreateClient(new FinancialModelingPrepOptions());

            Assert.NotNull(api.Calendars);
        }

        [Fact]
        public void API_Contains_Company_Provider()
        {
            var api = FinancialModelingPrepApiClientFactory.CreateClient(new FinancialModelingPrepOptions());

            Assert.NotNull(api.CompanyValuation);
        }

        [Fact]
        public void API_Contains_AdvancedData_Provider()
        {
            var api = FinancialModelingPrepApiClientFactory.CreateClient(new FinancialModelingPrepOptions());

            Assert.NotNull(api.AdvancedData);
        }

        [Fact]
        public void API_Contains_MarketIndexes_Provider()
        {
            var api = FinancialModelingPrepApiClientFactory.CreateClient(new FinancialModelingPrepOptions());

            Assert.NotNull(api.MarketIndexes);
        }
    }
}
