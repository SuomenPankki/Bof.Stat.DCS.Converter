using Bof.Stat.DCS.Converter.Model.CSV;

namespace Bof.Stat.DCS.Converter.Model.XML.SAVE
{
    public partial class SaveReport : IXmlReport
    {
        public string ReporterIdentifier => Header.ReporterIdentifier;

        public string DataProviderIdentifier => Header.DataProviderIdentifier;

        public DateTime CreationDate => Header.CreationDate;

        public DateTime ReportPeriodEnd => Header.ReportingPeriodEnd;

        public string Frequency => Header.Frequency;

        public int RowCount => SbsRecords.Count + 1;
    }
}

namespace Bof.Stat.DCS.Converter.Model.XML.MAPE
{
    public partial class MapeReport : IXmlReport
    {
        public string ReporterIdentifier => Header.ReporterIdentifier;

        public string DataProviderIdentifier => Header.DataProviderIdentifier;

        public DateTime CreationDate => Header.CreationDate;

        public DateTime ReportPeriodEnd => Header.ReportingPeriodEnd;

        public string Frequency => Header.Frequency;

        public int RowCount => AccoRecords.Count + ApayRecords.Count + CardRecords.Count + HpayRecords.Count + QpayRecords.Count + ServRecords.Count + TermRecords.Count + 1;
    }
}

namespace Bof.Stat.DCS.Converter.Model.XML.KOTI
{
    public partial class KotiReport : IXmlReport
    {
        public string ReporterIdentifier => Header.ReporterIdentifier;

        public string DataProviderIdentifier => Header.DataProviderIdentifier;

        public DateTime CreationDate => Header.CreationDate;

        public DateTime ReportPeriodEnd => Header.ReportingPeriodEnd;

        public string Frequency => Header.Frequency;

        public int RowCount => CsRecords.Count + CsiaRecords.Count + CsdrRecords.Count + (BsRecords is not null ? 1 : 0) + (BsiaRecords is not null ? 1 : 0) + 1;
    }
}

namespace Bof.Stat.DCS.Converter.Model.XML.RATI
{
    public partial class RatiReport : IXmlReport
    {
        public string ReporterIdentifier => Header.ReporterIdentifier;

        public string DataProviderIdentifier => Header.DataProviderIdentifier;

        public DateTime CreationDate => Header.CreationDate;

        public DateTime ReportPeriodEnd => Header.ReportingPeriodEnd;

        public string Frequency => Header.Frequency;

        public int RowCount => IlRecords.Count + LdRecords.Count + RestRecords.Count + SbsRecords.Count + (BsRecords is not null ? 1 : 0) + 1;
    }
}

namespace Bof.Stat.DCS.Converter.Model.XML.PEF
{
    public partial class PefReport : IXmlReport
    {
        public string ReporterIdentifier => Header.ReporterIdentifier;

        public string DataProviderIdentifier => Header.ManagementCompanyIdentifier;

        public DateTime CreationDate => Header.CreationDate;

        public DateTime ReportPeriodEnd => Header.ReportingPeriodEnd;

        public string Frequency => Header.Frequency;

        public int RowCount => PefRecords.Count + 1 + 1;
    }
}

namespace Bof.Stat.DCS.Converter.Model.XML.TIHA
{
    public partial class TihaReport : IXmlReport
    {
        public string ReporterIdentifier => Header.ReporterIdentifier;

        public string DataProviderIdentifier => Header.DataProviderIdentifier;

        public DateTime CreationDate => Header.CreationDate;

        public DateTime ReportPeriodEnd => Header.ReportingPeriodEnd;

        public string Frequency => Header.Frequency;

        public int RowCount => SbsRecords.Count + 1;
    }
}

namespace Bof.Stat.DCS.Converter.Model.XML.MURA
{
    public partial class MuraReport : IXmlReport
    {
        public string ReporterIdentifier => Header.ReporterIdentifier;

        public string DataProviderIdentifier => Header.DataProviderIdentifier;

        public DateTime CreationDate => Header.CreationDate;

        public DateTime ReportPeriodEnd => Header.ReportingPeriodEnd;

        public string Frequency => Header.Frequency;

        public int RowCount => LdRecords.Count + RestRecords.Count + SbsRecords.Count + (BsRecords is not null ? 1 : 0) + 1;
    }
}

    namespace Bof.Stat.DCS.Converter.Model.XML.SIRA
    {
        public partial class SiraReport : IXmlReport
        {
            public string ReporterIdentifier => Header.ReporterIdentifier;

            public string DataProviderIdentifier => Header.ManagementCompanyIdentifier;

            public DateTime CreationDate => Header.CreationDate;

            public DateTime ReportPeriodEnd => Header.ReportingPeriodEnd;

            public string Frequency => Header.Frequency;

            public int RowCount => ItemRecords.Count + SbsRecords.Count + 1 + 1;
        }
    }