namespace Bof.Stat.DCS.Converter.Model.CSV.SIRA
{
    public class SIRA_ITEM : IDataRow
    {

        public string ReporterIdentifier { get; set; }
        public string TypeOfReporterIdentifier { get; set; }

        public string Category { get; set; }
        public string Instrument { get; set; }
        public string Collateral { get; set; }
        public string InternalIdentificationCode { get; set; }
        public string NominalValueCurrency { get; set; }
        public decimal? TotalValue { get; set; }
        public string CurrencyOfValue { get; set; }
        public string TypeOfCounterpartysIdentifier { get; set; }
        public string CounterpartysIdentifier { get; set; }
        public string CounterpartysName { get; set; }
        public string CounterpartysSector { get; set; }
        public string CounterpartysHomeCountry { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? MaturityDate { get; set; }



    }
}
