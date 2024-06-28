using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV.SIRA;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings.SIRA
{
    public class SIRA_SBSMap : ClassMap<SIRA_SBS>
    {
        public SIRA_SBSMap()
        {

            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);

            Map(m => m.Category).Index(3);
            Map(m => m.ContractType).Index(4);
            Map(m => m.Instrument).Index(5);
            Map(m => m.Collateral).Index(6);
            Map(m => m.InternalIdentificationCode).Index(7);
            Map(m => m.IsinCode).Index(8);
            Map(m => m.AllCode).Index(9);
            Map(m => m.InstrumentsName).Index(10);
            Map(m => m.NumberOfInstruments).Index(12);
            Map(m => m.TotalNominalValue).Index(13);
            Map(m => m.NominalValueCurrency).Index(14);
            Map(m => m.TotalMarketValueDirtyPrice).Index(15);
            Map(m => m.MarketCurrencyDirtyPrice).Index(16);
            Map(m => m.TotalMarketValueCleanPrice).Index(18);
            Map(m => m.MarketCurrencyCleanPrice).Index(19);
            Map(m => m.TypeOfCounterpartysIdentifier).Index(24);
            Map(m => m.CounterpartysIdentifier).Index(25);
            Map(m => m.CounterpartysName).Index(26);
            Map(m => m.CounterpartysSector).Index(27);
            Map(m => m.CounterpartysHomeCountry).Index(28);
            Map(m => m.IssueDate).Convert(x => x.Row.GetField(29).ParseToNullableDate());
            Map(m => m.MaturityDate).Convert(x => x.Row.GetField(30).ParseToNullableDate());
            Map(m => m.TypeOfIssuersIdentifier).Index(35);
            Map(m => m.IssuersIdentifier).Index(36);
            Map(m => m.IssuersName).Index(37);
            Map(m => m.IssuersSector).Index(38);
            Map(m => m.IssuersHomeCountry).Index(39);
            Map(m => m.DerivativesSellingOrBuyingIndicator).Index(44);
            Map(m => m.Marketplace).Index(45);
            Map(m => m.UnderlyingAssetOfDerivative).Index(46);
            Map(m => m.TypeOfUnderlyingAssetsIdentifier).Index(47);
            Map(m => m.UnderlyingAssetsIdentifier).Index(48);
            Map(m => m.TypeOfUnderlyingSecurityIssuersIdentifier).Index(49);
            Map(m => m.UnderlyingSecurityIssuersIdentifier).Index(50);
            Map(m => m.NameOfUnderlyingSecurityIssuer).Index(51);
            Map(m => m.HomeCountryOfUnderlyingSecurityIssuer).Index(52);
            Map(m => m.TotalNumberOfUnderlyingAssets).Index(53);
            Map(m => m.MarketPriceOfUnderlyingAsset).Index(54);
            Map(m => m.MarketPriceCurrencyOfUnderlyingAsset).Index(55);
            Map(m => m.DerivativesRiskWeightedValue).Index(56);
            Map(m => m.CurrencyOfDerivativesRiskWeightedValue).Index(57);
            Map(m => m.DerivativesDelta).Index(58);

        }
    }
}
