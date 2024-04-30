using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class KOTI_CSMap : ClassMap<KOTI_CS>
    {
        public KOTI_CSMap()
        {
            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);
            Map(m => m.AllocationOfBalanceSheetItem).Index(3);
            Map(m => m.Transaction).Index(4);
            Map(m => m.Instrument).Index(6);
            Map(m => m.InternalIdentifier).Index(7);
            Map(m => m.Sector).Index(8);
            Map(m => m.CountryCode).Index(9);
            Map(m => m.GroupUnitCountry).Index(10);
            Map(m => m.ConversionCurrency).Index(11);
            Map(m => m.BookValue).Index(12);
            Map(m => m.BookValueCurrency).Index(13);
            Map(m => m.RemainingMaturity).Index(15);
            Map(m => m.TargetCountryOfRiskTransfer).Index(16);
            Map(m => m.TargetSectorOfRiskTransfer).Index(17);


        }
    }
}
