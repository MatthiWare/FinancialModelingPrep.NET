using Microsoft.Extensions.DependencyInjection;

namespace MatthiWare.FinancialModelingPrep
{
    /// <summary>
    /// Exposes factory methods to easily create clients without using dependency injection.
    ///  If you do want to use DI please see <see cref="DependencyInjectionExtensions.AddFinancialModelingPrepApiClient(IServiceCollection, FinancialModelingPrepOptions)"/>
    /// </summary>
    public static class FinancialModelingPrepApiClientFactory
    {
        /// <summary>
        /// Creates an FMP API Client with all dependencies already wired up.
        /// If you do want to use DI please see <see cref="DependencyInjectionExtensions.AddFinancialModelingPrepApiClient(IServiceCollection, FinancialModelingPrepOptions)"/>
        /// </summary>
        /// <param name="options"><see cref="FinancialModelingPrepOptions"/></param>
        /// <returns>An instance of <see cref="IFinancialModelingPrepApiClient"/></returns>
        public static IFinancialModelingPrepApiClient CreateClient(FinancialModelingPrepOptions options)
        {
            var services = new ServiceCollection();

            services.AddFinancialModelingPrepApiClient(options);

            var provider = services.BuildServiceProvider();

            return provider.GetRequiredService<IFinancialModelingPrepApiClient>();
        }
    }
}
