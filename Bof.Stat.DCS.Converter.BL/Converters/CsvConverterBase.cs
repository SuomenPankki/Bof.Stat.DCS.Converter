using AutoMapper;
using Bof.Stat.DCS.Converter.BL.Converters;
using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.XML;
using NLog;
using System.Globalization;

namespace Bof.Stat.DCS.Converter.BL
{
    public abstract class CsvConverterBase : IConverter
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        protected abstract List<IXmlReport> GetXmlReports(CsvFile csvFile, IMapper mapper);

        protected abstract AutoMappingBase GetAutoMapping();

        protected abstract string GetFilename(IXmlReport report);

        protected readonly CsvFile csvFile;

        public CsvConverterBase(CsvFile csvFile)
        {
            this.csvFile = csvFile;
        }

        public List<ConversionResult> Convert()
        {
            try
            {
                logger.Info($"Converting file {csvFile.Filename}...");

                var configuration = GetAutoMapping().GetMapperConfigurations();
                var mapper = configuration.CreateMapper();

                var reports = GetXmlReports(csvFile, mapper);
                var results = new List<ConversionResult>();

                foreach (var report in reports)
                {
                    results.Add(new ConversionResult()
                    {
                        FileContent = Serialization.Serialize(report),
                        Filename = GetFilename(report)
                    });
                }

                return results;
            }
            catch (Exception ex)
            {
                logger.Error($"Conversion of file {csvFile.Filename} failed", ex);
                throw;
            }
        }

        public string GetDefaultFilename(IXmlReport report)
        {
            return $"{csvFile.Header.ReporterIdentifier}_{csvFile.Header.TypeOfReporterIdentifier}_{csvFile.Header.Frequency}_{csvFile.Survey}_{csvFile.Header.ReportingPeriodEnd.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}_{csvFile.Header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}000.XML";
        }
    }
}
