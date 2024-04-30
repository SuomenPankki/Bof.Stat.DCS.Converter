using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class RATI_LDMap : ClassMap<RATI_LD>
    {
        public RATI_LDMap()
        {
            Map(m => m.AllocationOfBalanceSheetItem).Index(3);
            Map(m => m.Transaction).Index(4);
            Map(m => m.Instrument).Index(6);
            Map(m => m.NotionalCashPooling).Index(7);
            Map(m => m.SecuritisationAndLoanTransfer).Index(8);
            Map(m => m.TransactionPeriod).Index(9);
            Map(m => m.PurposeOfLoan).Index(12);
            Map(m => m.IntraGroupItem).Index(13);
            Map(m => m.SyndicatedItem).Index(14);
            Map(m => m.Collateral).Index(15);
            Map(m => m.InternalIdentifier).Index(16);
            Map(m => m.Sector).Index(18);
            Map(m => m.CreditInstitutionExemptFromMinimumReserve).Index(19);
            Map(m => m.NameOfCreditInstitutionExemptFromMinimumReserve).Index(20);
            Map(m => m.EcbsAuxiliarySector).Index(21);
            Map(m => m.IndustrialClassification).Index(22);
            Map(m => m.CountryCode).Index(23);
            Map(m => m.CounterpartySector).Index(24);
            Map(m => m.EcbsAuxiliarySectorSecAndLoan).Index(25);
            Map(m => m.CounterpartyHomeCountry).Index(26);
            Map(m => m.ConversionCurrency).Index(30);
            Map(m => m.BookValue).Index(31);
            Map(m => m.BookValueCurrency).Index(32);
            Map(m => m.BookValueExclNonPerformingStock).Index(33);
            Map(m => m.AnnualisedAgreedRate).Index(34);
            Map(m => m.AnnualPercentageRateOfCharge).Index(35);
            Map(m => m.InterestPayable).Index(36);
            Map(m => m.NextInterestRateReset).Index(39);
            Map(m => m.InterestRateLinkage).Index(40);
            Map(m => m.InitialPeriodOfFixation).Index(41);
            Map(m => m.OriginalMaturity).Index(42);
            Map(m => m.RemainingMaturity).Index(43);
            Map(m => m.SizeOfLoan).Index(44);
            Map(m => m.TermOfNotice).Index(45);
            Map(m => m.IndividualLoanLossesAndImpairement).Index(46);
        }
    }
}
