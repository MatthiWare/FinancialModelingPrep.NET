using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Abstractions.Calendars;
using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Abstractions.InstitutionalFund;
using MatthiWare.FinancialModelingPrep.Abstractions.MarketIndexes;
using MatthiWare.FinancialModelingPrep.Core;
using MatthiWare.FinancialModelingPrep.Core.AdvancedData;
using MatthiWare.FinancialModelingPrep.Core.Calendars;
using MatthiWare.FinancialModelingPrep.Core.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Core.InstitutionalFund;
using MatthiWare.FinancialModelingPrep.Core.MarketIndexes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace MatthiWare.FinancialModelingPrep
{
    public static class DependencyInjectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IFinancialModelingPrepApiClient"/> to the services.
        /// This package does not override any existing registrations. 
        /// </summary>
        /// <param name="services">DI Service Collection</param>
        /// <param name="options">FMP Options <see cref="FinancialModelingPrepOptions"/> if left as null it will use the default options and default API Key</param>
        public static void AddFinancialModelingPrepApiClient(this IServiceCollection services, FinancialModelingPrepOptions options = null)
        {
            services.TryAddSingleton(options ?? new FinancialModelingPrepOptions());

            services.AddLogging();

            services.AddHttpClient<FinancialModelingPrepHttpClient>(client 
                => client.BaseAddress = new Uri("https://financialmodelingprep.com/api/"));

            services.TryAddSingleton<IFinancialModelingPrepApiClient, FinancialModelingPrepApiClient>();
            services.TryAddTransient<ICompanyValuationProvider, CompanyValuationProvider>();
            services.TryAddTransient<IMarketIndexesProvider, MarketIndexesProvider>();
            services.TryAddTransient<IAdvancedDataProvider, AdvancedDataProvider>();
            services.TryAddTransient<ICalendarsProvider, CalendarsProvider>();
            services.TryAddTransient<IInstitutionalFundProvider, InstitutionalFundProvider>();
        }
    }
}
