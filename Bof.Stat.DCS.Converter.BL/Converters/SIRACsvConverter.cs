using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.CSV.SIRA;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.Mappings.SIRA;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.SIRA;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Bof.Stat.DCS.Converter.BL
{
    public class SIRACsvConverter : CsvConverterBase
    {
        public SIRACsvConverter(CsvFile csvFile) : base(csvFile)
        {

        }

        protected override AutoMappingBase GetAutoMapping()
        {
            return new SIRAAutoMapping();
        }

        protected override string GetFilename(IXmlReport report)
        {
            return $"{report.ReporterIdentifier}_FSAFUNDID_{csvFile.Header.Frequency}_{csvFile.Survey}_{csvFile.Header.ReportingPeriodEnd.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}_{csvFile.Header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}000.XML";
        }

        protected override List<IXmlReport> GetXmlReports(CsvFile csvFile, IMapper mapper)
        {
            var funds = csvFile.DataRows.OfType<SIRA_IF>().Select(x => new { x.TypeOfReporterIdentifier, x.ReporterIdentifier, x.ReporterName }).ToList();
            var reports = new List<IXmlReport>();

            if (funds.Count < 1) throw new ArgumentException("No IF-records found from the file");

            foreach (var fund in funds)
            {
                var report = new SiraReport
                {
                    SchemaVersion = "1.0",
                    Header = mapper.Map<HeaderType>(csvFile.Header)
                };

                report.Header.TypeOfReporterIdentifier = fund.TypeOfReporterIdentifier;
                report.Header.ReporterIdentifier = fund.ReporterIdentifier;
                report.Header.ReporterName = fund.ReporterName;
                report.Header.EntitysComment = csvFile.Header.EntitysComment;

                if (mapper.Map<IfType>(csvFile.DataRows.OfType<SIRA_IF>().Where(x => x.ReporterIdentifier == fund.ReporterIdentifier).SingleOrDefault()) is IfType iffi)
                {
                    report.IfRecords = new SiraReportIfRecords()
                    {
                        If = iffi
                    };
                }

                report.SbsRecords = mapper.Map<Collection<SbsType>>(csvFile.DataRows.OfType<SIRA_SBS>().Where(x => x.ReporterIdentifier == fund.ReporterIdentifier).ToList()) is Collection<SbsType> sbs && sbs.Count > 0 ? sbs : null;
                report.ItemRecords = mapper.Map<Collection<ItemType>>(csvFile.DataRows.OfType<SIRA_ITEM>().Where(x => x.ReporterIdentifier == fund.ReporterIdentifier).ToList()) is Collection<ItemType> item && item.Count > 0 ? item : null;
                
                reports.Add(report);
            }

            return reports;
        }
    }
}
