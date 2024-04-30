using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings.MAPE
{
    public class MAPE_HeaderMap : ClassMap<Header>
    {
        public MAPE_HeaderMap()
        {
            Map(m => m.TypeOfDataProviderIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.DataProviderIdentifier).Index(2);
            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(3).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(4);
            Map(m => m.SurveyCode).Index(5);
            Map(m => m.Frequency).Convert(x => x.Row.GetField(8).Substring(4, 1));
            Map(m => m.ReportingPeriodEnd).Convert(x => x.Row.GetField(8).PeriodToDate().Value);
            Map(m => m.CreationDate).Index(9).TypeConverter<CsvHelper.TypeConversion.DateTimeConverter>().TypeConverterOption.Format("yyyyMMddHHmmss");
            Map(m => m.EntitysComment).Index(11);
        }
    }
}
