using Divergic.Logging.Xunit;
using MatthiWare.FinancialModelingPrep;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using Xunit.Abstractions;
using MatthiWare.FinancialModelingPrep.Abstractions.Http;
using MatthiWare.FinancialModelingPrep.Core.Http;

namespace Tests
{
    public abstract class TestingBase
    {
        protected IServiceCollection Services { get; private set; }
        protected IServiceProvider ServiceProvider { get; private set; }

        private static readonly IConfigurationRoot ConfigurationRoot;

        private static readonly FinancialModelingPrepOptions testingOptions;
        private static readonly IRequestRateLimiter sharedRateLimiter;

        static TestingBase()
        {
            var config = new ConfigurationBuilder();
            config.AddEnvironmentVariables("FMP_TESTS_");
            ConfigurationRoot = config.Build();

            testingOptions = CreateTestingOptions();
            sharedRateLimiter = new RequestRateLimiter(testingOptions);
        }

        public TestingBase(ITestOutputHelper testOutput)
        {
            this.Services = new ServiceCollection();

            this.Services.AddSingleton(ConfigurationRoot);

            this.Services.AddLogging(builder =>
            {
                builder.ClearProviders();
                builder.AddXunit(testOutput, CreateLoggingConfig());
                builder.SetMinimumLevel(LogLevel.Debug);
            });

            this.Services.AddSingleton(sharedRateLimiter);
            this.Services.AddFinancialModelingPrepApiClient(testingOptions);

            Build();
        }

        private static FinancialModelingPrepOptions CreateTestingOptions()
        {
            var apiKeySection = ConfigurationRoot.GetSection("API_KEY");

            var apiKey = apiKeySection?.Value ?? "demo";

            return new FinancialModelingPrepOptions()
            {
                ApiKey = apiKey,
                MaxAPICallsPerMinute = 150, // lower the amount to avoid hitting limits on subsequent commit pushes
                MaxRequestPerSecond = 5, // lower the amount to avoid hitting limits on subsequent commit pushes
            };
        }

        private static LoggingConfig CreateLoggingConfig()
        {
            var config = new LoggingConfig();

            config.SensitiveValues.Add(testingOptions.ApiKey);

            return config;
        }

        protected void Build()
        {
            this.ServiceProvider = this.Services.BuildServiceProvider();
        }
    }
}
