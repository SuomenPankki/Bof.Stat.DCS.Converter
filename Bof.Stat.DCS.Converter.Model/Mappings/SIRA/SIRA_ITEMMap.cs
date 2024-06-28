using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV.SIRA;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings.SIRA

{
    public class SIRA_ITEMMap : ClassMap<SIRA_ITEM>
    {
        public SIRA_ITEMMap()
        {

            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);

            Map(m => m.Category).Index(3);
            Map(m => m.Instrument).Index(5);
            Map(m => m.Collateral).Index(6);
            Map(m => m.InternalIdentificationCode).Index(7);
            Map(m => m.NominalValueCurrency).Index(14);
            Map(m => m.TotalValue).Index(15);
            Map(m => m.CurrencyOfValue).Index(16);
            Map(m => m.TypeOfCounterpartysIdentifier).Index(24);
            Map(m => m.CounterpartysIdentifier).Index(25);
            Map(m => m.CounterpartysName).Index(26);
            Map(m => m.CounterpartysSector).Index(27);
            Map(m => m.CounterpartysHomeCountry).Index(28);
            Map(m => m.IssueDate).Convert(x => x.Row.GetField(29).ParseToNullableDate());
            Map(m => m.MaturityDate).Convert(x => x.Row.GetField(30).ParseToNullableDate());

        }
    }
}
