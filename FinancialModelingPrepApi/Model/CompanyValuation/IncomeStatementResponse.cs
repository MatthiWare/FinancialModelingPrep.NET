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

        [JsonPropertyName("revenue")]
        public decimal Revenue { get; set; }

        [JsonPropertyName("costOfRevenue")]
        public decimal CostOfRevenue { get; set; }

        [JsonPropertyName("grossProfit")]
        public decimal GrossProfit { get; set; }

        [JsonPropertyName("grossProfitRatio")]
        public decimal GrossProfitRatio { get; set; }

        [JsonPropertyName("researchAndDevelopmentExpenses")]
        public decimal ResearchAndDevelopmentExpenses { get; set; }

        [JsonPropertyName("generalAndAdministrativeExpenses")]
        public decimal GeneralAndAdministrativeExpenses { get; set; }

        [JsonPropertyName("sellingAndMarketingExpenses")]
        public decimal SellingAndMarketingExpenses { get; set; }

        [JsonPropertyName("sellingGeneralAndAdministrativeExpenses")]
        public decimal SellingGeneralAndAdministrativeExpenses { get; set; }

        [JsonPropertyName("otherExpenses")]
        public decimal OtherExpenses { get; set; }

        [JsonPropertyName("operatingExpenses")]
        public decimal OperatingExpenses { get; set; }

        [JsonPropertyName("costAndExpenses")]
        public decimal CostAndExpenses { get; set; }

        [JsonPropertyName("interestIncome")]
        public decimal InterestIncome { get; set; }

        [JsonPropertyName("interestExpense")]
        public decimal InterestExpense { get; set; }

        [JsonPropertyName("depreciationAndAmortization")]
        public decimal DepreciationAndAmortization { get; set; }

        [JsonPropertyName("ebitda")]
        public decimal Ebitda { get; set; }

        [JsonPropertyName("ebitdaratio")]
        public decimal Ebitdaratio { get; set; }

        [JsonPropertyName("operatingIncome")]
        public decimal OperatingIncome { get; set; }

        [JsonPropertyName("operatingIncomeRatio")]
        public decimal OperatingIncomeRatio { get; set; }

        [JsonPropertyName("totalOtherIncomeExpensesNet")]
        public decimal TotalOtherIncomeExpensesNet { get; set; }

        [JsonPropertyName("incomeBeforeTax")]
        public decimal IncomeBeforeTax { get; set; }

        [JsonPropertyName("incomeBeforeTaxRatio")]
        public decimal IncomeBeforeTaxRatio { get; set; }

        [JsonPropertyName("incomeTaxExpense")]
        public decimal IncomeTaxExpense { get; set; }

        [JsonPropertyName("netIncome")]
        public decimal NetIncome { get; set; }

        [JsonPropertyName("netIncomeRatio")]
        public decimal NetIncomeRatio { get; set; }

        [JsonPropertyName("eps")]
        public decimal Eps { get; set; }

        [JsonPropertyName("epsdiluted")]
        public decimal Epsdiluted { get; set; }

        [JsonPropertyName("weightedAverageShsOut")]
        public decimal WeightedAverageShsOut { get; set; }

        [JsonPropertyName("weightedAverageShsOutDil")]
        public decimal WeightedAverageShsOutDil { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
