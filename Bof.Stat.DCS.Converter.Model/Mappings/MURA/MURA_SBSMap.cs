using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MURA_SBSMap : ClassMap<MURA_SBS>
    {
        public MURA_SBSMap()
        {
            Map(m => m.AllocationOfBalanceSheetItem).Index(3);
            Map(m => m.Transaction).Index(4);
            Map(m => m.Instrument).Index(5);
            Map(m => m.InternalIdentifier).Index(7);
            Map(m => m.IsinCode).Index(8);
            Map(m => m.NumberOfInstrument).Index(12);
            Map(m => m.TotalNominalValue).Index(13);
            Map(m => m.NominalValueCurrency).Index(14);
            Map(m => m.TotalMarketValueDirty).Index(15);
            Map(m => m.MarketCurrencyDirty).Index(16);
            Map(m => m.TotalMarketValueClean).Index(18);
            Map(m => m.MarketCurrencyClean).Index(19);
            Map(m => m.IntraGroupItem).Index(20);
            Map(m => m.DirectInvestment).Index(21);
            Map(m => m.Dividend).Index(22);
            Map(m => m.DividendCurrency).Index(23);
            Map(m => m.CounterpartysSector).Index(27);
            Map(m => m.CounterpartysHomeCountry).Index(28);
            Map(m => m.IssueDate).Convert(x => x.Row.GetField(29).ParseToNullableDate());
            Map(m => m.MaturityDate).Convert(x => x.Row.GetField(30).ParseToNullableDate());
            Map(m => m.CountryOfIssue).Index(34);
            Map(m => m.TypeOfIssuersIdentifier).Index(35);
            Map(m => m.IssuersIdentifier).Index(36);
            Map(m => m.IssuersName).Index(37);
            Map(m => m.IssuersSector).Index(38);
            Map(m => m.IssuersHomeCountry).Index(39);
        }
    }
}
