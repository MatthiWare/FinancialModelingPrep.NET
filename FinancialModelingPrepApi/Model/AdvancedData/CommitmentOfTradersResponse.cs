using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Model.AdvancedData
{
    public class CommitmentOfTradersResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("short_name")]
        public string ShortName { get; set; }

        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("market_and_exchange_names")]
        public string MarketAndExchangeNames { get; set; }

        [JsonPropertyName("as_of_date_in_form_yymmdd")]
        public string AsOfDateInFormYymmdd { get; set; }

        [JsonPropertyName("cftc_contract_market_code")]
        public string CftcContractMarketCode { get; set; }

        [JsonPropertyName("cftc_market_code")]
        public string CftcMarketCode { get; set; }

        [JsonPropertyName("cftc_region_code")]
        public string CftcRegionCode { get; set; }

        [JsonPropertyName("cftc_commodity_code")]
        public string CftcCommodityCode { get; set; }

        [JsonPropertyName("open_interest_all")]
        public int OpenInterestAll { get; set; }

        [JsonPropertyName("noncomm_positions_long_all")]
        public int NoncommPositionsLongAll { get; set; }

        [JsonPropertyName("noncomm_positions_short_all")]
        public int NoncommPositionsShortAll { get; set; }

        [JsonPropertyName("noncomm_postions_spread_all")]
        public int NoncommPostionsSpreadAll { get; set; }

        [JsonPropertyName("comm_positions_long_all")]
        public int CommPositionsLongAll { get; set; }

        [JsonPropertyName("comm_positions_short_all")]
        public int CommPositionsShortAll { get; set; }

        [JsonPropertyName("tot_rept_positions_long_all")]
        public int TotReptPositionsLongAll { get; set; }

        [JsonPropertyName("tot_rept_positions_short_all")]
        public int TotReptPositionsShortAll { get; set; }

        [JsonPropertyName("nonrept_positions_long_all")]
        public int NonreptPositionsLongAll { get; set; }

        [JsonPropertyName("nonrept_positions_short_all")]
        public int NonreptPositionsShortAll { get; set; }

        [JsonPropertyName("open_interest_old")]
        public int OpenInterestOld { get; set; }

        [JsonPropertyName("noncomm_positions_long_old")]
        public int NoncommPositionsLongOld { get; set; }

        [JsonPropertyName("noncomm_positions_short_old")]
        public int NoncommPositionsShortOld { get; set; }

        [JsonPropertyName("noncomm_positions_spread_old")]
        public int NoncommPositionsSpreadOld { get; set; }

        [JsonPropertyName("comm_positions_long_old")]
        public int CommPositionsLongOld { get; set; }

        [JsonPropertyName("comm_positions_short_old")]
        public int CommPositionsShortOld { get; set; }

        [JsonPropertyName("tot_rept_positions_long_old")]
        public int TotReptPositionsLongOld { get; set; }

        [JsonPropertyName("tot_rept_positions_short_old")]
        public int TotReptPositionsShortOld { get; set; }

        [JsonPropertyName("nonrept_positions_long_old")]
        public int NonreptPositionsLongOld { get; set; }

        [JsonPropertyName("nonrept_positions_short_old")]
        public int NonreptPositionsShortOld { get; set; }

        [JsonPropertyName("open_interest_other")]
        public int OpenInterestOther { get; set; }

        [JsonPropertyName("noncomm_positions_long_other")]
        public int NoncommPositionsLongOther { get; set; }

        [JsonPropertyName("noncomm_positions_short_other")]
        public int NoncommPositionsShortOther { get; set; }

        [JsonPropertyName("noncomm_positions_spread_other")]
        public int NoncommPositionsSpreadOther { get; set; }

        [JsonPropertyName("comm_positions_long_other")]
        public int CommPositionsLongOther { get; set; }

        [JsonPropertyName("comm_positions_short_other")]
        public int CommPositionsShortOther { get; set; }

        [JsonPropertyName("tot_rept_positions_long_other")]
        public int TotReptPositionsLongOther { get; set; }

        [JsonPropertyName("tot_rept_positions_short_other")]
        public int TotReptPositionsShortOther { get; set; }

        [JsonPropertyName("nonrept_positions_long_other")]
        public int NonreptPositionsLongOther { get; set; }

        [JsonPropertyName("nonrept_positions_short_other")]
        public int NonreptPositionsShortOther { get; set; }

        [JsonPropertyName("change_in_open_interest_all")]
        public int ChangeInOpenInterestAll { get; set; }

        [JsonPropertyName("change_in_noncomm_long_all")]
        public int ChangeInNoncommLongAll { get; set; }

        [JsonPropertyName("change_in_noncomm_short_all")]
        public int ChangeInNoncommShortAll { get; set; }

        [JsonPropertyName("change_in_noncomm_spead_all")]
        public int ChangeInNoncommSpeadAll { get; set; }

        [JsonPropertyName("change_in_comm_long_all")]
        public int ChangeInCommLongAll { get; set; }

        [JsonPropertyName("change_in_comm_short_all")]
        public int ChangeInCommShortAll { get; set; }

        [JsonPropertyName("change_in_tot_rept_long_all")]
        public int ChangeInTotReptLongAll { get; set; }

        [JsonPropertyName("change_in_tot_rept_short_all")]
        public int ChangeInTotReptShortAll { get; set; }

        [JsonPropertyName("change_in_nonrept_long_all")]
        public int ChangeInNonreptLongAll { get; set; }

        [JsonPropertyName("change_in_nonrept_short_all")]
        public int ChangeInNonreptShortAll { get; set; }

        [JsonPropertyName("pct_of_open_interest_all")]
        public int PctOfOpenInterestAll { get; set; }

        [JsonPropertyName("pct_of_oi_noncomm_long_all")]
        public double PctOfOiNoncommLongAll { get; set; }

        [JsonPropertyName("pct_of_oi_noncomm_short_all")]
        public double PctOfOiNoncommShortAll { get; set; }

        [JsonPropertyName("pct_of_oi_noncomm_spread_all")]
        public double PctOfOiNoncommSpreadAll { get; set; }

        [JsonPropertyName("pct_of_oi_comm_long_all")]
        public double PctOfOiCommLongAll { get; set; }

        [JsonPropertyName("pct_of_oi_comm_short_all")]
        public double PctOfOiCommShortAll { get; set; }

        [JsonPropertyName("pct_of_oi_tot_rept_long_all")]
        public double PctOfOiTotReptLongAll { get; set; }

        [JsonPropertyName("pct_of_oi_tot_rept_short_all")]
        public double PctOfOiTotReptShortAll { get; set; }

        [JsonPropertyName("pct_of_oi_nonrept_long_all")]
        public double PctOfOiNonreptLongAll { get; set; }

        [JsonPropertyName("pct_of_oi_nonrept_short_all")]
        public double PctOfOiNonreptShortAll { get; set; }

        [JsonPropertyName("pct_of_open_interest_ol")]
        public int PctOfOpenInterestOl { get; set; }

        [JsonPropertyName("pct_of_oi_noncomm_long_ol")]
        public double PctOfOiNoncommLongOl { get; set; }

        [JsonPropertyName("pct_of_oi_noncomm_short_ol")]
        public double PctOfOiNoncommShortOl { get; set; }

        [JsonPropertyName("pct_of_oi_noncomm_spread_ol")]
        public double PctOfOiNoncommSpreadOl { get; set; }

        [JsonPropertyName("pct_of_oi_comm_long_ol")]
        public double PctOfOiCommLongOl { get; set; }

        [JsonPropertyName("pct_of_oi_comm_short_ol")]
        public double PctOfOiCommShortOl { get; set; }

        [JsonPropertyName("pct_of_oi_tot_rept_long_ol")]
        public double PctOfOiTotReptLongOl { get; set; }

        [JsonPropertyName("pct_of_oi_tot_rept_short_ol")]
        public double PctOfOiTotReptShortOl { get; set; }

        [JsonPropertyName("pct_of_oi_nonrept_long_ol")]
        public double PctOfOiNonreptLongOl { get; set; }

        [JsonPropertyName("pct_of_oi_nonrept_short_ol")]
        public double PctOfOiNonreptShortOl { get; set; }

        [JsonPropertyName("pct_of_open_interest_other")]
        public int PctOfOpenInterestOther { get; set; }

        [JsonPropertyName("pct_of_oi_noncomm_long_other")]
        public int PctOfOiNoncommLongOther { get; set; }

        [JsonPropertyName("pct_of_oi_noncomm_short_other")]
        public int PctOfOiNoncommShortOther { get; set; }

        [JsonPropertyName("pct_of_oi_noncomm_spread_other")]
        public int PctOfOiNoncommSpreadOther { get; set; }

        [JsonPropertyName("pct_of_oi_comm_long_other")]
        public int PctOfOiCommLongOther { get; set; }

        [JsonPropertyName("pct_of_oi_comm_short_other")]
        public int PctOfOiCommShortOther { get; set; }

        [JsonPropertyName("pct_of_oi_tot_rept_long_other")]
        public int PctOfOiTotReptLongOther { get; set; }

        [JsonPropertyName("pct_of_oi_tot_rept_short_other")]
        public int PctOfOiTotReptShortOther { get; set; }

        [JsonPropertyName("pct_of_oi_nonrept_long_other")]
        public int PctOfOiNonreptLongOther { get; set; }

        [JsonPropertyName("pct_of_oi_nonrept_short_other")]
        public int PctOfOiNonreptShortOther { get; set; }

        [JsonPropertyName("traders_tot_all")]
        public int TradersTotAll { get; set; }

        [JsonPropertyName("traders_noncomm_long_all")]
        public int TradersNoncommLongAll { get; set; }

        [JsonPropertyName("traders_noncomm_short_all")]
        public int TradersNoncommShortAll { get; set; }

        [JsonPropertyName("traders_noncomm_spread_all")]
        public int TradersNoncommSpreadAll { get; set; }

        [JsonPropertyName("traders_comm_long_all")]
        public int TradersCommLongAll { get; set; }

        [JsonPropertyName("traders_comm_short_all")]
        public int TradersCommShortAll { get; set; }

        [JsonPropertyName("traders_tot_rept_long_all")]
        public int TradersTotReptLongAll { get; set; }

        [JsonPropertyName("traders_tot_rept_short_all")]
        public int TradersTotReptShortAll { get; set; }

        [JsonPropertyName("traders_tot_ol")]
        public int TradersTotOl { get; set; }

        [JsonPropertyName("traders_noncomm_long_ol")]
        public int TradersNoncommLongOl { get; set; }

        [JsonPropertyName("traders_noncomm_short_ol")]
        public int TradersNoncommShortOl { get; set; }

        [JsonPropertyName("traders_noncomm_spead_ol")]
        public int TradersNoncommSpeadOl { get; set; }

        [JsonPropertyName("traders_comm_long_ol")]
        public int TradersCommLongOl { get; set; }

        [JsonPropertyName("traders_comm_short_ol")]
        public int TradersCommShortOl { get; set; }

        [JsonPropertyName("traders_tot_rept_long_ol")]
        public int TradersTotReptLongOl { get; set; }

        [JsonPropertyName("traders_tot_rept_short_ol")]
        public int TradersTotReptShortOl { get; set; }

        [JsonPropertyName("traders_tot_other")]
        public int TradersTotOther { get; set; }

        [JsonPropertyName("traders_noncomm_long_other")]
        public int TradersNoncommLongOther { get; set; }

        [JsonPropertyName("traders_noncomm_short_other")]
        public int TradersNoncommShortOther { get; set; }

        [JsonPropertyName("traders_noncomm_spread_other")]
        public int TradersNoncommSpreadOther { get; set; }

        [JsonPropertyName("traders_comm_long_other")]
        public int TradersCommLongOther { get; set; }

        [JsonPropertyName("traders_comm_short_other")]
        public int TradersCommShortOther { get; set; }

        [JsonPropertyName("traders_tot_rept_long_other")]
        public int TradersTotReptLongOther { get; set; }

        [JsonPropertyName("traders_tot_rept_short_other")]
        public int TradersTotReptShortOther { get; set; }

        [JsonPropertyName("conc_gross_le_4_tdr_long_all")]
        public double ConcGrossLe4TdrLongAll { get; set; }

        [JsonPropertyName("conc_gross_le_4_tdr_short_all")]
        public double ConcGrossLe4TdrShortAll { get; set; }

        [JsonPropertyName("conc_gross_le_8_tdr_long_all")]
        public double ConcGrossLe8TdrLongAll { get; set; }

        [JsonPropertyName("conc_gross_le_8_tdr_short_all")]
        public double ConcGrossLe8TdrShortAll { get; set; }

        [JsonPropertyName("conc_net_le_4_tdr_long_all")]
        public double ConcNetLe4TdrLongAll { get; set; }

        [JsonPropertyName("conc_net_le_4_tdr_short_all")]
        public double ConcNetLe4TdrShortAll { get; set; }

        [JsonPropertyName("conc_net_le_8_tdr_long_all")]
        public double ConcNetLe8TdrLongAll { get; set; }

        [JsonPropertyName("conc_net_le_8_tdr_short_all")]
        public double ConcNetLe8TdrShortAll { get; set; }

        [JsonPropertyName("conc_gross_le_4_tdr_long_ol")]
        public double ConcGrossLe4TdrLongOl { get; set; }

        [JsonPropertyName("conc_gross_le_4_tdr_short_ol")]
        public double ConcGrossLe4TdrShortOl { get; set; }

        [JsonPropertyName("conc_gross_le_8_tdr_long_ol")]
        public double ConcGrossLe8TdrLongOl { get; set; }

        [JsonPropertyName("conc_gross_le_8_tdr_short_ol")]
        public double ConcGrossLe8TdrShortOl { get; set; }

        [JsonPropertyName("conc_net_le_4_tdr_long_ol")]
        public double ConcNetLe4TdrLongOl { get; set; }

        [JsonPropertyName("conc_net_le_4_tdr_short_ol")]
        public double ConcNetLe4TdrShortOl { get; set; }

        [JsonPropertyName("conc_net_le_8_tdr_long_ol")]
        public double ConcNetLe8TdrLongOl { get; set; }

        [JsonPropertyName("conc_net_le_8_tdr_short_ol")]
        public double ConcNetLe8TdrShortOl { get; set; }

        [JsonPropertyName("conc_gross_le_4_tdr_long_other")]
        public int ConcGrossLe4TdrLongOther { get; set; }

        [JsonPropertyName("conc_gross_le_4_tdr_short_other")]
        public int ConcGrossLe4TdrShortOther { get; set; }

        [JsonPropertyName("conc_gross_le_8_tdr_long_other")]
        public int ConcGrossLe8TdrLongOther { get; set; }

        [JsonPropertyName("conc_gross_le_8_tdr_short_other")]
        public int ConcGrossLe8TdrShortOther { get; set; }

        [JsonPropertyName("conc_net_le_4_tdr_long_other")]
        public int ConcNetLe4TdrLongOther { get; set; }

        [JsonPropertyName("conc_net_le_4_tdr_short_other")]
        public int ConcNetLe4TdrShortOther { get; set; }

        [JsonPropertyName("conc_net_le_8_tdr_long_other")]
        public int ConcNetLe8TdrLongOther { get; set; }

        [JsonPropertyName("conc_net_le_8_tdr_short_other")]
        public int ConcNetLe8TdrShortOther { get; set; }

        [JsonPropertyName("contract_units")]
        public string ContractUnits { get; set; }
    }
}
