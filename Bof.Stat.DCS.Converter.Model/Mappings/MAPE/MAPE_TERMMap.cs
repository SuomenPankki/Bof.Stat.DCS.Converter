using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MAPE_TERMMap : ClassMap<MAPE_TERM>
    {
        public MAPE_TERMMap()
        {
            Map(m => m.TerminalType).Index(3);
            Map(m => m.Eftpos).Index(4);
            Map(m => m.ContactlessPayment).Index(5);
            Map(m => m.TerminalAcceptingEMoney).Index(6);
            Map(m => m.EMoneyLoadingUnloading).Index(7);
            Map(m => m.Country).Index(8);
            Map(m => m.Amount).Index(9);
        }
    }
}
