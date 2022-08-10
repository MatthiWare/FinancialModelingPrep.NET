using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class KeyMetricsTTMResponse
    {
        [JsonPropertyName("revenuePerShareTTM")]
        public decimal? RevenuePerShareTTM { get; set; }

        [JsonPropertyName("netIncomePerShareTTM")]
        public decimal? NetIncomePerShareTTM { get; set; }

        [JsonPropertyName("operatingCashFlowPerShareTTM")]
        public decimal? OperatingCashFlowPerShareTTM { get; set; }

        [JsonPropertyName("freeCashFlowPerShareTTM")]
        public decimal? FreeCashFlowPerShareTTM { get; set; }

        [JsonPropertyName("cashPerShareTTM")]
        public decimal? CashPerShareTTM { get; set; }

        [JsonPropertyName("bookValuePerShareTTM")]
        public decimal? BookValuePerShareTTM { get; set; }

        [JsonPropertyName("tangibleBookValuePerShareTTM")]
        public decimal? TangibleBookValuePerShareTTM { get; set; }

        [JsonPropertyName("shareholdersEquityPerShareTTM")]
        public decimal? ShareholdersEquityPerShareTTM { get; set; }

        [JsonPropertyName("interestDebtPerShareTTM")]
        public decimal? InterestDebtPerShareTTM { get; set; }

        [JsonPropertyName("marketCapTTM")]
        public decimal? MarketCapTTM { get; set; }

        [JsonPropertyName("enterpriseValueTTM")]
        public decimal? EnterpriseValueTTM { get; set; }

        [JsonPropertyName("peRatioTTM")]
        public decimal? PeRatioTTM { get; set; }

        [JsonPropertyName("priceToSalesRatioTTM")]
        public decimal? PriceToSalesRatioTTM { get; set; }

        [JsonPropertyName("pocfratioTTM")]
        public decimal? PocfratioTTM { get; set; }

        [JsonPropertyName("pfcfRatioTTM")]
        public decimal? PfcfRatioTTM { get; set; }

        [JsonPropertyName("pbRatioTTM")]
        public decimal? PbRatioTTM { get; set; }

        [JsonPropertyName("ptbRatioTTM")]
        public decimal? PtbRatioTTM { get; set; }

        [JsonPropertyName("evToSalesTTM")]
        public decimal? EvToSalesTTM { get; set; }

        [JsonPropertyName("enterpriseValueOverEBITDATTM")]
        public decimal? EnterpriseValueOverEBITDATTM { get; set; }

        [JsonPropertyName("evToOperatingCashFlowTTM")]
        public decimal? EvToOperatingCashFlowTTM { get; set; }

        [JsonPropertyName("evToFreeCashFlowTTM")]
        public decimal? EvToFreeCashFlowTTM { get; set; }

        [JsonPropertyName("earningsYieldTTM")]
        public decimal? EarningsYieldTTM { get; set; }

        [JsonPropertyName("freeCashFlowYieldTTM")]
        public decimal? FreeCashFlowYieldTTM { get; set; }

        [JsonPropertyName("debtToEquityTTM")]
        public decimal? DebtToEquityTTM { get; set; }

        [JsonPropertyName("debtToAssetsTTM")]
        public decimal? DebtToAssetsTTM { get; set; }

        [JsonPropertyName("debtToMarketCapTTM")]
        public decimal? DebtToMarketCapTTM { get; set; }

        [JsonPropertyName("netDebtToEBITDATTM")]
        public decimal? NetDebtToEBITDATTM { get; set; }

        [JsonPropertyName("currentRatioTTM")]
        public decimal? CurrentRatioTTM { get; set; }

        [JsonPropertyName("interestCoverageTTM")]
        public decimal? InterestCoverageTTM { get; set; }

        [JsonPropertyName("incomeQualityTTM")]
        public decimal? IncomeQualityTTM { get; set; }

        [JsonPropertyName("dividendYieldTTM")]
        public decimal? DividendYieldTTM { get; set; }

        [JsonPropertyName("dividendYieldPercentageTTM")]
        public decimal? DividendYieldPercentageTTM { get; set; }

        [JsonPropertyName("payoutRatioTTM")]
        public decimal? PayoutRatioTTM { get; set; }

        [JsonPropertyName("salesGeneralAndAdministrativeToRevenueTTM")]
        public decimal? SalesGeneralAndAdministrativeToRevenueTTM { get; set; }

        [JsonPropertyName("researchAndDevelopementToRevenueTTM")]
        public decimal? ResearchAndDevelopementToRevenueTTM { get; set; }

        [JsonPropertyName("intangiblesToTotalAssetsTTM")]
        public decimal? IntangiblesToTotalAssetsTTM { get; set; }

        [JsonPropertyName("capexToOperatingCashFlowTTM")]
        public decimal? CapexToOperatingCashFlowTTM { get; set; }

        [JsonPropertyName("capexToRevenueTTM")]
        public decimal? CapexToRevenueTTM { get; set; }

        [JsonPropertyName("capexToDepreciationTTM")]
        public decimal? CapexToDepreciationTTM { get; set; }

        [JsonPropertyName("stockBasedCompensationToRevenueTTM")]
        public decimal? StockBasedCompensationToRevenueTTM { get; set; }

        [JsonPropertyName("grahamNumberTTM")]
        public decimal? GrahamNumberTTM { get; set; }

        [JsonPropertyName("roicTTM")]
        public decimal? RoicTTM { get; set; }

        [JsonPropertyName("returnOnTangibleAssetsTTM")]
        public decimal? ReturnOnTangibleAssetsTTM { get; set; }

        [JsonPropertyName("grahamNetNetTTM")]
        public decimal? GrahamNetNetTTM { get; set; }

        [JsonPropertyName("workingCapitalTTM")]
        public long? WorkingCapitalTTM { get; set; }

        [JsonPropertyName("tangibleAssetValueTTM")]
        public object TangibleAssetValueTTM { get; set; }

        [JsonPropertyName("netCurrentAssetValueTTM")]
        public decimal? NetCurrentAssetValueTTM { get; set; }

        [JsonPropertyName("investedCapitalTTM")]
        public decimal? InvestedCapitalTTM { get; set; }

        [JsonPropertyName("averageReceivablesTTM")]
        public long? AverageReceivablesTTM { get; set; }

        [JsonPropertyName("averagePayablesTTM")]
        public long? AveragePayablesTTM { get; set; }

        [JsonPropertyName("averageInventoryTTM")]
        public long? AverageInventoryTTM { get; set; }

        [JsonPropertyName("daysSalesOutstandingTTM")]
        public decimal? DaysSalesOutstandingTTM { get; set; }

        [JsonPropertyName("daysPayablesOutstandingTTM")]
        public decimal? DaysPayablesOutstandingTTM { get; set; }

        [JsonPropertyName("daysOfInventoryOnHandTTM")]
        public decimal? DaysOfInventoryOnHandTTM { get; set; }

        [JsonPropertyName("receivablesTurnoverTTM")]
        public decimal? ReceivablesTurnoverTTM { get; set; }

        [JsonPropertyName("payablesTurnoverTTM")]
        public decimal? PayablesTurnoverTTM { get; set; }

        [JsonPropertyName("inventoryTurnoverTTM")]
        public decimal? InventoryTurnoverTTM { get; set; }

        [JsonPropertyName("roeTTM")]
        public decimal? RoeTTM { get; set; }

        [JsonPropertyName("capexPerShareTTM")]
        public decimal? CapexPerShareTTM { get; set; }

        [JsonPropertyName("dividendPerShareTTM")]
        public decimal? DividendPerShareTTM { get; set; }
    }
}
