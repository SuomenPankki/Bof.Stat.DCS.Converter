namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class KOTI_CS : IDataRow
    {
        public string TypeOfReporterIdentifier { get; set; }
        public string ReporterIdentifier { get; set; }
        public string AllocationOfBalanceSheetItem { get; set; }
        public string Transaction { get; set; }
        public string Instrument { get; set; }
        public string InternalIdentifier { get; set; }
        public string Sector { get; set; }
        public string CountryCode { get; set; }
        public string GroupUnitCountry { get; set; }
        public string ConversionCurrency { get; set; }
        public string BookValue { get; set; }
        public string BookValueCurrency { get; set; }
        public string RemainingMaturity { get; set; }
        public string TargetCountryOfRiskTransfer { get; set; }
        public string TargetSectorOfRiskTransfer { get; set; }
    }
}
