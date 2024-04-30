namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class SAVE_SBS : IDataRow
    {
        public string TypeOfReporterIdentifier { get; set; }

        public string ReporterIdentifier { get; set; }

        public string Category { get; set; }

        public string ContractType { get; set; }

        public string Instrument { get; set; }

        public string InternalIdentificationCode { get; set; }

        public string IsinCode { get; set; }

        public string InstrumentName { get; set; }

        public decimal? NumberOfInstruments { get; set; }

        public decimal? TotalNominalValue { get; set; }

        public string NominalCurrency { get; set; }

        public decimal? TotalMarketValue { get; set; }

        public string MarketCurrency { get; set; }

        public bool? IntraGroupItem { get; set; }

        public decimal? Dividends { get; set; }

        public string DividendCurrency { get; set; }

        public string ContractingPartysHomeCountry { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? MaturityDate { get; set; }

        public DateTime? NextCouponDate { get; set; }

        public decimal? CouponRate { get; set; }

        public int? CouponFrequency { get; set; }

        public string CountryOfIssue { get; set; }

        public string IssuersSector { get; set; }

        public string IssuersHomeCountry { get; set; }
    }
}
