using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.InstitutionalFund;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.InstitutionalFund
{
    public interface IInstitutionalFundProvider
    {
        #region 13F
        public Task<ApiResponse<List<CikListResponse>>> Get13FListAsync();
        public Task<ApiResponse<CusipMapperResponse>> MapCusipAsync(string cusip);
        public Task<ApiResponse<List<CikListResponse>>> SearchCikByName(string name);
        public Task<ApiResponse<List<CikListResponse>>> GetCompanyNameByCik(string cik);
        #endregion
    }
}
