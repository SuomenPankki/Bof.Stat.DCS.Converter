using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.MURA;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Bof.Stat.DCS.Converter.BL
{
    public class MURACsvConverter : CsvConverterBase
    {
        public MURACsvConverter(CsvFile csvFile) : base(csvFile)
        {

        }

        protected override AutoMappingBase GetAutoMapping()
        {
            return new MURAAutoMapping();
        }

        protected override string GetFilename(IXmlReport report)
        {
            return $"{csvFile.Header.ReporterIdentifier}_{csvFile.Header.TypeOfReporterIdentifier}_{csvFile.Header.Frequency}_{csvFile.Survey}_{csvFile.Header.ReportingPeriodEnd.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}_{csvFile.Header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}000.XML";
        }

        protected override List<IXmlReport> GetXmlReports(CsvFile csvFile, IMapper mapper)
        {
            var report = new MuraReport
            {
                SchemaVersion = "1.0",
                Header = mapper.Map<HeaderType>(csvFile.Header)
            };

            if (mapper.Map<BsType>(csvFile.DataRows.OfType<MURA_BS>().SingleOrDefault()) is BsType bs)
            {
                report.BsRecords = new MuraReportBsRecords()
                {
                    Bs = bs
                };
            }

            report.LdRecords = mapper.Map<Collection<LdType>>(csvFile.DataRows.OfType<MURA_LD>().ToList()) is Collection<LdType> ld && ld.Count > 0 ? ld : null;
            report.RestRecords = mapper.Map<Collection<RestType>>(csvFile.DataRows.OfType<MURA_REST>().ToList()) is Collection<RestType> rest && rest.Count > 0 ? rest : null;
            report.SbsRecords = mapper.Map<Collection<SbsType>>(csvFile.DataRows.OfType<MURA_SBS>().ToList()) is Collection<SbsType> sbs && sbs.Count > 0 ? sbs : null;

            return new List<IXmlReport>() { report};
        }
    }
}
