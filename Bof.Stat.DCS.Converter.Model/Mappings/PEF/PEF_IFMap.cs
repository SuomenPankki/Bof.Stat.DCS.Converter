using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV.PEF;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings.PEF
{
    public class PEF_IFMap : ClassMap<PEF_IF>
    {
        public PEF_IFMap()
        {

            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);
            Map(m => m.ReporterName).Index(3);
            Map(m => m.ExchangeRate).Index(4);
            Map(m => m.CurrencyOfExchangeRate).Index(5);
            Map(m => m.BalanceSheetTotal).Index(6);
            Map(m => m.BalanceSheetCurrency).Index(7);
            Map(m => m.TotalNumberOfUnitholders).Index(8);
        }
    }
}
