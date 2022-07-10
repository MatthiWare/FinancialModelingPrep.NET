using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Model
{
    public static partial class EnumMappings
    {
        public readonly static Dictionary<Industry, string> Industries = new Dictionary<Industry, string>()
        {
            { Industry.Autos, "Autos" },
            { Industry.Banks, "Banks" },
            { Industry.BanksDiversified, "Banks Diversified" },
            { Industry.Software, "Software" },
            { Industry.BanksREgional, "Banks Regional" },
            { Industry.BeveragesAlcoholic, "Beverages Alcoholic" },
            { Industry.BeveragesBrewers, "Beverages Brewers" },
            { Industry.BeveragesNonAlcoholic, "Beverages Non-Alcoholic" },
        };

        public readonly static Dictionary<Sector, string> Sectors = new Dictionary<Sector, string>()
        {
            { Sector.ConsumerCyclical, "Consumer Cyclical" },
            { Sector.Energy, "Energy" },
            { Sector.Technology, "Technology" },
            { Sector.Industrials, "Industrials" },
            { Sector.FinancialServices, "Financial Services" },
            { Sector.BasicMaterials, "Basic Materials" },
            { Sector.CommunicationServices, "Communication Services" },
            { Sector.ConsumerDefensive, "Consumer Defensive" },
            { Sector.Healthcare, "Healthcare" },
            { Sector.RealEstate, "Real Estate" },
            { Sector.Utilities, "Utilities" },
        };

        public readonly static Dictionary<HistoricalPricingPeriod, string> HistoricalPrices = new Dictionary<HistoricalPricingPeriod, string>()
        {
            { HistoricalPricingPeriod.OneMinute, "1min" },
            { HistoricalPricingPeriod.FiveMinute, "5min" },
            { HistoricalPricingPeriod.FifteenMinute, "15min" },
            { HistoricalPricingPeriod.ThirtyMinute, "30min" },
            { HistoricalPricingPeriod.OneHour, "1hour" },
            { HistoricalPricingPeriod.FourHour, "4hour" }
        };
    }

}
