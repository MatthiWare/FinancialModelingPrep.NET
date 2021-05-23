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
