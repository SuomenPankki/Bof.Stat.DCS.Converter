using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV.PEF;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings.PEF
{
    public class PEF_PEFMap : ClassMap<PEF_PEF>
    {
        public PEF_PEFMap()
        {
            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);
            Map(m => m.Category).Index(3);
            Map(m => m.ContractType).Index(4);
            Map(m => m.Instrument).Index(5);
            Map(m => m.InternalIdentificationCode).Index(7);
            Map(m => m.IsinCode).Index(8);
            Map(m => m.NumberOfInstruments).Index(10);
            Map(m => m.TotalNominalValue).Index(11);
            Map(m => m.NominalValueCurrency).Index(12);
            Map(m => m.TotalMarketValueDirty).Index(13);
            Map(m => m.TotalMarketValueClean).Index(14);
            Map(m => m.CapitalFlows).Index(15);
            Map(m => m.LoanLosses).Index(16);
            Map(m => m.TypeOfCounterpartysIdentifier).Index(20);
            Map(m => m.CounterpartysIdentifier).Index(21);
            Map(m => m.CounterpartysName).Index(22);
            Map(m => m.CounterpartysSector).Index(23);
            Map(m => m.CounterpartysHomeCountry).Index(24);
            Map(m => m.IssueDate).Convert(x => x.Row.GetField(28).ParseToNullableDate());
            Map(m => m.MaturityDate).Convert(x => x.Row.GetField(29).ParseToNullableDate());
            Map(m => m.TypeOfIssuersIdentifier).Index(32);
            Map(m => m.IssuersIdentifier).Index(33);
            Map(m => m.IssuersName).Index(34);
            Map(m => m.IssuersSector).Index(35);
            Map(m => m.IssuersHomeCountry).Index(36);
        }
    }
}
