using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep
{
    //Consumer Cyclical | Energy | Technology | Industrials | Financial Services | Basic Materials | Communication Services | Consumer Defensive | Healthcare | Real Estate | Utilities | Industrial Goods | Financial | Services | Conglomerates
    // Industry : Autos | Banks | Banks Diversified | Software | Banks Regional | Beverages Alcoholic | Beverages Brewers | Beverages Non-Alcoholic
    public enum Sector
    {
        ConsumerCyclical,
        Energy,
        Technology,
        Industrials,
        FinancialServices,
        BasicMaterials,
        CommunicationServices,
        ConsumerDefensive,
        Healthcare,
        RealEstate,
        Utilities
    }

    public enum Country
    {
        US,
        UK,
        MX,
        BR,
        RU,
        HK,
        CA
    }
}
