using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.AdvancedData;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData
{
    public interface IAdvancedData
    {
        Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationByCikAsync(string cik);
        Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationBySymbolAsync(string symbol);
        Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationBySicCodeAsync(string sic);
    }
}
