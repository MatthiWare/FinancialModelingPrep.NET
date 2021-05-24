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
    }
}
