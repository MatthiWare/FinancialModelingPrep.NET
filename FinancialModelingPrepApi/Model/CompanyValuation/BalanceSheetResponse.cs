using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class BalanceSheetResponse
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; set; }

        [JsonPropertyName("cik")]
        public string Cik { get; set; }

        [JsonPropertyName("fillingDate")]
        public string FillingDate { get; set; }

        [JsonPropertyName("acceptedDate")]
        public string AcceptedDate { get; set; }

        [JsonPropertyName("calendarYear")]
        public string CalendarYear { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("cashAndCashEquivalents")]
        public decimal CashAndCashEquivalents { get; set; }

        [JsonPropertyName("shortTermInvestments")]
        public decimal ShortTermInvestments { get; set; }

        [JsonPropertyName("cashAndShortTermInvestments")]
        public decimal CashAndShortTermInvestments { get; set; }

        [JsonPropertyName("netReceivables")]
        public decimal NetReceivables { get; set; }

        [JsonPropertyName("inventory")]
        public decimal Inventory { get; set; }

        [JsonPropertyName("otherCurrentAssets")]
        public decimal OtherCurrentAssets { get; set; }

        [JsonPropertyName("totalCurrentAssets")]
        public decimal TotalCurrentAssets { get; set; }

        [JsonPropertyName("propertyPlantEquipmentNet")]
        public decimal PropertyPlantEquipmentNet { get; set; }

        [JsonPropertyName("goodwill")]
        public decimal Goodwill { get; set; }

        [JsonPropertyName("intangibleAssets")]
        public decimal IntangibleAssets { get; set; }

        [JsonPropertyName("goodwillAndIntangibleAssets")]
        public decimal GoodwillAndIntangibleAssets { get; set; }

        [JsonPropertyName("longTermInvestments")]
        public decimal LongTermInvestments { get; set; }

        [JsonPropertyName("taxAssets")]
        public decimal TaxAssets { get; set; }

        [JsonPropertyName("otherNonCurrentAssets")]
        public decimal OtherNonCurrentAssets { get; set; }

        [JsonPropertyName("totalNonCurrentAssets")]
        public decimal TotalNonCurrentAssets { get; set; }

        [JsonPropertyName("otherAssets")]
        public decimal OtherAssets { get; set; }

        [JsonPropertyName("totalAssets")]
        public decimal TotalAssets { get; set; }

        [JsonPropertyName("accountPayables")]
        public decimal AccountPayables { get; set; }

        [JsonPropertyName("shortTermDebt")]
        public decimal ShortTermDebt { get; set; }

        [JsonPropertyName("taxPayables")]
        public decimal TaxPayables { get; set; }

        [JsonPropertyName("deferredRevenue")]
        public decimal DeferredRevenue { get; set; }

        [JsonPropertyName("otherCurrentLiabilities")]
        public decimal OtherCurrentLiabilities { get; set; }

        [JsonPropertyName("totalCurrentLiabilities")]
        public decimal TotalCurrentLiabilities { get; set; }

        [JsonPropertyName("longTermDebt")]
        public decimal LongTermDebt { get; set; }

        [JsonPropertyName("deferredRevenueNonCurrent")]
        public decimal DeferredRevenueNonCurrent { get; set; }

        [JsonPropertyName("deferredTaxLiabilitiesNonCurrent")]
        public decimal DeferredTaxLiabilitiesNonCurrent { get; set; }

        [JsonPropertyName("otherNonCurrentLiabilities")]
        public decimal OtherNonCurrentLiabilities { get; set; }

        [JsonPropertyName("totalNonCurrentLiabilities")]
        public decimal TotalNonCurrentLiabilities { get; set; }

        [JsonPropertyName("otherLiabilities")]
        public decimal OtherLiabilities { get; set; }

        [JsonPropertyName("capitalLeaseObligations")]
        public decimal CapitalLeaseObligations { get; set; }

        [JsonPropertyName("totalLiabilities")]
        public decimal TotalLiabilities { get; set; }

        [JsonPropertyName("preferredStock")]
        public decimal PreferredStock { get; set; }

        [JsonPropertyName("commonStock")]
        public decimal CommonStock { get; set; }

        [JsonPropertyName("retainedEarnings")]
        public decimal RetainedEarnings { get; set; }

        [JsonPropertyName("accumulatedOtherComprehensiveIncomeLoss")]
        public decimal AccumulatedOtherComprehensiveIncomeLoss { get; set; }

        [JsonPropertyName("othertotalStockholdersEquity")]
        public decimal OthertotalStockholdersEquity { get; set; }

        [JsonPropertyName("totalStockholdersEquity")]
        public decimal TotalStockholdersEquity { get; set; }

        [JsonPropertyName("totalLiabilitiesAndStockholdersEquity")]
        public decimal TotalLiabilitiesAndStockholdersEquity { get; set; }

        [JsonPropertyName("minorityInterest")]
        public decimal MinorityInterest { get; set; }

        [JsonPropertyName("totalEquity")]
        public decimal TotalEquity { get; set; }

        [JsonPropertyName("totalLiabilitiesAndTotalEquity")]
        public decimal TotalLiabilitiesAndTotalEquity { get; set; }

        [JsonPropertyName("totalInvestments")]
        public decimal TotalInvestments { get; set; }

        [JsonPropertyName("totalDebt")]
        public decimal TotalDebt { get; set; }

        [JsonPropertyName("netDebt")]
        public decimal NetDebt { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
