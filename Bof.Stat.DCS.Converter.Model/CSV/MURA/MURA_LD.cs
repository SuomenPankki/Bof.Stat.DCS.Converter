namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class MURA_LD : IDataRow
    {
        public string AllocationOfBalanceSheetItem { get; set; }
        public string Transaction { get; set; }
        public string Instrument { get; set; }
        public string SecurisationAndLoanTransfer { get; set; }
        public string TransactionPeriod { get; set; }
        public string PurposeOfLoan { get; set; }
        public string IntraGroupItem { get; set; }
        public string Collateral { get; set; }
        public string InternalIdentifier { get; set; }
        public string Sector { get; set; }
        public string IndustrialClassification { get; set; }
        public string CountryCode { get; set; }
        public string CounterpartySector { get; set; }
        public string CounterpartysHomeCountry { get; set; }
        public string ConversionCurrency { get; set; }
        public decimal BookValue { get; set; }
        public string BookValueCurrency { get; set; }
        public decimal? BookValueExclNonPerformingStock { get; set; }
        public decimal? AnnualisedAgreedRate { get; set; }
        public decimal? AnnualPercentageRateOfCharge { get; set; }
        public decimal? InterestPayable { get; set; }
        public string FirmSize { get; set; }
        public string InterestRateLinkage { get; set; }
        public string InitialPeriodOfFixation { get; set; }
        public string OriginalMaturity { get; set; }
        public decimal? InvidualLoanLossesAndImpairements { get; set; }

    }
}
