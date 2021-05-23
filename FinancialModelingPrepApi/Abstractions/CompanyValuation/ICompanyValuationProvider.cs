using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.CompanyValuation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation
{
    public interface ICompanyValuationProvider
    {
        public Task<ApiResponse<QuoteResponse>> GetQuoteAsync(string symbol);

        public Task<ApiResponse<CompanyProfileResponse>> GetCompanyProfileAsync(string symbol);
        public Task<ApiResponse<KeyMetricsTTMResponse>> GetCompanyKeyMetricsTTMAsync(string symbol);
        public Task<ApiResponse<List<KeyMetricsResponse>>> GetCompanyKeyMetricsAsync(string symbol, Period period = Period.Annual, int? limit = 130);

        public Task<ApiResponse<DCFResponse>> GetDiscountedCashFlowAsync(string symbol);
        public Task<ApiResponse<List<HistoricalDCFResponse>>> GetHistoricalDiscountedCashFlowAsync(string symbol, Period period = Period.Annual);
        public Task<ApiResponse<List<HistoricalDailyDCFResponse>>> GetHistoricalDiscountedCashFlowDailyAsync(string symbol, int? limit = 100);

        public Task<ApiResponse<MarketCapResponse>> GetMarketCapitalizationAsync(string symbol);
        public Task<ApiResponse<List<MarketCapResponse>>> GetHistoricalMarketCapitalizationAsync(string symbol, int? limit = 100);

        public Task<ApiResponse<List<SymbolResponse>>> GetSymbolsListAsync();
        public Task<ApiResponse<List<SymbolResponse>>> GetTradableSymbolsListAsync();
        public Task<ApiResponse<List<SymbolResponse>>> GetETFListAsync();

        public Task<ApiResponse<List<EnterpriseValueResponse>>> GetEnterpriseValueAsync(string symbol, Period period = Period.Quarter, int? limit = 40);
        
        public Task<ApiResponse<List<BalanceSheetResponse>>> GetBalanceSheetStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40);
        public Task<ApiResponse<List<CashFlowResponse>>> GetCashFlowStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40);
        public Task<ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40);

        public Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(string symbol, int? limit = 50);

        public Task<ApiResponse<CompanyRatingResponse>> GetCompanyRatingAsync(string symbol);
        public Task<ApiResponse<List<CompanyRatingResponse>>> GetHistoricalCompanyRatingAsync(string symbol, int? limit = 140);
    }
}
