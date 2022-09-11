using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class RatiosTTMResponse
    {
        [JsonPropertyName("dividendYielTTM")]
        public decimal? DividendYielTTM { get; set; }

        [JsonPropertyName("dividendYielPercentageTTM")]
        public decimal? DividendYielPercentageTTM { get; set; }

        [JsonPropertyName("peRatioTTM")]
        public decimal? PeRatioTTM { get; set; }

        [JsonPropertyName("pegRatioTTM")]
        public decimal? PegRatioTTM { get; set; }

        [JsonPropertyName("payoutRatioTTM")]
        public decimal? PayoutRatioTTM { get; set; }

        [JsonPropertyName("currentRatioTTM")]
        public decimal? CurrentRatioTTM { get; set; }

        [JsonPropertyName("quickRatioTTM")]
        public decimal? QuickRatioTTM { get; set; }

        [JsonPropertyName("cashRatioTTM")]
        public decimal? CashRatioTTM { get; set; }

        [JsonPropertyName("daysOfSalesOutstandingTTM")]
        public decimal? DaysOfSalesOutstandingTTM { get; set; }

        [JsonPropertyName("daysOfInventoryOutstandingTTM")]
        public decimal? DaysOfInventoryOutstandingTTM { get; set; }

        [JsonPropertyName("operatingCycleTTM")]
        public decimal? OperatingCycleTTM { get; set; }

        [JsonPropertyName("daysOfPayablesOutstandingTTM")]
        public decimal? DaysOfPayablesOutstandingTTM { get; set; }

        [JsonPropertyName("cashConversionCycleTTM")]
        public decimal? CashConversionCycleTTM { get; set; }

        [JsonPropertyName("grossProfitMarginTTM")]
        public decimal? GrossProfitMarginTTM { get; set; }

        [JsonPropertyName("operatingProfitMarginTTM")]
        public decimal? OperatingProfitMarginTTM { get; set; }

        [JsonPropertyName("pretaxProfitMarginTTM")]
        public decimal? PretaxProfitMarginTTM { get; set; }

        [JsonPropertyName("netProfitMarginTTM")]
        public decimal? NetProfitMarginTTM { get; set; }

        [JsonPropertyName("effectiveTaxRateTTM")]
        public decimal? EffectiveTaxRateTTM { get; set; }

        [JsonPropertyName("returnOnAssetsTTM")]
        public decimal? ReturnOnAssetsTTM { get; set; }

        [JsonPropertyName("returnOnEquityTTM")]
        public decimal? ReturnOnEquityTTM { get; set; }

        [JsonPropertyName("returnOnCapitalEmployedTTM")]
        public decimal? ReturnOnCapitalEmployedTTM { get; set; }

        [JsonPropertyName("netIncomePerEBTTTM")]
        public decimal? NetIncomePerEBTTTM { get; set; }

        [JsonPropertyName("ebtPerEbitTTM")]
        public decimal? EbtPerEbitTTM { get; set; }

        [JsonPropertyName("ebitPerRevenueTTM")]
        public decimal? EbitPerRevenueTTM { get; set; }

        [JsonPropertyName("debtRatioTTM")]
        public decimal? DebtRatioTTM { get; set; }

        [JsonPropertyName("debtEquityRatioTTM")]
        public decimal? DebtEquityRatioTTM { get; set; }

        [JsonPropertyName("longTermDebtToCapitalizationTTM")]
        public decimal? LongTermDebtToCapitalizationTTM { get; set; }

        [JsonPropertyName("totalDebtToCapitalizationTTM")]
        public decimal? TotalDebtToCapitalizationTTM { get; set; }

        [JsonPropertyName("interestCoverageTTM")]
        public decimal? InterestCoverageTTM { get; set; }

        [JsonPropertyName("cashFlowToDebtRatioTTM")]
        public decimal? CashFlowToDebtRatioTTM { get; set; }

        [JsonPropertyName("companyEquityMultiplierTTM")]
        public decimal? CompanyEquityMultiplierTTM { get; set; }

        [JsonPropertyName("receivablesTurnoverTTM")]
        public decimal? ReceivablesTurnoverTTM { get; set; }

        [JsonPropertyName("payablesTurnoverTTM")]
        public decimal? PayablesTurnoverTTM { get; set; }

        [JsonPropertyName("inventoryTurnoverTTM")]
        public decimal? InventoryTurnoverTTM { get; set; }

        [JsonPropertyName("fixedAssetTurnoverTTM")]
        public decimal? FixedAssetTurnoverTTM { get; set; }

        [JsonPropertyName("assetTurnoverTTM")]
        public decimal? AssetTurnoverTTM { get; set; }

        [JsonPropertyName("operatingCashFlowPerShareTTM")]
        public decimal? OperatingCashFlowPerShareTTM { get; set; }

        [JsonPropertyName("freeCashFlowPerShareTTM")]
        public decimal? FreeCashFlowPerShareTTM { get; set; }

        [JsonPropertyName("cashPerShareTTM")]
        public decimal? CashPerShareTTM { get; set; }

        [JsonPropertyName("operatingCashFlowSalesRatioTTM")]
        public decimal? OperatingCashFlowSalesRatioTTM { get; set; }

        [JsonPropertyName("freeCashFlowOperatingCashFlowRatioTTM")]
        public decimal? FreeCashFlowOperatingCashFlowRatioTTM { get; set; }

        [JsonPropertyName("cashFlowCoverageRatiosTTM")]
        public decimal? CashFlowCoverageRatiosTTM { get; set; }

        [JsonPropertyName("shortTermCoverageRatiosTTM")]
        public decimal? ShortTermCoverageRatiosTTM { get; set; }

        [JsonPropertyName("capitalExpenditureCoverageRatioTTM")]
        public decimal? CapitalExpenditureCoverageRatioTTM { get; set; }

        [JsonPropertyName("dividendPaidAndCapexCoverageRatioTTM")]
        public decimal? DividendPaidAndCapexCoverageRatioTTM { get; set; }

        [JsonPropertyName("priceBookValueRatioTTM")]
        public decimal? PriceBookValueRatioTTM { get; set; }

        [JsonPropertyName("priceToBookRatioTTM")]
        public decimal? PriceToBookRatioTTM { get; set; }

        [JsonPropertyName("priceToSalesRatioTTM")]
        public decimal? PriceToSalesRatioTTM { get; set; }

        [JsonPropertyName("priceEarningsRatioTTM")]
        public decimal? PriceEarningsRatioTTM { get; set; }

        [JsonPropertyName("priceToFreeCashFlowsRatioTTM")]
        public decimal? PriceToFreeCashFlowsRatioTTM { get; set; }

        [JsonPropertyName("priceToOperatingCashFlowsRatioTTM")]
        public decimal? PriceToOperatingCashFlowsRatioTTM { get; set; }

        [JsonPropertyName("priceCashFlowRatioTTM")]
        public decimal? PriceCashFlowRatioTTM { get; set; }

        [JsonPropertyName("priceEarningsToGrowthRatioTTM")]
        public decimal? PriceEarningsToGrowthRatioTTM { get; set; }

        [JsonPropertyName("priceSalesRatioTTM")]
        public decimal? PriceSalesRatioTTM { get; set; }

        [JsonPropertyName("dividendYieldTTM")]
        public decimal? DividendYieldTTM { get; set; }

        [JsonPropertyName("enterpriseValueMultipleTTM")]
        public decimal? EnterpriseValueMultipleTTM { get; set; }

        [JsonPropertyName("priceFairValueTTM")]
        public decimal? PriceFairValueTTM { get; set; }

        [JsonPropertyName("dividendPerShareTTM")]
        public decimal? DividendPerShareTTM { get; set; }
    }
}
