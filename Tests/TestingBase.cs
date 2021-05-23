using Divergic.Logging.Xunit;
using MatthiWare.FinancialModelingPrep;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using Xunit.Abstractions;

namespace Tests
{
    public abstract class TestingBase
    {
        protected IServiceCollection Services { get; private set; }
        protected IServiceProvider ServiceProvider { get; private set; }

        private static readonly IConfigurationRoot ConfigurationRoot;

        static TestingBase()
        {
            var config = new ConfigurationBuilder();
            config.AddEnvironmentVariables("FMP_TESTS_");
            ConfigurationRoot = config.Build();
        }

        public TestingBase(ITestOutputHelper testOutput)
        {
            this.Services = new ServiceCollection();

            this.Services.AddSingleton(ConfigurationRoot);

            // TODO: add logging not possible yet as I don't want to expose API Keys in the CI/CD logs
            // See:  
            this.Services.AddLogging(builder =>
            {
                builder.ClearProviders();
                builder.AddXunit(testOutput, CreateLoggingConfig());
                builder.SetMinimumLevel(LogLevel.Debug);
            });

            this.Services.AddFinancialModelingPrepApiClient(CreateDefaultFMPOptions());

            Build();
        }

        private static FinancialModelingPrepOptions CreateDefaultFMPOptions()
        {
            var apiKeySection = ConfigurationRoot.GetSection("API_KEY");

            var apiKey = apiKeySection?.Value ?? "demo";

            return new FinancialModelingPrepOptions()
            {
                ApiKey = apiKey
            };
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
