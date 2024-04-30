using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class KOTI_CSIAMap : ClassMap<KOTI_CSIA>
    {
        public KOTI_CSIAMap()
        {
            Map(m => m.TypeOfReporterIdentifier).Convert(x => x.Row.GetField(1).GetTypeOfeRegIdentifier());
            Map(m => m.ReporterIdentifier).Index(2);
            Map(m => m.AllocationOfBalanceSheetItem).Index(3);
            Map(m => m.Transaction).Index(4);
            Map(m => m.BisUnit).Index(5);
            Map(m => m.Instrument).Index(6);
            Map(m => m.InternalIdentificationCode).Index(7);
            Map(m => m.Sector).Index(8);
            Map(m => m.CountryCode).Index(9);
            Map(m => m.HomeCountryOfGroupEntityCountyCode).Index(10);
            Map(m => m.ConversionCurrency).Index(11);
            Map(m => m.BookValue).Index(12);
            Map(m => m.BookValueCurrency).Index(13);
            Map(m => m.RemainingMaturity).Index(15);
            Map(m => m.TargetCountryOfRiskTransfer).Index(16);
            Map(m => m.TargetSectorOfRiskTransfer).Index(17);
            Map(m => m.CollateralType).Index(18);
            Map(m => m.DebtSecurityType).Index(19);
            Map(m => m.AccountingClassification).Index(20);
            Map(m => m.TypeOfEquityInvestment).Index(21);
            Map(m => m.Subordination).Index(22);
            Map(m => m.InsuranceAssetType).Index(24);
            Map(m => m.InsurancePolicyType).Index(25);
            Map(m => m.EquityType).Index(26);

        }

    }
}
