namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class KOTI_CSIA : IDataRow
    {
        public string TypeOfReporterIdentifier { get; set; }
        public string ReporterIdentifier { get; set; }
        public string AllocationOfBalanceSheetItem { get; set; }
        public string Transaction { get; set; }
        public string BisUnit { get; set; }
        public string Instrument { get; set; }
        public string InternalIdentificationCode { get; set; }
        public string Sector { get; set; }
        public string CountryCode { get; set; }
        public string HomeCountryOfGroupEntityCountyCode { get; set; }
        public string ConversionCurrency { get; set; }
        public decimal? BookValue { get; set; }
        public string BookValueCurrency { get; set; }
        public string RemainingMaturity { get; set; }
        public string TargetCountryOfRiskTransfer { get; set; }
        public string TargetSectorOfRiskTransfer { get; set; }
        public string CollateralType { get; set; }
        public string DebtSecurityType { get; set; }
        public string AccountingClassification { get; set; }
        public string TypeOfEquityInvestment { get; set; }
        public bool? Subordination { get; set; }
        public string InsuranceAssetType { get; set; }
        public string InsurancePolicyType { get; set; }
        public string EquityType { get; set; }
    }
}
