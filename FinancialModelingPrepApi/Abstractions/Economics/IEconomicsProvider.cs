using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Economics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Economics
{
    public interface IEconomicsProvider
    {
        /// <summary>
        /// Gets the economic indicator result for a given timeframe
        /// </summary>
        /// <param name="indicator">Economic indicator to use</param>
        /// <param name="from">Format YYYY-MM-DD</param>
        /// <param name="to">Format YYYY-MM-DD</param>
        /// <returns><see cref="EconomicIndicatorResponse"/></returns>
        public Task<ApiResponse<List<EconomicIndicatorResponse>>> GetEconomicIndicatorAsync(EconomicIndicator indicator, string from, string to);
    }
}
