using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV.SIRA;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings.SIRA
{
    public class SIRA_IFMap : ClassMap<SIRA_IF>
    {
        public SIRA_IFMap()
        {

            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);
            Map(m => m.ReporterName).Index(3);
            Map(m => m.ExchangeRate).Index(4);
            Map(m => m.CurrencyOfExchangeRate).Index(5);
            Map(m => m.BalanceSheetTotal).Index(6);
            Map(m => m.BalanceSheetCurrency).Index(7);
            Map(m => m.TotalNumberOfUnitholders).Index(8);
            Map(m => m.NumberOfPrivatePersonUnitholders).Index(9);
            Map(m => m.HoldingsOfTenLargestUnitholders).Index(10);
            Map(m => m.CurrencyOfHoldingsOfTenLargestUnitholders).Index(11);
            Map(m => m.DurationOfBondsAndMoneyMarketInstruments).Index(12);
            Map(m => m.TotalValueOfUnitLinkedInsurancesDomesticCompanies).Index(13);
            Map(m => m.TotalValueOfUnitLinkedInsurancesForeignCompanies).Index(14);
            Map(m => m.CurrencyOfUnitLinkedInsurances).Index(15);
            Map(m => m.CollateralRequirementForDerivatives).Index(16);
            Map(m => m.CurrencyOfCollateralRequirementForDerivatives).Index(17);
            Map(m => m.CollateralRequirementForRepurchaseAgreements).Index(18);
            Map(m => m.CurrencyOfCollateralRequirementForRepurchaseAgreements).Index(19);
            Map(m => m.CollateralRequirementForSecuritiesLendingAgreements).Index(20);
            Map(m => m.CurrencyOfCollateralRequirementForSecuritiesLendingAgreements).Index(21);
            Map(m => m.DividendIncomeAndIncomeFromFundShares).Index(22);
            Map(m => m.InterestIncome).Index(23);
            Map(m => m.ProfitDistribution).Index(24);

        }
    }
}
