using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class TIHA_SBSMap : ClassMap<TIHA_SBS>
    {
        public TIHA_SBSMap()
        {
            Map(m => m.Instrument).Index(5);
            Map(m => m.InternalIdentificationCode).Index(7);
            Map(m => m.IsinCode).Index(8);
            Map(m => m.InstrumentsName).Index(10);
            Map(m => m.NumberOfInstruments).Index(12);
            Map(m => m.TotalNominalValue).Index(13);
            Map(m => m.NominalCurrency).Index(14);
            Map(m => m.TotalMarketValue).Index(18);
            Map(m => m.MarketCurrency).Index(19);
            Map(m => m.Dividends).Index(22);
            Map(m => m.DividendCurrency).Index(23);
            Map(m => m.IssueDate).Convert(x => x.Row.GetField(29).ParseToNullableDate());
            Map(m => m.MaturityDate).Convert(x => x.Row.GetField(30).ParseToNullableDate());
            Map(m => m.NextCouponDate).Convert(x => x.Row.GetField(31).ParseToNullableDate());
            Map(m => m.CouponRate).Index(32);
            Map(m => m.CouponFrequency).Index(33);
            Map(m => m.IssuersSector).Index(38);
            Map(m => m.IssuersHomeCountry).Index(39);
            Map(m => m.TypeOfHoldersIdentifier).Index(40);
            Map(m => m.HoldersIdentifier).Index(41);
            Map(m => m.HoldersName).Index(42);
            Map(m => m.HoldersSector).Index(43);
            Map(m => m.HoldersHomeTaxationCountry).Index(44);

        }
    }
}
