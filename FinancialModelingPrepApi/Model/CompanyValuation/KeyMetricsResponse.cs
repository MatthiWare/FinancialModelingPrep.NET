using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class KeyMetricsResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("revenuePerShare")]
        public decimal? RevenuePerShare { get; set; }

        [JsonPropertyName("netIncomePerShare")]
        public decimal? NetIncomePerShare { get; set; }

        [JsonPropertyName("operatingCashFlowPerShare")]
        public decimal? OperatingCashFlowPerShare { get; set; }

        [JsonPropertyName("freeCashFlowPerShare")]
        public decimal? FreeCashFlowPerShare { get; set; }

        [JsonPropertyName("cashPerShare")]
        public decimal? CashPerShare { get; set; }

        [JsonPropertyName("bookValuePerShare")]
        public decimal? BookValuePerShare { get; set; }

        [JsonPropertyName("tangibleBookValuePerShare")]
        public decimal? TangibleBookValuePerShare { get; set; }

        [JsonPropertyName("shareholdersEquityPerShare")]
        public decimal? ShareholdersEquityPerShare { get; set; }

        [JsonPropertyName("interestDebtPerShare")]
        public decimal? InterestDebtPerShare { get; set; }

        [JsonPropertyName("marketCap")]
        public decimal? MarketCap { get; set; }

        [JsonPropertyName("enterpriseValue")]
        public decimal? EnterpriseValue { get; set; }

        [JsonPropertyName("peRatio")]
        public decimal? PeRatio { get; set; }

        [JsonPropertyName("priceToSalesRatio")]
        public decimal? PriceToSalesRatio { get; set; }

        [JsonPropertyName("pocfratio")]
        public decimal? Pocfratio { get; set; }

        [JsonPropertyName("pfcfRatio")]
        public decimal? PfcfRatio { get; set; }

        [JsonPropertyName("pbRatio")]
        public decimal? PbRatio { get; set; }

        [JsonPropertyName("ptbRatio")]
        public decimal? PtbRatio { get; set; }

        [JsonPropertyName("evToSales")]
        public decimal? EvToSales { get; set; }

        [JsonPropertyName("enterpriseValueOverEBITDA")]
        public decimal? EnterpriseValueOverEBITDA { get; set; }

        [JsonPropertyName("evToOperatingCashFlow")]
        public decimal? EvToOperatingCashFlow { get; set; }

        [JsonPropertyName("evToFreeCashFlow")]
        public decimal? EvToFreeCashFlow { get; set; }

        [JsonPropertyName("earningsYield")]
        public decimal? EarningsYield { get; set; }

        [JsonPropertyName("freeCashFlowYield")]
        public decimal? FreeCashFlowYield { get; set; }

        [JsonPropertyName("debtToEquity")]
        public decimal? DebtToEquity { get; set; }

        [JsonPropertyName("debtToAssets")]
        public decimal? DebtToAssets { get; set; }

        [JsonPropertyName("netDebtToEBITDA")]
        public decimal? NetDebtToEBITDA { get; set; }

        [JsonPropertyName("currentRatio")]
        public decimal? CurrentRatio { get; set; }

        [JsonPropertyName("interestCoverage")]
        public decimal? InterestCoverage { get; set; }

        [JsonPropertyName("incomeQuality")]
        public decimal? IncomeQuality { get; set; }

        [JsonPropertyName("dividendYield")]
        public decimal? DividendYield { get; set; }

        [JsonPropertyName("payoutRatio")]
        public decimal? PayoutRatio { get; set; }

        [JsonPropertyName("salesGeneralAndAdministrativeToRevenue")]
        public decimal? SalesGeneralAndAdministrativeToRevenue { get; set; }

        [JsonPropertyName("researchAndDdevelopementToRevenue")]
        public decimal? ResearchAndDdevelopementToRevenue { get; set; }

        [JsonPropertyName("intangiblesToTotalAssets")]
        public decimal? IntangiblesToTotalAssets { get; set; }

        [JsonPropertyName("capexToOperatingCashFlow")]
        public decimal? CapexToOperatingCashFlow { get; set; }

        [JsonPropertyName("capexToRevenue")]
        public decimal? CapexToRevenue { get; set; }

        [JsonPropertyName("capexToDepreciation")]
        public decimal? CapexToDepreciation { get; set; }

        [JsonPropertyName("stockBasedCompensationToRevenue")]
        public decimal? StockBasedCompensationToRevenue { get; set; }

        [JsonPropertyName("grahamNumber")]
        public decimal? GrahamNumber { get; set; }

        [JsonPropertyName("roic")]
        public decimal? Roic { get; set; }

        [JsonPropertyName("returnOnTangibleAssets")]
        public decimal? ReturnOnTangibleAssets { get; set; }

        [JsonPropertyName("grahamNetNet")]
        public decimal? GrahamNetNet { get; set; }

        [JsonPropertyName("workingCapital")]
        public decimal? WorkingCapital { get; set; }

        [JsonPropertyName("tangibleAssetValue")]
        public decimal? TangibleAssetValue { get; set; }

        [JsonPropertyName("netCurrentAssetValue")]
        public decimal? NetCurrentAssetValue { get; set; }

        [JsonPropertyName("investedCapital")]
        public decimal? InvestedCapital { get; set; }

        [JsonPropertyName("averageReceivables")]
        public decimal? AverageReceivables { get; set; }

        [JsonPropertyName("averagePayables")]
        public decimal? AveragePayables { get; set; }

        [JsonPropertyName("averageInventory")]
        public decimal? AverageInventory { get; set; }

        [JsonPropertyName("daysSalesOutstanding")]
        public decimal? DaysSalesOutstanding { get; set; }

        [JsonPropertyName("daysPayablesOutstanding")]
        public decimal? DaysPayablesOutstanding { get; set; }

        [JsonPropertyName("daysOfInventoryOnHand")]
        public decimal? DaysOfInventoryOnHand { get; set; }

        [JsonPropertyName("receivablesTurnover")]
        public decimal? ReceivablesTurnover { get; set; }

        [JsonPropertyName("payablesTurnover")]
        public decimal? PayablesTurnover { get; set; }

        [JsonPropertyName("inventoryTurnover")]
        public decimal? InventoryTurnover { get; set; }

        [JsonPropertyName("roe")]
        public decimal? Roe { get; set; }

        [JsonPropertyName("capexPerShare")]
        public decimal? CapexPerShare { get; set; }
    }
}
