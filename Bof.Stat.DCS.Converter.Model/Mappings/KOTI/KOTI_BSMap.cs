using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class KOTI_BSMap : ClassMap<KOTI_BS>
    {
        public KOTI_BSMap()
        {
            Map(m => m.ReportingFrequency).Index(3);
            Map(m => m.ReportersName).Index(4);
            Map(m => m.RiskWeightedAssets).Index(11);
            Map(m => m.Tier1Capital).Index(12);
            Map(m => m.ConsolidatedBalanceSheet).Index(13);

        }
    }
}
