using MatthiWare.FinancialModelingPrepApi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using Xunit.Abstractions;

namespace Tests
{
    public abstract class TestingBase
    {
        protected IServiceCollection Services { get; private set; }
        protected IServiceProvider ServiceProvider { get; private set; }

        public TestingBase(ITestOutputHelper testOutput)
        {
            this.Services = new ServiceCollection();

            this.Services.AddLogging(builder => 
            {
                builder.ClearProviders();
                builder.AddXunit(testOutput);
                builder.SetMinimumLevel(LogLevel.Trace);
            });

            this.Services.AddFinancialModelingPrepApiClient(new FinancialModelingPrepOptions());

            Build();
        }

        protected void Build()
        {
            this.ServiceProvider = this.Services.BuildServiceProvider();
        }
    }
}
