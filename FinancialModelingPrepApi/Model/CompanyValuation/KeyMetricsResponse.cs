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
        public double? RevenuePerShare { get; set; }

        [JsonPropertyName("netIncomePerShare")]
        public double? NetIncomePerShare { get; set; }

        [JsonPropertyName("operatingCashFlowPerShare")]
        public double? OperatingCashFlowPerShare { get; set; }

        [JsonPropertyName("freeCashFlowPerShare")]
        public double? FreeCashFlowPerShare { get; set; }

        [JsonPropertyName("cashPerShare")]
        public double? CashPerShare { get; set; }

        [JsonPropertyName("bookValuePerShare")]
        public double? BookValuePerShare { get; set; }

        [JsonPropertyName("tangibleBookValuePerShare")]
        public double? TangibleBookValuePerShare { get; set; }

        [JsonPropertyName("shareholdersEquityPerShare")]
        public double? ShareholdersEquityPerShare { get; set; }

        [JsonPropertyName("interestDebtPerShare")]
        public double? InterestDebtPerShare { get; set; }

        [JsonPropertyName("marketCap")]
        public double? MarketCap { get; set; }

        [JsonPropertyName("enterpriseValue")]
        public double? EnterpriseValue { get; set; }

        [JsonPropertyName("peRatio")]
        public double? PeRatio { get; set; }

        [JsonPropertyName("priceToSalesRatio")]
        public double? PriceToSalesRatio { get; set; }

        [JsonPropertyName("pocfratio")]
        public double? Pocfratio { get; set; }

        [JsonPropertyName("pfcfRatio")]
        public double? PfcfRatio { get; set; }

        [JsonPropertyName("pbRatio")]
        public double? PbRatio { get; set; }

        [JsonPropertyName("ptbRatio")]
        public double? PtbRatio { get; set; }

        [JsonPropertyName("evToSales")]
        public double? EvToSales { get; set; }

        [JsonPropertyName("enterpriseValueOverEBITDA")]
        public double? EnterpriseValueOverEBITDA { get; set; }

        [JsonPropertyName("evToOperatingCashFlow")]
        public double? EvToOperatingCashFlow { get; set; }

        [JsonPropertyName("evToFreeCashFlow")]
        public double? EvToFreeCashFlow { get; set; }

        [JsonPropertyName("earningsYield")]
        public double? EarningsYield { get; set; }

        [JsonPropertyName("freeCashFlowYield")]
        public double? FreeCashFlowYield { get; set; }

        [JsonPropertyName("debtToEquity")]
        public double? DebtToEquity { get; set; }

        [JsonPropertyName("debtToAssets")]
        public double? DebtToAssets { get; set; }

        [JsonPropertyName("netDebtToEBITDA")]
        public double? NetDebtToEBITDA { get; set; }

        [JsonPropertyName("currentRatio")]
        public double? CurrentRatio { get; set; }

        [JsonPropertyName("interestCoverage")]
        public double? InterestCoverage { get; set; }

        [JsonPropertyName("incomeQuality")]
        public double? IncomeQuality { get; set; }

        [JsonPropertyName("dividendYield")]
        public double? DividendYield { get; set; }

        [JsonPropertyName("payoutRatio")]
        public double? PayoutRatio { get; set; }

        [JsonPropertyName("salesGeneralAndAdministrativeToRevenue")]
        public double? SalesGeneralAndAdministrativeToRevenue { get; set; }

        [JsonPropertyName("researchAndDdevelopementToRevenue")]
        public double? ResearchAndDdevelopementToRevenue { get; set; }

        [JsonPropertyName("intangiblesToTotalAssets")]
        public double? IntangiblesToTotalAssets { get; set; }

        [JsonPropertyName("capexToOperatingCashFlow")]
        public double? CapexToOperatingCashFlow { get; set; }

        [JsonPropertyName("capexToRevenue")]
        public double? CapexToRevenue { get; set; }

        [JsonPropertyName("capexToDepreciation")]
        public double? CapexToDepreciation { get; set; }

        [JsonPropertyName("stockBasedCompensationToRevenue")]
        public double? StockBasedCompensationToRevenue { get; set; }

        [JsonPropertyName("grahamNumber")]
        public double? GrahamNumber { get; set; }

        [JsonPropertyName("roic")]
        public double? Roic { get; set; }

        [JsonPropertyName("returnOnTangibleAssets")]
        public double? ReturnOnTangibleAssets { get; set; }

        [JsonPropertyName("grahamNetNet")]
        public double? GrahamNetNet { get; set; }

        [JsonPropertyName("workingCapital")]
        public double? WorkingCapital { get; set; }

        [JsonPropertyName("tangibleAssetValue")]
        public double? TangibleAssetValue { get; set; }

        [JsonPropertyName("netCurrentAssetValue")]
        public double? NetCurrentAssetValue { get; set; }

        [JsonPropertyName("investedCapital")]
        public double? InvestedCapital { get; set; }

        [JsonPropertyName("averageReceivables")]
        public double? AverageReceivables { get; set; }

        [JsonPropertyName("averagePayables")]
        public double? AveragePayables { get; set; }

        [JsonPropertyName("averageInventory")]
        public double? AverageInventory { get; set; }

        [JsonPropertyName("daysSalesOutstanding")]
        public double? DaysSalesOutstanding { get; set; }

        [JsonPropertyName("daysPayablesOutstanding")]
        public double? DaysPayablesOutstanding { get; set; }

        [JsonPropertyName("daysOfInventoryOnHand")]
        public double? DaysOfInventoryOnHand { get; set; }

        [JsonPropertyName("receivablesTurnover")]
        public double? ReceivablesTurnover { get; set; }

        [JsonPropertyName("payablesTurnover")]
        public double? PayablesTurnover { get; set; }

        [JsonPropertyName("inventoryTurnover")]
        public double? InventoryTurnover { get; set; }

        [JsonPropertyName("roe")]
        public double? Roe { get; set; }

        [JsonPropertyName("capexPerShare")]
        public double? CapexPerShare { get; set; }
    }
}
