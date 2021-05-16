using System.Text.Json.Serialization;

namespace FinancialModelingPrepApi.Model.CompanyValuation
{
    public class BalanceSheetResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; set; }

        [JsonPropertyName("fillingDate")]
        public string FillingDate { get; set; }

        [JsonPropertyName("acceptedDate")]
        public string AcceptedDate { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("cashAndCashEquivalents")]
        public long CashAndCashEquivalents { get; set; }

        [JsonPropertyName("shortTermInvestments")]
        public long ShortTermInvestments { get; set; }

        [JsonPropertyName("cashAndShortTermInvestments")]
        public long CashAndShortTermInvestments { get; set; }

        [JsonPropertyName("netReceivables")]
        public long NetReceivables { get; set; }

        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        [JsonPropertyName("otherCurrentAssets")]
        public long OtherCurrentAssets { get; set; }

        [JsonPropertyName("totalCurrentAssets")]
        public long TotalCurrentAssets { get; set; }

        [JsonPropertyName("propertyPlantEquipmentNet")]
        public long PropertyPlantEquipmentNet { get; set; }

        [JsonPropertyName("goodwill")]
        public double Goodwill { get; set; }

        [JsonPropertyName("intangibleAssets")]
        public double IntangibleAssets { get; set; }

        [JsonPropertyName("goodwillAndIntangibleAssets")]
        public double GoodwillAndIntangibleAssets { get; set; }

        [JsonPropertyName("longTermInvestments")]
        public double LongTermInvestments { get; set; }

        [JsonPropertyName("taxAssets")]
        public double TaxAssets { get; set; }

        [JsonPropertyName("otherNonCurrentAssets")]
        public long OtherNonCurrentAssets { get; set; }

        [JsonPropertyName("totalNonCurrentAssets")]
        public long TotalNonCurrentAssets { get; set; }

        [JsonPropertyName("otherAssets")]
        public double OtherAssets { get; set; }

        [JsonPropertyName("totalAssets")]
        public long TotalAssets { get; set; }

        [JsonPropertyName("accountPayables")]
        public long AccountPayables { get; set; }

        [JsonPropertyName("shortTermDebt")]
        public double ShortTermDebt { get; set; }

        [JsonPropertyName("taxPayables")]
        public double TaxPayables { get; set; }

        [JsonPropertyName("deferredRevenue")]
        public double DeferredRevenue { get; set; }

        [JsonPropertyName("otherCurrentLiabilities")]
        public double OtherCurrentLiabilities { get; set; }

        [JsonPropertyName("totalCurrentLiabilities")]
        public long TotalCurrentLiabilities { get; set; }

        [JsonPropertyName("longTermDebt")]
        public long LongTermDebt { get; set; }

        [JsonPropertyName("deferredRevenueNonCurrent")]
        public double DeferredRevenueNonCurrent { get; set; }

        [JsonPropertyName("deferredTaxLiabilitiesNonCurrent")]
        public double DeferredTaxLiabilitiesNonCurrent { get; set; }

        [JsonPropertyName("otherNonCurrentLiabilities")]
        public long OtherNonCurrentLiabilities { get; set; }

        [JsonPropertyName("totalNonCurrentLiabilities")]
        public long TotalNonCurrentLiabilities { get; set; }

        [JsonPropertyName("otherLiabilities")]
        public double OtherLiabilities { get; set; }

        [JsonPropertyName("totalLiabilities")]
        public long TotalLiabilities { get; set; }

        [JsonPropertyName("commonStock")]
        public long CommonStock { get; set; }

        [JsonPropertyName("retainedEarnings")]
        public long RetainedEarnings { get; set; }

        [JsonPropertyName("accumulatedOtherComprehensiveIncomeLoss")]
        public long AccumulatedOtherComprehensiveIncomeLoss { get; set; }

        [JsonPropertyName("othertotalStockholdersEquity")]
        public double OthertotalStockholdersEquity { get; set; }

        [JsonPropertyName("totalStockholdersEquity")]
        public long TotalStockholdersEquity { get; set; }

        [JsonPropertyName("totalLiabilitiesAndStockholdersEquity")]
        public long TotalLiabilitiesAndStockholdersEquity { get; set; }

        [JsonPropertyName("totalInvestments")]
        public double TotalInvestments { get; set; }

        [JsonPropertyName("totalDebt")]
        public long TotalDebt { get; set; }

        [JsonPropertyName("netDebt")]
        public long NetDebt { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
