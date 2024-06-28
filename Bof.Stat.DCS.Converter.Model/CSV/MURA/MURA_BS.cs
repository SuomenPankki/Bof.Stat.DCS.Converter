namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class MURA_BS : IDataRow
    {
        public string TypeOfReporterIdentifier { get; set; }
        public string ReporterIdentifier { get; set; }
        public string ReportingFrequency { get; set; }
        public string ReportersName { get; set; }
        public decimal TotalAssets { get; set; }

    }
}
