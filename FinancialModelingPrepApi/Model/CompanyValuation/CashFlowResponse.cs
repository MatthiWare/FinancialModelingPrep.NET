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

        [JsonPropertyName("fillingDate")]
        public string FillingDate { get; set; }

        [JsonPropertyName("acceptedDate")]
        public string AcceptedDate { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("netIncome")]
        public double NetIncome { get; set; }

        [JsonPropertyName("depreciationAndAmortization")]
        public double DepreciationAndAmortization { get; set; }

        [JsonPropertyName("deferredIncomeTax")]
        public double DeferredIncomeTax { get; set; }

        [JsonPropertyName("stockBasedCompensation")]
        public double StockBasedCompensation { get; set; }

        [JsonPropertyName("changeInWorkingCapital")]
        public double ChangeInWorkingCapital { get; set; }

        [JsonPropertyName("accountsReceivables")]
        public double AccountsReceivables { get; set; }

        [JsonPropertyName("inventory")]
        public double Inventory { get; set; }

        [JsonPropertyName("accountsPayables")]
        public double AccountsPayables { get; set; }

        [JsonPropertyName("otherWorkingCapital")]
        public double OtherWorkingCapital { get; set; }

        [JsonPropertyName("otherNonCashItems")]
        public double OtherNonCashItems { get; set; }

        [JsonPropertyName("netCashProvidedByOperatingActivities")]
        public double NetCashProvidedByOperatingActivities { get; set; }

        [JsonPropertyName("investmentsInPropertyPlantAndEquipment")]
        public double InvestmentsInPropertyPlantAndEquipment { get; set; }

        [JsonPropertyName("acquisitionsNet")]
        public double AcquisitionsNet { get; set; }

        [JsonPropertyName("purchasesOfInvestments")]
        public double PurchasesOfInvestments { get; set; }

        [JsonPropertyName("salesMaturitiesOfInvestments")]
        public double SalesMaturitiesOfInvestments { get; set; }

        [JsonPropertyName("otherInvestingActivites")]
        public double OtherInvestingActivites { get; set; }

        [JsonPropertyName("netCashUsedForInvestingActivites")]
        public double NetCashUsedForInvestingActivites { get; set; }

        [JsonPropertyName("debtRepayment")]
        public double DebtRepayment { get; set; }

        [JsonPropertyName("commonStockIssued")]
        public double CommonStockIssued { get; set; }

        [JsonPropertyName("commonStockRepurchased")]
        public double CommonStockRepurchased { get; set; }

        [JsonPropertyName("dividendsPaid")]
        public double DividendsPaid { get; set; }

        [JsonPropertyName("otherFinancingActivites")]
        public double OtherFinancingActivites { get; set; }

        [JsonPropertyName("netCashUsedProvidedByFinancingActivities")]
        public double NetCashUsedProvidedByFinancingActivities { get; set; }

        [JsonPropertyName("effectOfForexChangesOnCash")]
        public double EffectOfForexChangesOnCash { get; set; }

        [JsonPropertyName("netChangeInCash")]
        public double NetChangeInCash { get; set; }

        [JsonPropertyName("cashAtEndOfPeriod")]
        public double CashAtEndOfPeriod { get; set; }

        [JsonPropertyName("cashAtBeginningOfPeriod")]
        public double CashAtBeginningOfPeriod { get; set; }

        [JsonPropertyName("operatingCashFlow")]
        public double OperatingCashFlow { get; set; }

        [JsonPropertyName("capitalExpenditure")]
        public double CapitalExpenditure { get; set; }

        [JsonPropertyName("freeCashFlow")]
        public double FreeCashFlow { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
