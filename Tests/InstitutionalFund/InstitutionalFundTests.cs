using MatthiWare.FinancialModelingPrep.Abstractions.InstitutionalFund;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.InstitutionalFund
{
    public class InstitutionalFundTests : TestingBase
    {
        private readonly IInstitutionalFundProvider api;

        public InstitutionalFundTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IInstitutionalFundProvider>();
        }

        [Fact]
        public async Task Get13FListAsync()
        {
            var result = await api.Get13FListAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task SearchCIKByName()
        {
            var result = await api.SearchCikByName("Berkshire");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetCompanyNameByCIK()
        {
            var result = await api.GetCompanyNameByCik("0001067983");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);

            Assert.All(result.Data, _ => Assert.Equal("0001067983", _.Cik));
        }

        [Fact]
        public async Task MapCusipAsync()
        {
            var result = await api.MapCusipAsync("000360206");

            result.AssertNoErrors();
            Assert.Equal("AAON", result.Data.Ticker);
        }

        [Fact]
        public async Task GetForm13FAsync()
        {
            var result = await api.GetForm13FAsync("0001067983", "2020-06-30");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);

            var apple = result.Data.First(_ => _.Tickercusip == "AAPL");

            Assert.Equal(245155566, apple.Shares);
        }
    }
}
