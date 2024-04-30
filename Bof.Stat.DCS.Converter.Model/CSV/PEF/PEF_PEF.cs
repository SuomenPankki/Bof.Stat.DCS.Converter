namespace Bof.Stat.DCS.Converter.Model.CSV.PEF
{
    public class PEF_PEF : IDataRow
    {
        public string ReporterIdentifier { get; set; }
        public string TypeOfReporterIdentifier { get; set; }
        public string Category { get; set; }
        public string ContractType { get; set; }
        public string Instrument { get; set; }
        public string InternalIdentificationCode { get; set; }
        public string IsinCode { get; set; }
        public decimal? NumberOfInstruments { get; set; }
        public decimal? TotalNominalValue { get; set; }
        public string NominalValueCurrency { get; set; }
        public decimal? TotalMarketValueDirty { get; set; }
        public decimal? TotalMarketValueClean { get; set; }
        public decimal? CapitalFlows { get; set; }
        public decimal? LoanLosses { get; set; }
        public string TypeOfCounterpartysIdentifier { get; set; }
        public string CounterpartysIdentifier { get; set; }
        public string CounterpartysName { get; set; }
        public string CounterpartysSector { get; set; }
        public string CounterpartysHomeCountry { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public string TypeOfIssuersIdentifier { get; set; }
        public string IssuersIdentifier { get; set; }
        public string IssuersName { get; set; }
        public string IssuersSector { get; set; }
        public string IssuersHomeCountry { get; set; }
    }
}
