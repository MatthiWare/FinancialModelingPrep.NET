using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit;
using MatthiWare.FinancialModelingPrep.Abstractions.Economics;
using MatthiWare.FinancialModelingPrep.Model.Economics;

namespace Tests.Economics
{
    public class EconomicsTest : TestingBase
    {
        private readonly IEconomicsProvider api;

        public EconomicsTest(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<IEconomicsProvider>();
        }

        [Theory]
        [MemberData(nameof(AllEconomicIndicators))]
        public async Task GetEconomicIndicatorAsync(EconomicIndicator indicator)
        {
            var result = await api.GetEconomicIndicatorAsync(indicator, "2020-01-01", "2022-01-01");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        public static IEnumerable<object[]> AllEconomicIndicators
        {
            get
            {
                foreach (var enumValue in Enum.GetValues<EconomicIndicator>())
                {
                    yield return new object[] { enumValue };
                }
            }
        }
    }
}

