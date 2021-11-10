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

        [JsonPropertyName("fillingDate")]
        public string FillingDate { get; set; }

        [JsonPropertyName("acceptedDate")]
        public string AcceptedDate { get; set; }

        [JsonPropertyName("calendarYear")]
        public string CalendarYear { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("cashAndCashEquivalents")]
        public double CashAndCashEquivalents { get; set; }

        [JsonPropertyName("shortTermInvestments")]
        public double ShortTermInvestments { get; set; }

        [JsonPropertyName("cashAndShortTermInvestments")]
        public double CashAndShortTermInvestments { get; set; }

        [JsonPropertyName("netReceivables")]
        public double NetReceivables { get; set; }

        [JsonPropertyName("inventory")]
        public double Inventory { get; set; }

        [JsonPropertyName("otherCurrentAssets")]
        public double OtherCurrentAssets { get; set; }

        [JsonPropertyName("totalCurrentAssets")]
        public double TotalCurrentAssets { get; set; }

        [JsonPropertyName("propertyPlantEquipmentNet")]
        public double PropertyPlantEquipmentNet { get; set; }

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
        public double OtherNonCurrentAssets { get; set; }

        [JsonPropertyName("totalNonCurrentAssets")]
        public double TotalNonCurrentAssets { get; set; }

        [JsonPropertyName("otherAssets")]
        public double OtherAssets { get; set; }

        [JsonPropertyName("totalAssets")]
        public double TotalAssets { get; set; }

        [JsonPropertyName("accountPayables")]
        public double AccountPayables { get; set; }

        [JsonPropertyName("shortTermDebt")]
        public double ShortTermDebt { get; set; }

        [JsonPropertyName("taxPayables")]
        public double TaxPayables { get; set; }

        [JsonPropertyName("deferredRevenue")]
        public double DeferredRevenue { get; set; }

        [JsonPropertyName("otherCurrentLiabilities")]
        public double OtherCurrentLiabilities { get; set; }

        [JsonPropertyName("totalCurrentLiabilities")]
        public double TotalCurrentLiabilities { get; set; }

        [JsonPropertyName("longTermDebt")]
        public double LongTermDebt { get; set; }

        [JsonPropertyName("deferredRevenueNonCurrent")]
        public double DeferredRevenueNonCurrent { get; set; }

        [JsonPropertyName("deferredTaxLiabilitiesNonCurrent")]
        public double DeferredTaxLiabilitiesNonCurrent { get; set; }

        [JsonPropertyName("otherNonCurrentLiabilities")]
        public double OtherNonCurrentLiabilities { get; set; }

        [JsonPropertyName("totalNonCurrentLiabilities")]
        public double TotalNonCurrentLiabilities { get; set; }

        [JsonPropertyName("otherLiabilities")]
        public double OtherLiabilities { get; set; }

        [JsonPropertyName("totalLiabilities")]
        public double TotalLiabilities { get; set; }

        [JsonPropertyName("commonStock")]
        public double CommonStock { get; set; }

        [JsonPropertyName("retainedEarnings")]
        public double RetainedEarnings { get; set; }

        [JsonPropertyName("accumulatedOtherComprehensiveIncomeLoss")]
        public double AccumulatedOtherComprehensiveIncomeLoss { get; set; }

        [JsonPropertyName("othertotalStockholdersEquity")]
        public double OthertotalStockholdersEquity { get; set; }

        [JsonPropertyName("totalStockholdersEquity")]
        public double TotalStockholdersEquity { get; set; }

        [JsonPropertyName("totalLiabilitiesAndStockholdersEquity")]
        public double TotalLiabilitiesAndStockholdersEquity { get; set; }

        [JsonPropertyName("minorityInteret")]
        public double MinorityInterest { get; set; }

        [JsonPropertyName("totalEquity")]
        public double TotalEquity { get; set; }

        [JsonPropertyName("totalLiabilitiesAndTotalEquity")]
        public double TotalLiabilitiesAndTotalEquity { get; set; }

        [JsonPropertyName("totalInvestments")]
        public double TotalInvestments { get; set; }

        [JsonPropertyName("totalDebt")]
        public double TotalDebt { get; set; }

        [JsonPropertyName("netDebt")]
        public double NetDebt { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
