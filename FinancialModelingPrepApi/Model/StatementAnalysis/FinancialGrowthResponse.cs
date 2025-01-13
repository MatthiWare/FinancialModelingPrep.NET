using System;
using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.StatementAnalysis;

public class FinancialGrowthResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }
    [JsonPropertyName("date")]
    public DateOnly Date { get; set; }
    [JsonPropertyName("calendarYear")]
    public string CalendarYear { get; set; }
    [JsonPropertyName("period")]
    public string Period { get; set; }
    [JsonPropertyName("revenueGrowth")]
    public double? RevenueGrowth { get; set; }
    [JsonPropertyName("grossProfitGrowth")]
    public double? GrossProfitGrowth { get; set; }
    [JsonPropertyName("ebitgrowth")]
    public double? EarningsBeforeInterestAndTaxes { get; set; }
    [JsonPropertyName("operatingIncomeGrowth")]
    public double? OperatingIncomeGrowth { get; set; }
    [JsonPropertyName("netIncomeGrowth")]
    public double? NetIncomeGrowth { get; set; }
    [JsonPropertyName("epsGrowth")]
    public double? EarningsPerShareGrowth { get; set; }
    [JsonPropertyName("epsDilutedGrowth")]
    public double? EarningsPerShareDilutedGrowth { get; set; }
    [JsonPropertyName("weightedAverageSharesGrowth")]
    public double? WeightedAverageSharesGrowth { get; set; }
    [JsonPropertyName("weightedAverageSharesDilutedGrowth")]
    public double? WeightedAverageSharesDilutedGrowth { get; set; }
    [JsonPropertyName("dividendsperShareGrowth")]
    public double? DividendsPerShareGrowth { get; set; }
    [JsonPropertyName("operatingCashFlowGrowth")]
    public double? OperatingCashFlowGrowth { get; set; }
    [JsonPropertyName("freeCashFlowGrowth")]
    public double? FreeCashFlowGrowth { get; set; }
    [JsonPropertyName("tenYRevenueGrowthPerShare")]
    public double? TenYearRevenueGrowthPerShare { get; set; }
    [JsonPropertyName("fiveYRevenueGrowthPerShare")]
    public double? FiveYearRevenueGrowthPerShare { get; set; }
    [JsonPropertyName("threeYOperatingCFGrowthPerShare")]
    public double? ThreeYearOperatingCFGrowthPerShare { get; set; }
    [JsonPropertyName("tenYNetIncomeGrowthPerShare")]
    public double? TenYearNetIncomeGrowthPerShare { get; set; }
    [JsonPropertyName("fiveYNetIncomeGrowthPerShare")]
    public double? FiveYearNetIncomeGrowthPerShare { get; set; }
    [JsonPropertyName("threeYNetIncomeGrowthPerShare")]
    public double? ThreeYearNetIncomeGrowthPerShare { get; set; }
    [JsonPropertyName("tenYShareholdersEquityGrowthPerShare")]
    public double? TenYearShareholdersEquityGrowthPerShare { get; set; }
    [JsonPropertyName("fiveYShareholdersEquityGrowthPerShare")]
    public double? FiveYearShareholdersEquityGrowthPerShare { get; set; }
    [JsonPropertyName("threeYShareholdersEquityGrowthPerShare")]
    public double? ThreeYearShareholdersEquityGrowthPerShare { get; set; }
    [JsonPropertyName("tenYDividendperShareGrowthPerShare")]
    public double? TenYearDividendPerShareGrowthPerShare { get; set; }
    [JsonPropertyName("fiveYDividendperShareGrowthPerShare")]
    public double? FiveYearDividendPerShareGrowthPerShare { get; set; }
    [JsonPropertyName("threeYDividendperShareGrowthPerShare")]
    public double? ThreeYearDividendPerShareGrowthPerShare { get; set; }
    [JsonPropertyName("receivablesGrowth")]
    public double? ReceivablesGrowth { get; set; }
    [JsonPropertyName("inventoryGrowth")]
    public double? InventoryGrowth { get; set; }
    [JsonPropertyName("assetGrowth")]
    public double? AssetGrowth { get; set; }
    [JsonPropertyName("bookValueperShareGrowth")]
    public double? BookValuePerShareGrowth { get; set; }
    [JsonPropertyName("debtGrowth")]
    public double? DebtGrowth { get; set; }
    [JsonPropertyName("rdexpenseGrowth")]
    public double? ResearchAndDevelopmentExpenseGrowth { get; set; }
    [JsonPropertyName("sgaexpensesGrowth")]
    public double? SellingGeneralAdminExpensesGrowth { get; set; }
}