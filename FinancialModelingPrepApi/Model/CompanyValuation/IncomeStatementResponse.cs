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
        public double Revenue { get; set; }

        [JsonPropertyName("costOfRevenue")]
        public double CostOfRevenue { get; set; }

        [JsonPropertyName("grossProfit")]
        public double GrossProfit { get; set; }

        [JsonPropertyName("grossProfitRatio")]
        public double? GrossProfitRatio { get; set; }

        [JsonPropertyName("researchAndDevelopmentExpenses")]
        public double ResearchAndDevelopmentExpenses { get; set; }

        [JsonPropertyName("generalAndAdministrativeExpenses")]
        public double GeneralAndAdministrativeExpenses { get; set; }

        [JsonPropertyName("sellingAndMarketingExpenses")]
        public double SellingAndMarketingExpenses { get; set; }

        [JsonPropertyName("sellingGeneralAndAdministrativeExpenses")]
        public double SellingGeneralAndAdministrativeExpenses { get; set; }

        [JsonPropertyName("otherExpenses")]
        public double OtherExpenses { get; set; }

        [JsonPropertyName("operatingExpenses")]
        public double OperatingExpenses { get; set; }

        [JsonPropertyName("costAndExpenses")]
        public double CostAndExpenses { get; set; }

        [JsonPropertyName("interestIncome")]
        public double? InterestIncome { get; set; }

        [JsonPropertyName("interestExpense")]
        public double? InterestExpense { get; set; }

        [JsonPropertyName("depreciationAndAmortization")]
        public double DepreciationAndAmortization { get; set; }

        [JsonPropertyName("ebitda")]
        public double Ebitda { get; set; }

        [JsonPropertyName("ebitdaratio")]
        public double? Ebitdaratio { get; set; }

        [JsonPropertyName("operatingIncome")]
        public double OperatingIncome { get; set; }

        [JsonPropertyName("operatingIncomeRatio")]
        public double? OperatingIncomeRatio { get; set; }

        [JsonPropertyName("totalOtherIncomeExpensesNet")]
        public double TotalOtherIncomeExpensesNet { get; set; }

        [JsonPropertyName("incomeBeforeTax")]
        public double IncomeBeforeTax { get; set; }

        [JsonPropertyName("incomeBeforeTaxRatio")]
        public double? IncomeBeforeTaxRatio { get; set; }

        [JsonPropertyName("incomeTaxExpense")]
        public double IncomeTaxExpense { get; set; }

        [JsonPropertyName("netIncome")]
        public double NetIncome { get; set; }

        [JsonPropertyName("netIncomeRatio")]
        public double? NetIncomeRatio { get; set; }

        [JsonPropertyName("eps")]
        public double Eps { get; set; }

        [JsonPropertyName("epsdiluted")]
        public double Epsdiluted { get; set; }

        [JsonPropertyName("weightedAverageShsOut")]
        public double WeightedAverageShsOut { get; set; }

        [JsonPropertyName("weightedAverageShsOutDil")]
        public double WeightedAverageShsOutDil { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("finalLink")]
        public string FinalLink { get; set; }
    }
}
