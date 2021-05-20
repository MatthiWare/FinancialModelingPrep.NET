using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class IncomeStatementResponse
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

        [JsonPropertyName("revenue")]
        public long Revenue { get; set; }

        [JsonPropertyName("costOfRevenue")]
        public long CostOfRevenue { get; set; }

        [JsonPropertyName("grossProfit")]
        public long GrossProfit { get; set; }

        [JsonPropertyName("grossProfitRatio")]
        public double GrossProfitRatio { get; set; }

        [JsonPropertyName("researchAndDevelopmentExpenses")]
        public long ResearchAndDevelopmentExpenses { get; set; }

        [JsonPropertyName("generalAndAdministrativeExpenses")]
        public long GeneralAndAdministrativeExpenses { get; set; }

        [JsonPropertyName("sellingAndMarketingExpenses")]
        public double SellingAndMarketingExpenses { get; set; }

        [JsonPropertyName("otherExpenses")]
        public int OtherExpenses { get; set; }

        [JsonPropertyName("operatingExpenses")]
        public long OperatingExpenses { get; set; }

        [JsonPropertyName("costAndExpenses")]
        public long CostAndExpenses { get; set; }

        [JsonPropertyName("interestExpense")]
        public long InterestExpense { get; set; }

        [JsonPropertyName("depreciationAndAmortization")]
        public long DepreciationAndAmortization { get; set; }

        [JsonPropertyName("ebitda")]
        public long Ebitda { get; set; }

        [JsonPropertyName("ebitdaratio")]
        public double Ebitdaratio { get; set; }

        [JsonPropertyName("operatingIncome")]
        public long OperatingIncome { get; set; }

        [JsonPropertyName("operatingIncomeRatio")]
        public double OperatingIncomeRatio { get; set; }

        [JsonPropertyName("totalOtherIncomeExpensesNet")]
        public int TotalOtherIncomeExpensesNet { get; set; }

        [JsonPropertyName("incomeBeforeTax")]
        public long IncomeBeforeTax { get; set; }

        [JsonPropertyName("incomeBeforeTaxRatio")]
        public double IncomeBeforeTaxRatio { get; set; }

        [JsonPropertyName("incomeTaxExpense")]
        public long IncomeTaxExpense { get; set; }

        [JsonPropertyName("netIncome")]
        public long NetIncome { get; set; }

        [JsonPropertyName("netIncomeRatio")]
        public double NetIncomeRatio { get; set; }

        [JsonPropertyName("eps")]
        public double Eps { get; set; }

        [JsonPropertyName("epsdiluted")]
        public double Epsdiluted { get; set; }

        [JsonPropertyName("weightedAverageShsOut")]
        public long WeightedAverageShsOut { get; set; }

        [JsonPropertyName("weightedAverageShsOutDil")]
        public long WeightedAverageShsOutDil { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
