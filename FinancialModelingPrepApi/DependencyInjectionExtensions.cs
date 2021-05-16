using FinancialModelingPrepApi.Abstractions;
using FinancialModelingPrepApi.Core;
using FinancialModelingPrepApi.Core.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace FinancialModelingPrepApi
{
    public static class DependencyInjectionExtensions
    {
        public static void AddFinancialModelingPrepApiClient(this IServiceCollection services)
        {
            services.AddLogging();
            services.AddHttpClient<FinancialModelingPrepHttpClient>(client 
                => client.BaseAddress = new Uri("https://financialmodelingprep.com/api/"));
            services.TryAddSingleton<IFinancialModelingPrepApiClient, FinancialModelingPrepApiClient>();
        }
    }
}
