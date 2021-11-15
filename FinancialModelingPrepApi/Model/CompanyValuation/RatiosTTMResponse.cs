using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class RatiosTTMResponse
    {
        [JsonPropertyName("dividendYielTTM")]
        public double? DividendYielTTM { get; set; }

        [JsonPropertyName("dividendYielPercentageTTM")]
        public double? DividendYielPercentageTTM { get; set; }

        [JsonPropertyName("peRatioTTM")]
        public double? PeRatioTTM { get; set; }

        [JsonPropertyName("pegRatioTTM")]
        public double? PegRatioTTM { get; set; }

        [JsonPropertyName("payoutRatioTTM")]
        public double? PayoutRatioTTM { get; set; }

        [JsonPropertyName("currentRatioTTM")]
        public double? CurrentRatioTTM { get; set; }

        [JsonPropertyName("quickRatioTTM")]
        public double? QuickRatioTTM { get; set; }

        [JsonPropertyName("cashRatioTTM")]
        public double? CashRatioTTM { get; set; }

        [JsonPropertyName("daysOfSalesOutstandingTTM")]
        public double? DaysOfSalesOutstandingTTM { get; set; }

        [JsonPropertyName("daysOfInventoryOutstandingTTM")]
        public double? DaysOfInventoryOutstandingTTM { get; set; }

        [JsonPropertyName("operatingCycleTTM")]
        public double? OperatingCycleTTM { get; set; }

        [JsonPropertyName("daysOfPayablesOutstandingTTM")]
        public double? DaysOfPayablesOutstandingTTM { get; set; }

        [JsonPropertyName("cashConversionCycleTTM")]
        public double? CashConversionCycleTTM { get; set; }

        [JsonPropertyName("grossProfitMarginTTM")]
        public double? GrossProfitMarginTTM { get; set; }

        [JsonPropertyName("operatingProfitMarginTTM")]
        public double? OperatingProfitMarginTTM { get; set; }

        [JsonPropertyName("pretaxProfitMarginTTM")]
        public double? PretaxProfitMarginTTM { get; set; }

        [JsonPropertyName("netProfitMarginTTM")]
        public double? NetProfitMarginTTM { get; set; }

        [JsonPropertyName("effectiveTaxRateTTM")]
        public double? EffectiveTaxRateTTM { get; set; }

        [JsonPropertyName("returnOnAssetsTTM")]
        public double? ReturnOnAssetsTTM { get; set; }

        [JsonPropertyName("returnOnEquityTTM")]
        public double? ReturnOnEquityTTM { get; set; }

        [JsonPropertyName("returnOnCapitalEmployedTTM")]
        public double? ReturnOnCapitalEmployedTTM { get; set; }

        [JsonPropertyName("netIncomePerEBTTTM")]
        public double? NetIncomePerEBTTTM { get; set; }

        [JsonPropertyName("ebtPerEbitTTM")]
        public double? EbtPerEbitTTM { get; set; }

        [JsonPropertyName("ebitPerRevenueTTM")]
        public double? EbitPerRevenueTTM { get; set; }

        [JsonPropertyName("debtRatioTTM")]
        public double? DebtRatioTTM { get; set; }

        [JsonPropertyName("debtEquityRatioTTM")]
        public double? DebtEquityRatioTTM { get; set; }

        [JsonPropertyName("longTermDebtToCapitalizationTTM")]
        public double? LongTermDebtToCapitalizationTTM { get; set; }

        [JsonPropertyName("totalDebtToCapitalizationTTM")]
        public double? TotalDebtToCapitalizationTTM { get; set; }

        [JsonPropertyName("interestCoverageTTM")]
        public double? InterestCoverageTTM { get; set; }

        [JsonPropertyName("cashFlowToDebtRatioTTM")]
        public double? CashFlowToDebtRatioTTM { get; set; }

        [JsonPropertyName("companyEquityMultiplierTTM")]
        public double? CompanyEquityMultiplierTTM { get; set; }

        [JsonPropertyName("receivablesTurnoverTTM")]
        public double? ReceivablesTurnoverTTM { get; set; }

        [JsonPropertyName("payablesTurnoverTTM")]
        public double? PayablesTurnoverTTM { get; set; }

        [JsonPropertyName("inventoryTurnoverTTM")]
        public double? InventoryTurnoverTTM { get; set; }

        [JsonPropertyName("fixedAssetTurnoverTTM")]
        public double? FixedAssetTurnoverTTM { get; set; }

        [JsonPropertyName("assetTurnoverTTM")]
        public double? AssetTurnoverTTM { get; set; }

        [JsonPropertyName("operatingCashFlowPerShareTTM")]
        public double? OperatingCashFlowPerShareTTM { get; set; }

        [JsonPropertyName("freeCashFlowPerShareTTM")]
        public double? FreeCashFlowPerShareTTM { get; set; }

        [JsonPropertyName("cashPerShareTTM")]
        public double? CashPerShareTTM { get; set; }

        [JsonPropertyName("operatingCashFlowSalesRatioTTM")]
        public double? OperatingCashFlowSalesRatioTTM { get; set; }

        [JsonPropertyName("freeCashFlowOperatingCashFlowRatioTTM")]
        public double? FreeCashFlowOperatingCashFlowRatioTTM { get; set; }

        [JsonPropertyName("cashFlowCoverageRatiosTTM")]
        public double? CashFlowCoverageRatiosTTM { get; set; }

        [JsonPropertyName("shortTermCoverageRatiosTTM")]
        public double? ShortTermCoverageRatiosTTM { get; set; }

        [JsonPropertyName("capitalExpenditureCoverageRatioTTM")]
        public double? CapitalExpenditureCoverageRatioTTM { get; set; }

        [JsonPropertyName("dividendPaidAndCapexCoverageRatioTTM")]
        public double? DividendPaidAndCapexCoverageRatioTTM { get; set; }

        [JsonPropertyName("priceBookValueRatioTTM")]
        public double? PriceBookValueRatioTTM { get; set; }

        [JsonPropertyName("priceToBookRatioTTM")]
        public double? PriceToBookRatioTTM { get; set; }

        [JsonPropertyName("priceToSalesRatioTTM")]
        public double? PriceToSalesRatioTTM { get; set; }

        [JsonPropertyName("priceEarningsRatioTTM")]
        public double? PriceEarningsRatioTTM { get; set; }

        [JsonPropertyName("priceToFreeCashFlowsRatioTTM")]
        public double? PriceToFreeCashFlowsRatioTTM { get; set; }

        [JsonPropertyName("priceToOperatingCashFlowsRatioTTM")]
        public double? PriceToOperatingCashFlowsRatioTTM { get; set; }

        [JsonPropertyName("priceCashFlowRatioTTM")]
        public double? PriceCashFlowRatioTTM { get; set; }

        [JsonPropertyName("priceEarningsToGrowthRatioTTM")]
        public double? PriceEarningsToGrowthRatioTTM { get; set; }

        [JsonPropertyName("priceSalesRatioTTM")]
        public double? PriceSalesRatioTTM { get; set; }

        [JsonPropertyName("dividendYieldTTM")]
        public double? DividendYieldTTM { get; set; }

        [JsonPropertyName("enterpriseValueMultipleTTM")]
        public double? EnterpriseValueMultipleTTM { get; set; }

        [JsonPropertyName("priceFairValueTTM")]
        public double? PriceFairValueTTM { get; set; }

        [JsonPropertyName("dividendPerShareTTM")]
        public double? DividendPerShareTTM { get; set; }
    }
}
