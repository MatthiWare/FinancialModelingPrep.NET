using MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData;
using MatthiWare.FinancialModelingPrep.Core.Http;

namespace MatthiWare.FinancialModelingPrep.Core.AdvancedData
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
