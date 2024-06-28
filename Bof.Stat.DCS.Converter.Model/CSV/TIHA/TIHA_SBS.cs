namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class TIHA_SBS : IDataRow
    {

        public string TypeOfReporterIdentifier { get; set; }
        public string ReporterIdentifier { get; set; }

        public string Instrument { get; set; }
        public string InternalIdentificationCode { get; set; }
        public string IsinCode { get; set; }
        public string InstrumentsName { get; set; }
        public decimal? NumberOfInstruments { get; set; }
        public decimal? TotalNominalValue { get; set; }
        public string NominalCurrency { get; set; }
        public decimal TotalMarketValue { get; set; }
        public string MarketCurrency { get; set; }
        public decimal? Dividends { get; set; }
        public string DividendCurrency { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public DateTime? NextCouponDate { get; set; }
        public decimal? CouponRate { get; set; }
        public int? CouponFrequency { get; set; }
        public string IssuersSector { get; set; }
        public string IssuersHomeCountry { get; set; }
        public string TypeOfHoldersIdentifier { get; set; }
        public string HoldersIdentifier { get; set; }
        public string HoldersName { get; set; }
        public string HoldersSector { get; set; }
        public string HoldersHomeTaxationCountry { get; set; }

    }
}
