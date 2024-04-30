namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class Header
    {
        public string TypeOfDataProviderIdentifier { get; set; }

        public string DataProviderIdentifier { get; set; }

        public string TypeOfReporterIdentifier { get; set; }

        public string ReporterIdentifier { get; set; }

        public string SurveyCode { get; set; }

        public string Frequency { get; set; }

        public DateTime ReportingPeriodEnd { get; set; }

        public DateTime CreationDate { get; set; }

        public string EntitysComment { get; set; }

        public string ReporterEmail { get; set; }

        public string TypeOfManagementCompanyIdentifier { get; set; }

        public string ManagementCompanyIdentifier { get; set; }

        public string ReporterName { get; set; }
    }
}
