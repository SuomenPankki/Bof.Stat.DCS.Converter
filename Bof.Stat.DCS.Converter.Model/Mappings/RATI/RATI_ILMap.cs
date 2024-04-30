using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class RATI_ILMap : ClassMap<RATI_IL>
    {
        public RATI_ILMap()
        {
            Map(m => m.AllocationOfBalanceSheetItem).Index(3);
            Map(m => m.Transaction).Index(4);
            Map(m => m.Instrument).Index(6);
            Map(m => m.PurposeOfLoan).Index(12);
            Map(m => m.IntraGroupItem).Index(13);
            Map(m => m.SyndicatedItem).Index(14);
            Map(m => m.Collateral).Index(15);
            Map(m => m.InternalIdentifier).Index(16);
            Map(m => m.Sector).Index(18);
            Map(m => m.EcbsAuxiliarySector).Index(21);
            Map(m => m.IndustrialClassification).Index(22);
            Map(m => m.CountryCode).Index(23);
            Map(m => m.ConversionCurrency).Index(30);
            Map(m => m.NextInterestRateReset).Index(39);
            Map(m => m.InterestRateLinkage).Index(40);
            Map(m => m.OriginalMaturity).Index(42);
            Map(m => m.SizeOfLoanToNonFinancialCorporation).Index(44);
            Map(m => m.CollectiveImpairment).Index(46);
        }
    }
}
