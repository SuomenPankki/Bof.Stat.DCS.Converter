using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MAPE_APAYMap : ClassMap<MAPE_APAY>
    {
        public MAPE_APAYMap()
        {
            Map(m => m.ReportersRole).Index(3);
            Map(m => m.InformationType).Index(4);
            Map(m => m.PaymentService).Index(5);
            Map(m => m.Electronic).Index(7);
            Map(m => m.ChannelForGivingConsent).Index(9);
            Map(m => m.CardType).Index(12);
            Map(m => m.RemoteNonRemote).Index(14);
            Map(m => m.Terminal).Index(16);
            Map(m => m.CustomerAuthentication).Index(19);
            Map(m => m.ReasonForNonSca).Index(20);
            Map(m => m.FraudType).Index(21);
            Map(m => m.LiabilityBearer).Index(22);
            Map(m => m.CounterpartysPspLocation).Index(23);
            Map(m => m.TerminalLocation).Index(24);
            Map(m => m.Amount).Index(27);
            Map(m => m.Value).Index(28);
        }
    }
}
