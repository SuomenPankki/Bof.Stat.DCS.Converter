using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MAPE_QPAYMap : ClassMap<MAPE_QPAY>
    {
        public MAPE_QPAYMap()
        {
            Map(m => m.ReportersRole).Index(3);
            Map(m => m.InformationType).Index(4);
            Map(m => m.PaymentService).Index(5);
            Map(m => m.PaymentServiceUser).Index(6);
            Map(m => m.Electronic).Index(7);
            Map(m => m.RemoteNonRemote).Index(14);
            Map(m => m.CounterpartysPspLocation).Index(23);
            Map(m => m.TerminalLocation).Index(24);
            Map(m => m.Industry).Index(26);
            Map(m => m.Amount).Index(27);
            Map(m => m.Value).Index(28);
        }
    }
}
