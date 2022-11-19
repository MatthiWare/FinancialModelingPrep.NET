using System;

namespace MatthiWare.FinancialModelingPrep.Model.Economics
{
    public enum EconomicIndicator
    {
        GDP,
        RealGDP, 
        NominalPotentialGDP,
        RealGDPPerCapita, 
        FederalFunds, 
        CPI,
        InflationRate, 
        Inflation,
        RetailSales,
        ConsumerSentiment,
        DurableGoods, 
        UnemploymentRate,
        TotalNonfarmPayroll,
        InitialClaims,
        IndustrialProductionTotalIndex,
        NewPrivatelyOwnedHousingUnitsStartedTotalUnits,
        TotalVehicleSales,
        RetailMoneyFunds, 
        SmoothedUSRecessionProbabilities,
        CertificatesOfDeposit3MonthOr90DayRatesAndYields,
        CommercialBankInterestRateOnCreditCardPlansAllAccounts,
        FixedRateMortgageAverage30Year,
        FixedRateMortgageAverage15Year,
    }

    public static class EconomicIndicatorExtensions
    {
        public static string ToFMP(this EconomicIndicator indicator)
        {
            return indicator switch
            {
                EconomicIndicator.GDP => "GDP",
                EconomicIndicator.RealGDP => "realGDP",
                EconomicIndicator.NominalPotentialGDP => "nominalPotentialGDP",
                EconomicIndicator.RealGDPPerCapita => "realGDPPerCapita",
                EconomicIndicator.FederalFunds => "federalFunds",
                EconomicIndicator.CPI => "CPI",
                EconomicIndicator.InflationRate => "inflationRate",
                EconomicIndicator.Inflation => "inflation",
                EconomicIndicator.RetailSales => "retailSales",
                EconomicIndicator.ConsumerSentiment => "consumerSentiment",
                EconomicIndicator.DurableGoods => "durableGoods",
                EconomicIndicator.UnemploymentRate => "unemploymentRate",
                EconomicIndicator.TotalNonfarmPayroll => "totalNonfarmPayroll",
                EconomicIndicator.InitialClaims => "initialClaims",
                EconomicIndicator.IndustrialProductionTotalIndex => "industrialProductionTotalIndex",
                EconomicIndicator.NewPrivatelyOwnedHousingUnitsStartedTotalUnits => "newPrivatelyOwnedHousingUnitsStartedTotalUnits",
                EconomicIndicator.TotalVehicleSales => "totalVehicleSales",
                EconomicIndicator.RetailMoneyFunds => "retailMoneyFunds",
                EconomicIndicator.SmoothedUSRecessionProbabilities => "smoothedUSRecessionProbabilities",
                EconomicIndicator.CertificatesOfDeposit3MonthOr90DayRatesAndYields => "3MonthOr90DayRatesAndYieldsCertificatesOfDeposit",
                EconomicIndicator.CommercialBankInterestRateOnCreditCardPlansAllAccounts => "commercialBankInterestRateOnCreditCardPlansAllAccounts",
                EconomicIndicator.FixedRateMortgageAverage15Year => "15YearFixedRateMortgageAverage",
                EconomicIndicator.FixedRateMortgageAverage30Year => "30YearFixedRateMortgageAverage",
                _ => throw new NotImplementedException(),
            };
        }
    }
}
