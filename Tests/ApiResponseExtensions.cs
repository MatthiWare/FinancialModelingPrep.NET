using MatthiWare.FinancialModelingPrepApi.Model;
using Xunit;

namespace Tests
{
    public static class ApiResponseExtensions
    {
        public static void AssertNoErrors<T>(this ApiResponse<T> response)
            where T : class
        {
            Assert.NotNull(response);
            Assert.False(response.HasError, response.Error);
        }
    }
}
