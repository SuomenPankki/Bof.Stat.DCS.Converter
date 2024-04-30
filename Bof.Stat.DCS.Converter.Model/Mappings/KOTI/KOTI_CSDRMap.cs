using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class KOTI_CSDRMap : ClassMap<KOTI_CSDR>
    {
        public KOTI_CSDRMap()
        {
            Map(m => m.Transaction).Index(4);
            Map(m => m.BisUnit).Index(5);
            Map(m => m.Instrument).Index(6);
            Map(m => m.InternalIdentifier).Index(7);
            Map(m => m.Sector).Index(8);
            Map(m => m.CountryCode).Index(9);
            Map(m => m.ConversionCurrency).Index(11);
            Map(m => m.BookValue).Index(12);
            Map(m => m.BookValueCurrency).Index(13);
            Map(m => m.RemainingMaturity).Index(15);
            Map(m => m.MeasureType).Index(27);
            Map(m => m.CurrencyBought).Index(28);
            Map(m => m.CurrencySold).Index(29);
            Map(m => m.MarketRisk).Index(30);
            Map(m => m.DerivativeContractType).Index(31);
            Map(m => m.ForeignExchangeDerivateContractType).Index(32);

        }

    }
}
