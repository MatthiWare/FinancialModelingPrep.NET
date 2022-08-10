using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class CashFlowResponse
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

        [JsonPropertyName("netIncome")]
        public decimal NetIncome { get; set; }

        [JsonPropertyName("depreciationAndAmortization")]
        public decimal DepreciationAndAmortization { get; set; }

        [JsonPropertyName("deferredIncomeTax")]
        public decimal DeferredIncomeTax { get; set; }

        [JsonPropertyName("stockBasedCompensation")]
        public decimal StockBasedCompensation { get; set; }

        [JsonPropertyName("changeInWorkingCapital")]
        public decimal ChangeInWorkingCapital { get; set; }

        [JsonPropertyName("accountsReceivables")]
        public decimal AccountsReceivables { get; set; }

        [JsonPropertyName("inventory")]
        public decimal Inventory { get; set; }

        [JsonPropertyName("accountsPayables")]
        public decimal AccountsPayables { get; set; }

        [JsonPropertyName("otherWorkingCapital")]
        public decimal OtherWorkingCapital { get; set; }

        [JsonPropertyName("otherNonCashItems")]
        public decimal OtherNonCashItems { get; set; }

        [JsonPropertyName("netCashProvidedByOperatingActivities")]
        public decimal NetCashProvidedByOperatingActivities { get; set; }

        [JsonPropertyName("investmentsInPropertyPlantAndEquipment")]
        public decimal InvestmentsInPropertyPlantAndEquipment { get; set; }

        [JsonPropertyName("acquisitionsNet")]
        public decimal AcquisitionsNet { get; set; }

        [JsonPropertyName("purchasesOfInvestments")]
        public decimal PurchasesOfInvestments { get; set; }

        [JsonPropertyName("salesMaturitiesOfInvestments")]
        public decimal SalesMaturitiesOfInvestments { get; set; }

        [JsonPropertyName("otherInvestingActivites")]
        public decimal OtherInvestingActivites { get; set; }

        [JsonPropertyName("netCashUsedForInvestingActivites")]
        public decimal NetCashUsedForInvestingActivites { get; set; }

        [JsonPropertyName("debtRepayment")]
        public decimal DebtRepayment { get; set; }

        [JsonPropertyName("commonStockIssued")]
        public decimal CommonStockIssued { get; set; }

        [JsonPropertyName("commonStockRepurchased")]
        public decimal CommonStockRepurchased { get; set; }

        [JsonPropertyName("dividendsPaid")]
        public decimal DividendsPaid { get; set; }

        [JsonPropertyName("otherFinancingActivites")]
        public decimal OtherFinancingActivites { get; set; }

        [JsonPropertyName("netCashUsedProvidedByFinancingActivities")]
        public decimal NetCashUsedProvidedByFinancingActivities { get; set; }

        [JsonPropertyName("effectOfForexChangesOnCash")]
        public decimal EffectOfForexChangesOnCash { get; set; }

        [JsonPropertyName("netChangeInCash")]
        public decimal NetChangeInCash { get; set; }

        [JsonPropertyName("cashAtEndOfPeriod")]
        public decimal CashAtEndOfPeriod { get; set; }

        [JsonPropertyName("cashAtBeginningOfPeriod")]
        public decimal CashAtBeginningOfPeriod { get; set; }

        [JsonPropertyName("operatingCashFlow")]
        public decimal OperatingCashFlow { get; set; }

        [JsonPropertyName("capitalExpenditure")]
        public decimal CapitalExpenditure { get; set; }

        [JsonPropertyName("freeCashFlow")]
        public decimal FreeCashFlow { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
