using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.CSV.PEF;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.Mappings.PEF;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.PEF;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Bof.Stat.DCS.Converter.BL
{
    public class PEFCsvConverter : CsvConverterBase
    {
        public PEFCsvConverter(CsvFile csvFile) : base(csvFile)
        {

        }

        protected override AutoMappingBase GetAutoMapping()
        {
            return new PEFAutoMapping();
        }

        protected override string GetFilename(IXmlReport report)
        {
            return $"{report.ReporterIdentifier}_FSAFUNDID_{csvFile.Header.Frequency}_{csvFile.Survey}_{csvFile.Header.ReportingPeriodEnd.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}_{csvFile.Header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}000.XML";
        }

        protected override List<IXmlReport> GetXmlReports(CsvFile csvFile, IMapper mapper)
        {
            var funds = csvFile.DataRows.OfType<PEF_IF>().Select(x => new { x.ReporterIdentifier, x.ReporterName }).ToList();
            var reports = new List<IXmlReport>();

            foreach (var fund in funds)
            {
                var report = new PefReport
                {
                    SchemaVersion = "1.0",

                    Header = mapper.Map<HeaderType>(csvFile.Header)
                };

                report.Header.ReporterIdentifier = fund.ReporterIdentifier;
                report.Header.ReporterName = fund.ReporterName;
                report.Header.EntitysComment = csvFile.Header.EntitysComment;

                if (mapper.Map<IfType>(csvFile.DataRows.OfType<PEF_IF>().Where(x => x.ReporterIdentifier == fund.ReporterIdentifier).SingleOrDefault()) is IfType iffi)
                {
                    report.IfRecords = new PefReportIfRecords()
                    {
                        If = iffi
                    };
                }

                report.PefRecords = mapper.Map<Collection<PefType>>(csvFile.DataRows.OfType<PEF_PEF>().Where(x => x.ReporterIdentifier == fund.ReporterIdentifier).ToList()) is Collection<PefType> pef && pef.Count > 0 ? pef : null;
                reports.Add(report);
            }

            return reports;
        }
    }
}
