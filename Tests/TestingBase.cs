using Divergic.Logging.Xunit;
using MatthiWare.FinancialModelingPrep;
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
                builder.AddXunit(testOutput, CreateLoggingConfig());
                builder.SetMinimumLevel(LogLevel.Debug);
            });

            this.Services.AddFinancialModelingPrepApiClient(new FinancialModelingPrepOptions());

            Build();
        }

        private static LoggingConfig CreateLoggingConfig()
        {
            var config = new LoggingConfig();

            config.Formatter = new RemoveApiKeyFromLogSanitizer("demo", config.Formatter);

            return config;
        }

        protected void Build()
        {
            this.ServiceProvider = this.Services.BuildServiceProvider();
        }
    }
}
