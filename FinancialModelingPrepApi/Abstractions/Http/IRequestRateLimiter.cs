using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.Http
{
    public interface IRequestRateLimiter
    {
        public Task ThrottleAsync();
        public void ReleaseThrottle();
    }
}
