using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.SAVE;
using System.Collections.ObjectModel;

namespace Bof.Stat.DCS.Converter.BL
{
    public class SAVECsvConverter : CsvConverterBase
    {
        public SAVECsvConverter(CsvFile csvFile) : base(csvFile)
        {

        }

        protected override AutoMappingBase GetAutoMapping()
        {
            return new SAVEAutoMapping();
        }

        protected override string GetFilename(IXmlReport report) => GetDefaultFilename(report);

        protected override List<IXmlReport> GetXmlReports(CsvFile csvFile, IMapper mapper)
        {
            var report = new SaveReport
            {
                SchemaVersion = "1.0",
                Header = mapper.Map<HeaderType>(csvFile.Header),
                SbsRecords = mapper.Map<Collection<SbsType>>(csvFile.DataRows)
            };

            return new List<IXmlReport>() { report };
        }
    }
}
