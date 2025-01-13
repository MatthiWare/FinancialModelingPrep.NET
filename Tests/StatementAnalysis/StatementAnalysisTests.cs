using System.Threading.Tasks;
using MatthiWare.FinancialModelingPrep.Abstractions.StatementAnalysis;
using MatthiWare.FinancialModelingPrep.Model;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Abstractions;

namespace Tests.StatementAnalysis;

public class StatementAnalysisTests: TestingBase
{
    private readonly IStatementAnalysisProvider api;

    public StatementAnalysisTests(ITestOutputHelper testOutput) : base(testOutput)
    {
        api = ServiceProvider.GetRequiredService<IStatementAnalysisProvider>();
    }
    
    [Fact]
    public async Task GetFinancialGrowthWithLimit()
    {
        var result = await api.GetFinancialGrowthAsync("AAPL", Period.Annual, 1);
        result.AssertNoErrors();
        Assert.NotEmpty(result.Data);
        Assert.Single(result.Data);
    }
    
    [Fact]
    public async Task GetFinancialGrowthAnnual()
    {
        var result = await api.GetFinancialGrowthAsync("AAPL");
        result.AssertNoErrors();
        Assert.NotEmpty(result.Data);
    }
    
    [Fact]
    public async Task GetFinancialGrowthQuarterly()
    {
        var result = await api.GetFinancialGrowthAsync("AAPL", Period.Quarter);
        result.AssertNoErrors();
        Assert.NotEmpty(result.Data);
    }
}