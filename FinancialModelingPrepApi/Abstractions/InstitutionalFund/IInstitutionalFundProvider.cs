using MatthiWare.FinancialModelingPrep.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.InstitutionalFund
{
    public interface IInstitutionalFundProvider
    {
        #region 13F
        public Task<ApiResponse<List<CikListResponse>>> Get13FListAsync();
        #endregion
    }
}
