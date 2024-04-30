using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MAPE_CARDMap : ClassMap<MAPE_CARD>
    {
        public MAPE_CARDMap()
        {
            Map(m => m.CardTypeProperty).Index(3);
            Map(m => m.EMoneyCardType).Index(4);
            Map(m => m.Scheme).Index(5);
            Map(m => m.CashFunction).Index(6);
            Map(m => m.CombinationCard).Index(7);
            Map(m => m.CardTechnology).Index(8);
            Map(m => m.PaymentServiceUser).Index(9);
            Map(m => m.Country).Index(10);
            Map(m => m.Amount).Index(11);
        }
    }
}
