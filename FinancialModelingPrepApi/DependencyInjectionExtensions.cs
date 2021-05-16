using FinancialModelingPrepApi.Core.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using FinancialModelingPrepApi.Core;
using FinancialModelingPrepApi.Abstractions.CompanyValuation;
using FinancialModelingPrepApi.Core.CompanyValuation;

namespace FinancialModelingPrepApi
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
        }
    }
}
