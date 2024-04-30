namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class RATI_IL : IDataRow
    {
        public string AllocationOfBalanceSheetItem { get; set; }
        public string Transaction { get; set; }
        public string Instrument { get; set; }
        public string PurposeOfLoan { get; set; }
        public string IntraGroupItem { get; set; }
        public bool? SyndicatedItem { get; set; }
        public string Collateral { get; set; }
        public string InternalIdentifier { get; set; }
        public string Sector { get; set; }
        public string EcbsAuxiliarySector { get; set; }
        public string IndustrialClassification { get; set; }
        public string CountryCode { get; set; }
        public string ConversionCurrency { get; set; }
        public string NextInterestRateReset { get; set; }
        public string InterestRateLinkage { get; set; }
        public string OriginalMaturity { get; set; }
        public string SizeOfLoanToNonFinancialCorporation { get; set; }
        public decimal CollectiveImpairment { get; set; }
    }
}
