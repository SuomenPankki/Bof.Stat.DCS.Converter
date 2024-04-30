using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class SAVE_SBSMap : ClassMap<SAVE_SBS>
    {
        public SAVE_SBSMap()
        {
            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);
            Map(m => m.Category).Index(3);
            Map(m => m.ContractType).Index(4);
            Map(m => m.Instrument).Index(5);

            Map(m => m.InternalIdentificationCode).Index(7);
            Map(m => m.IsinCode).Index(8);

            Map(m => m.InstrumentName).Index(10);

            Map(m => m.NumberOfInstruments).Index(12);
            Map(m => m.TotalNominalValue).Index(13);
            Map(m => m.NominalCurrency).Index(14);

            Map(m => m.TotalMarketValue).Index(18);
            Map(m => m.MarketCurrency).Index(19);
            Map(m => m.IntraGroupItem).Index(20);

            Map(m => m.Dividends).Index(22);
            Map(m => m.DividendCurrency).Index(23);

            Map(m => m.ContractingPartysHomeCountry).Index(28);
            Map(m => m.IssueDate).Convert(x => x.Row.GetField(29).ParseToNullableDate());
            Map(m => m.MaturityDate).Convert(x => x.Row.GetField(30).ParseToNullableDate());
            Map(m => m.NextCouponDate).Convert(x => x.Row.GetField(31).ParseToNullableDate());
            Map(m => m.CouponRate).Index(32);
            Map(m => m.CouponFrequency).Index(33);
            Map(m => m.CountryOfIssue).Index(34);

            Map(m => m.IssuersSector).Index(38);
            Map(m => m.IssuersHomeCountry).Index(39);
        }
    }
}
