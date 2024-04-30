using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.KOTI;
using System.Collections.ObjectModel;

namespace Bof.Stat.DCS.Converter.BL
{
    public class KOTICsvConverter : CsvConverterBase
    {
        public KOTICsvConverter(CsvFile csvFile) : base(csvFile)
        {

        }

        protected override AutoMappingBase GetAutoMapping()
        {
            return new KOTIAutoMapping();
        }

        protected override string GetFilename(IXmlReport report) => GetDefaultFilename(report);


        protected override List<IXmlReport> GetXmlReports(CsvFile csvFile, IMapper mapper)
        {
            var report = new KotiReport
            {
                SchemaVersion = "1.0",
                Header = mapper.Map<HeaderType>(csvFile.Header)
            };

            if (mapper.Map<BsType>(csvFile.DataRows.OfType<KOTI_BS>().SingleOrDefault()) is BsType bs)
            {
                report.BsRecords = new KotiReportBsRecords()
                {
                    Bs = bs
                };
            }

            if (mapper.Map<BsiaType>(csvFile.DataRows.OfType<KOTI_BSIA>().SingleOrDefault()) is BsiaType bsia)
            {
                report.BsiaRecords = new KotiReportBsiaRecords()
                {
                    Bsia = bsia
                };
            }
            report.CsRecords = mapper.Map<Collection<CsType>>(csvFile.DataRows.OfType<KOTI_CS>().ToList()) is Collection<CsType> cs && cs.Count > 0 ? cs : null;
            report.CsiaRecords = mapper.Map<Collection<CsiaType>>(csvFile.DataRows.OfType<KOTI_CSIA>().ToList()) is Collection<CsiaType> csia && csia.Count > 0 ? csia : null;
            report.CsdrRecords = mapper.Map<Collection<CsdrType>>(csvFile.DataRows.OfType<KOTI_CSDR>().ToList()) is Collection<CsdrType> csdr && csdr.Count > 0 ? csdr : null;

            return new List<IXmlReport>() { report };
        }
    }
}
