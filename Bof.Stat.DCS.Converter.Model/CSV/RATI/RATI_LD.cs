namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class RATI_LD : IDataRow
    {
        public string AllocationOfBalanceSheetItem { get; set; }
        public string Transaction { get; set; }
        public string Instrument { get; set; }
        public bool? NotionalCashPooling { get; set; }
        public string SecuritisationAndLoanTransfer { get; set; }
        public string TransactionPeriod { get; set; }
        public string PurposeOfLoan { get; set; }
        public string IntraGroupItem { get; set; }
        public bool? SyndicatedItem { get; set; }
        public string Collateral { get; set; }
        public string InternalIdentifier { get; set; }
        public string Sector { get; set; }
        public string CreditInstitutionExemptFromMinimumReserve { get; set; }
        public string NameOfCreditInstitutionExemptFromMinimumReserve { get; set; }
        public string EcbsAuxiliarySector { get; set; }
        public string IndustrialClassification { get; set; }
        public string CountryCode { get; set; }
        public string CounterpartySector { get; set; }
        public string EcbsAuxiliarySectorSecAndLoan { get; set; }
        public string CounterpartyHomeCountry { get; set; }
        public string ConversionCurrency { get; set; }
        public decimal? BookValue { get; set; }
        public string BookValueCurrency { get; set; }
        public decimal? BookValueExclNonPerformingStock { get; set; }
        public decimal? AnnualisedAgreedRate { get; set; }
        public decimal? AnnualPercentageRateOfCharge { get; set; }
        public decimal? InterestPayable { get; set; }
        public string NextInterestRateReset { get; set; }
        public string InterestRateLinkage { get; set; }
        public string InitialPeriodOfFixation { get; set; }
        public string OriginalMaturity { get; set; }
        public string RemainingMaturity { get; set; }
        public string SizeOfLoan { get; set; }
        public string TermOfNotice { get; set; }
        public decimal? IndividualLoanLossesAndImpairement { get; set; }
    }
}
