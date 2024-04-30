using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class KOTI_BSIAMap : ClassMap<KOTI_BSIA>
    {
        public KOTI_BSIAMap()
        {
            Map(m => m.ReportingFrequency).Index(3);
            Map(m => m.ReportersName).Index(4);
            Map(m => m.RiskWeightedAssets).Index(11);
            Map(m => m.Tier1Capital).Index(12);
            Map(m => m.BankingGroupBalanceSheet).Index(13);
            Map(m => m.TotalConsolidatedBalanceSheet).Index(14);


        }
    }
}
