using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.Calendars;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Calendars
{
    public interface ICalendarsProvider
    {
        /// <summary>
        /// Gets the Earnings Calendar
        /// </summary>
        /// <param name="from">Format YYYY-MM-DD</param>
        /// <param name="to">Format YYYY-MM-DD</param>
        /// <returns><see cref="List{EarningsCalendarResponse}"/></returns>
        Task<ApiResponse<List<EarningsCalendarResponse>>> GetEarningsCalendarAsync(string from, string to);

        /// <summary>
        /// Gets the Earnings Calendar
        /// </summary>
        /// <returns><see cref="List{EarningsCalendarResponse}"/></returns>
        Task<ApiResponse<List<EarningsCalendarResponse>>> GetEarningsCalendarAsync();

        /// <summary>
        /// Gets the Historical Earnings
        /// </summary>
        /// <param name="symbol">Symbol to use</param>
        /// <param name="limit">Limits the amount of items. Null acts as unlimited.</param>
        /// <returns><see cref="List{EarningsCalendarResponse}"/></returns>
        Task<ApiResponse<List<EarningsCalendarResponse>>> GetHistoricalEarningsCalendarAsync(string symbol, int? limit = null);

        /// <summary>
        /// Gets the IPO Calendar
        /// The maximum time interval between from and to is 3 months.
        /// </summary>
        /// <param name="from">From date YYYY-MM-DD</param>
        /// <param name="to">To date YYYY-MM-DD</param>
        /// <returns></returns>
        Task<ApiResponse<List<IPOCalendarResponse>>> GetIPOCalendarAsync(string from, string to);
    }
}
