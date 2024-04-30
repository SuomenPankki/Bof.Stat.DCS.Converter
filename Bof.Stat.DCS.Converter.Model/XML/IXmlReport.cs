namespace Bof.Stat.DCS.Converter.Model.XML
{
    public interface IXmlReport
    {
        public string ReporterIdentifier { get; }

        public string DataProviderIdentifier { get; }

        public DateTime CreationDate { get; }

        public DateTime ReportPeriodEnd { get; }

        public string Frequency { get; }

        public int RowCount { get; }
    }
}
