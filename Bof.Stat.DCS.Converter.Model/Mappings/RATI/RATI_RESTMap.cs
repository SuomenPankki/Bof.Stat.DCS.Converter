using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class RATI_RESTMap : ClassMap<RATI_REST>
    {
        public RATI_RESTMap()
        {
            Map(m => m.AllocationOfBalanceSheetItem).Index(3);
            Map(m => m.Transaction).Index(4);
            Map(m => m.Instrument).Index(6);
            Map(m => m.IntraGroupItem).Index(9);
            Map(m => m.InternalIdentifier).Index(10);
            Map(m => m.Sector).Index(11);
            Map(m => m.CountryCode).Index(12);
            Map(m => m.ConversionCurrency).Index(14);
            Map(m => m.BookValue).Index(15);
            Map(m => m.BookValueCurrency).Index(16);
        }
    }
}
