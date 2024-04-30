using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;
using System.Reflection;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class HeaderMap : ClassMap<Header>
    {
        public HeaderMap()
        {
            Map(m => m.TypeOfDataProviderIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.DataProviderIdentifier).Index(2);
            Map(m => m.SurveyCode).Index(3);
            Map(m => m.Frequency).Convert(x => x.Row.GetField(5).Substring(4, 1));
            Map(m => m.ReportingPeriodEnd).Convert(x => x.Row.GetField(5).PeriodToDate().Value);
            Map(m => m.CreationDate).Index(6).TypeConverter<CsvHelper.TypeConversion.DateTimeConverter>().TypeConverterOption.Format("yyyyMMddHHmmss");
            Map(m => m.EntitysComment).Index(8);
            Map(m => m.ReporterEmail).Index(10);
            Map(m => m.TypeOfManagementCompanyIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ManagementCompanyIdentifier).Index(2);
        }
    }
}
