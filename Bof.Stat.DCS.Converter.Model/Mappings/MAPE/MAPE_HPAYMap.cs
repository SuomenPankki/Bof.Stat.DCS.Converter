using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MAPE_HPAYMap : ClassMap<MAPE_HPAY>
    {
        public MAPE_HPAYMap()
        {
            Map(m => m.ReportersRole).Index(3);
            Map(m => m.InformationType).Index(4);
            Map(m => m.PaymentService).Index(5);
            Map(m => m.PaymentServiceUser).Index(6);
            Map(m => m.Electronic).Index(7);
            Map(m => m.PaymentOrder).Index(8);
            Map(m => m.ChannelForGivingConsent).Index(9);
            Map(m => m.PaymentScheme).Index(10);
            Map(m => m.InstantPayment).Index(11);
            Map(m => m.CardType).Index(12);
            Map(m => m.EMoneyType).Index(13);
            Map(m => m.RemoteNonRemote).Index(14);
            Map(m => m.ContactlessTechnology).Index(15);
            Map(m => m.Terminal).Index(16);
            Map(m => m.InitiationChannel).Index(17);
            Map(m => m.MobilePaymentType).Index(18);
            Map(m => m.CustomerAuthentication).Index(19);
            Map(m => m.ReasonForNonSca).Index(20);
            Map(m => m.FraudType).Index(21);
            Map(m => m.LiabilityBearer).Index(22);
            Map(m => m.CounterpartysPspLocation).Index(23);
            Map(m => m.TerminalLocation).Index(24);
            Map(m => m.Currency).Index(25);
            Map(m => m.Amount).Index(27);
            Map(m => m.Value).Index(28);
        }
    }
}
