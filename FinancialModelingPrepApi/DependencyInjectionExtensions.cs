using MatthiWare.FinancialModelingPrepApi.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrepApi.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrepApi.Abstractions.MarketIndexes;
using MatthiWare.FinancialModelingPrepApi.Core;
using MatthiWare.FinancialModelingPrepApi.Core.AdvancedData;
using MatthiWare.FinancialModelingPrepApi.Core.CompanyValuation;
using MatthiWare.FinancialModelingPrepApi.Core.Http;
using MatthiWare.FinancialModelingPrepApi.Core.MarketIndexes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace MatthiWare.FinancialModelingPrepApi
{
    public static class DependencyInjectionExtensions
    {
        public static void AddFinancialModelingPrepApiClient(this IServiceCollection services, FinancialModelingPrepOptions options)
        {
            services.AddSingleton(options);

            services.AddLogging();

            services.AddHttpClient<FinancialModelingPrepHttpClient>(client 
                => client.BaseAddress = new Uri("https://financialmodelingprep.com/api/"));

            services.TryAddSingleton<IFinancialModelingPrepApiClient, FinancialModelingPrepApiClient>();
            services.TryAddScoped<ICompanyValuation, CompanyValuation>();
            services.TryAddScoped<IMarketIndexes, MarketIndexes>();
            services.TryAddScoped<IAdvancedData, AdvancedData>();
        }
    }
}
