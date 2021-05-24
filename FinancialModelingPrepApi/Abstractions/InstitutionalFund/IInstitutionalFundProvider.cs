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

        /// <summary>
        /// FORM 13F statements provides position-level report of all institutional investment managers with more than $100m in assets under management (i.e. Berkshire hathaway cik).
        /// </summary>
        /// <param name="cik"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public Task<ApiResponse<List<Form13FResponse>>> GetForm13FAsync(string cik, string date);
        #endregion
    }
}
