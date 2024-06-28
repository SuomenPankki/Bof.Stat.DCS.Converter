using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MURA_BSMap : ClassMap<MURA_BS>
    {
        public MURA_BSMap()
        {
            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);
            Map(m => m.ReportingFrequency).Index(3);
            Map(m => m.ReportersName).Index(4);
            Map(m => m.TotalAssets).Index(13);
        }
    }
}
