namespace MatthiWare.FinancialModelingPrep.Model.CompanyValuation
{
    public class EnterpriseValueResponse
    {
        public string symbol { get; set; }
        public string date { get; set; }
        public double stockPrice { get; set; }
        public long numberOfShares { get; set; }
        public double marketCapitalization { get; set; }
        public long minusCashAndCashEquivalents { get; set; }
        public long addTotalDebt { get; set; }
        public double enterpriseValue { get; set; }
    }
}
