using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MAPE_ACCOMap : ClassMap<MAPE_ACCO>
    {
        public MAPE_ACCOMap()
        {
            Map(m => m.AccountsDepositsAndOffices).Index(3);
            Map(m => m.DepositType).Index(4);
            Map(m => m.AssetsTransferableViaNetwork).Index(5);
            Map(m => m.EMoneyAccount).Index(6);
            Map(m => m.PaymentServiceUser).Index(7);
            Map(m => m.Country).Index(8);
            Map(m => m.Amount).Index(9);
            Map(m => m.Value).Index(10);
        }
    }
}
