using System;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Http
{
    public interface IRequestRateLimiter
    {
        public Task<(bool wasThrottled, TimeSpan totalDelay)> ThrottleAsync();
        public void ReleaseThrottle();
    }
}
