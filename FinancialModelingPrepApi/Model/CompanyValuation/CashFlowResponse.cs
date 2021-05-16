using System.Text.Json.Serialization;

namespace FinancialModelingPrepApi.Model.CompanyValuation
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
        public long NetIncome { get; set; }

        [JsonPropertyName("depreciationAndAmortization")]
        public long DepreciationAndAmortization { get; set; }

        [JsonPropertyName("deferredIncomeTax")]
        public long DeferredIncomeTax { get; set; }

        [JsonPropertyName("stockBasedCompensation")]
        public long StockBasedCompensation { get; set; }

        [JsonPropertyName("changeInWorkingCapital")]
        public long ChangeInWorkingCapital { get; set; }

        [JsonPropertyName("accountsReceivables")]
        public double AccountsReceivables { get; set; }

        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        [JsonPropertyName("accountsPayables")]
        public long AccountsPayables { get; set; }

        [JsonPropertyName("otherWorkingCapital")]
        public long OtherWorkingCapital { get; set; }

        [JsonPropertyName("otherNonCashItems")]
        public long OtherNonCashItems { get; set; }

        [JsonPropertyName("netCashProvidedByOperatingActivities")]
        public long NetCashProvidedByOperatingActivities { get; set; }

        [JsonPropertyName("investmentsInPropertyPlantAndEquipment")]
        public long InvestmentsInPropertyPlantAndEquipment { get; set; }

        [JsonPropertyName("acquisitionsNet")]
        public double AcquisitionsNet { get; set; }

        [JsonPropertyName("purchasesOfInvestments")]
        public double PurchasesOfInvestments { get; set; }

        [JsonPropertyName("salesMaturitiesOfInvestments")]
        public long SalesMaturitiesOfInvestments { get; set; }

        [JsonPropertyName("otherInvestingActivites")]
        public double OtherInvestingActivites { get; set; }

        [JsonPropertyName("netCashUsedForInvestingActivites")]
        public double NetCashUsedForInvestingActivites { get; set; }

        [JsonPropertyName("debtRepayment")]
        public double DebtRepayment { get; set; }

        [JsonPropertyName("commonStockIssued")]
        public double CommonStockIssued { get; set; }

        [JsonPropertyName("commonStockRepurchased")]
        public long CommonStockRepurchased { get; set; }

        [JsonPropertyName("dividendsPaid")]
        public double DividendsPaid { get; set; }

        [JsonPropertyName("otherFinancingActivites")]
        public double OtherFinancingActivites { get; set; }

        [JsonPropertyName("netCashUsedProvidedByFinancingActivities")]
        public long NetCashUsedProvidedByFinancingActivities { get; set; }

        [JsonPropertyName("effectOfForexChangesOnCash")]
        public double EffectOfForexChangesOnCash { get; set; }

        [JsonPropertyName("netChangeInCash")]
        public long NetChangeInCash { get; set; }

        [JsonPropertyName("cashAtEndOfPeriod")]
        public long CashAtEndOfPeriod { get; set; }

        [JsonPropertyName("cashAtBeginningOfPeriod")]
        public long CashAtBeginningOfPeriod { get; set; }

        [JsonPropertyName("operatingCashFlow")]
        public long OperatingCashFlow { get; set; }

        [JsonPropertyName("capitalExpenditure")]
        public long CapitalExpenditure { get; set; }

        [JsonPropertyName("freeCashFlow")]
        public long FreeCashFlow { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
