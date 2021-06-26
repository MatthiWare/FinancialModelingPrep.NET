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
        private readonly RollingWindowThrottler maxApiCallsPerMinuteThrottler;
        private readonly RollingWindowThrottler maxRequestsPerSecondThrottler;

        public RequestRateLimiter(FinancialModelingPrepOptions options)
        {
            this.threadsLimiter = new SemaphoreSlim(options.MaxRequestPerSecond, options.MaxRequestPerSecond);
            this.maxApiCallsPerMinuteThrottler = new RollingWindowThrottler(options.MaxAPICallsPerMinute, TimeSpan.FromMinutes(1));
            this.maxRequestsPerSecondThrottler = new RollingWindowThrottler(options.MaxRequestPerSecond, TimeSpan.FromSeconds(1));
        }

        public async Task<(bool wasThrottled, TimeSpan totalDelay)> ThrottleAsync()
        {
            var totalDelay = TimeSpan.Zero;
            var wasThrottled = false;

            await threadsLimiter.WaitAsync();

            while (maxRequestsPerSecondThrottler.ShouldThrottle(out var waitTime))
            {
                wasThrottled = true;
                totalDelay = totalDelay.Add(TimeSpan.FromMilliseconds(waitTime));
            }

            while (maxApiCallsPerMinuteThrottler.ShouldThrottle(out var waitTime))
            {
                wasThrottled = true;
                totalDelay = totalDelay.Add(TimeSpan.FromMilliseconds(waitTime));

                await Task.Delay((int)waitTime);
            }

            return (wasThrottled, totalDelay);
        }

        public void ReleaseThrottle() => threadsLimiter.Release();
    }
}
