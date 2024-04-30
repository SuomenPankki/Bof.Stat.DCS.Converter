namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class RATI_SBS : IDataRow
    {
        public string AllocationOfBalanceSheetItem { get; set; }
        public string Transaction { get; set; }
        public string Instrument { get; set; }
        public string InternalIdentifier { get; set; }
        public string IsinCode { get; set; }
        public bool? CapitalCertainty { get; set; }
        public decimal? NumberOfInstrument { get; set; }
        public decimal? TotalNominalValue { get; set; }
        public string NominalValueCurrency { get; set; }
        public decimal? TotalMarketValueDirtyPrice { get; set; }
        public string MarketValueCurrencyDirtyPrice { get; set; }
        public string AccountingClassification { get; set; }
        public decimal? TotalMarketValueCleanPrice { get; set; }
        public string MarketValueCurrencyCleanPrice { get; set; }
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
    }
}
