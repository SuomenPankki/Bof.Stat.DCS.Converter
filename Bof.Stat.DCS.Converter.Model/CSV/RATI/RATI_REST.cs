namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class RATI_REST : IDataRow
    {
        public string AllocationOfBalanceSheetItem { get; set; }
        public string Transaction { get; set; }
        public string Instrument { get; set; }
        public string IntraGroupItem { get; set; }
        public string InternalIdentifier { get; set; }
        public string Sector { get; set; }
        public string CountryCode { get; set; }
        public string ConversionCurrency { get; set; }
        public decimal? BookValue { get; set; }
        public string BookValueCurrency { get; set; }
    }
}
