using MatthiWare.FinancialModelingPrepApi.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrepApi.Core.Http;

namespace MatthiWare.FinancialModelingPrepApi.Core.AdvancedData
{
    public class AdvancedData : IAdvancedData
    {
        private readonly FinancialModelingPrepHttpClient client;

        public AdvancedData(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }
    }
}
