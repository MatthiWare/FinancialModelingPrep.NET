using Bert.RateLimiters;
using MatthiWare.FinancialModelingPrep.Abstractions.Http;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.Http
{
    public class RequestRateLimiter : IRequestRateLimiter
    {
        private readonly SemaphoreSlim threadsLimiter;
        private readonly RollingWindowThrottler rollingWindowThrottler;

        public RequestRateLimiter(FinancialModelingPrepOptions options)
        {
            this.threadsLimiter = new SemaphoreSlim(options.MaxRequestPerSecond, options.MaxRequestPerSecond);
            this.rollingWindowThrottler = new RollingWindowThrottler(options.MaxAPICallsPerMinute, TimeSpan.FromMinutes(1));
        }

        public async Task ThrottleAsync()
        { 
            await threadsLimiter.WaitAsync();

            if (rollingWindowThrottler.ShouldThrottle(out var waitTime))
            {
                await Task.Delay((int)waitTime);
            }
        }

        public void ReleaseThrottle() => threadsLimiter.Release();
    }
}
