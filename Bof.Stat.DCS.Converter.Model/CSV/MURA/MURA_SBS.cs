namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class MURA_SBS : IDataRow
    {
        public string AllocationOfBalanceSheetItem { get; set; }
        public string Transaction { get; set; }
        public string Instrument { get; set; }
        public string InternalIdentifier { get; set; }
        public string IsinCode { get; set; }
        public decimal? NumberOfInstrument { get; set; }
        public decimal? TotalNominalValue { get; set; }
        public string NominalValueCurrency { get; set; }
        public decimal? TotalMarketValueDirty { get; set; }
        public string MarketCurrencyDirty { get; set; }
        public decimal? TotalMarketValueClean { get; set; }
        public string MarketCurrencyClean { get; set; }
        public string IntraGroupItem { get; set; }
        public bool? DirectInvestment { get; set; }
        public decimal? Dividend { get; set; }
        public string DividendCurrency { get; set; }
        public string CounterpartysSector { get; set; }
        public string CounterpartysHomeCountry { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public string CountryOfIssue { get; set; }
        public string TypeOfIssuersIdentifier { get; set; }
        public string IssuersIdentifier { get; set; }
        public string IssuersName { get; set; }
        public string IssuersSector { get; set; }
        public string IssuersHomeCountry { get; set; }
        public string ReportersName { get; set; }
        public string TotalAssets { get; set; }

    }
}
