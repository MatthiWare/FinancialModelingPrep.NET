using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Abstractions.MarketIndexes;
using MatthiWare.FinancialModelingPrep.Core;
using MatthiWare.FinancialModelingPrep.Core.AdvancedData;
using MatthiWare.FinancialModelingPrep.Core.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Core.MarketIndexes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace MatthiWare.FinancialModelingPrep
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
