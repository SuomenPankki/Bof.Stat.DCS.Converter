namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class RATI_BS : IDataRow
    {
        public string TypeOfReporterIdentifier { get; set; }
        public string ReporterIdentifier { get; set; }
        public string ReportingFrequency { get; set; }
        public string ReportersName { get; set; }
        public int? NumberOfHousingLoanCustomersHouseholds { get; set; }
        public int? NumberOfOffices { get; set; }
        public int? NumberOfEmployees { get; set; }
        public double? BalanceSheetTotal { get; set; }
    }
}
