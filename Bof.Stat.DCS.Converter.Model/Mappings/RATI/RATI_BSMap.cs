using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class RATI_BSMap : ClassMap<RATI_BS>
    {
        public RATI_BSMap()
        {
            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);
            Map(m => m.ReportingFrequency).Index(3);
            Map(m => m.ReportersName).Index(4);
            Map(m => m.NumberOfHousingLoanCustomersHouseholds).Index(6);
            Map(m => m.NumberOfOffices).Index(11);
            Map(m => m.NumberOfEmployees).Index(12);
            Map(m => m.BalanceSheetTotal).Index(13);
        }
    }
}
