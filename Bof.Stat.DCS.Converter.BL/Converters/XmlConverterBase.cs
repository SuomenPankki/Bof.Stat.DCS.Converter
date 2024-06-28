using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model;
using Bof.Stat.DCS.Converter.Model.XML;
using NLog;
using NLog.LayoutRenderers.Wrappers;
using System.Globalization;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public abstract class XmlConverterBase : IConverter
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        protected abstract string GetReport();

        protected readonly XmlFile xmlFile;

        public abstract string GetFilename();


        public XmlConverterBase(XmlFile xmlFile)
        {
            this.xmlFile = xmlFile;
        }

        public List<ConversionResult> Convert()
        {
            try
            {
                logger.Info($"Converting file {xmlFile.Filename}...");

                var report = GetReport();
             

                return new List<ConversionResult>()
                {
                    new ConversionResult()
                    {
                        
                        Filename = GetFilename(),
                        FileContent = report
                    }
                };
            }
            catch (Exception ex)
            {
                logger.Error($"Conversion of file {xmlFile.Filename} failed", ex);
                throw;
            }
        }

        protected string GetTimeStampFromFilename()
        {
            var list = xmlFile.Filename.ToUpper().Replace(".XML", "").Split('_').ToList();
            var ts = list[list.Count - 1];

            if (DateTime.TryParseExact(ts, "yyyyMMddHHmmssfff", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                return ts;
            }
            else
            {
                return DateTime.Now.ToString("yyyyMMddHHmmssfff", CultureInfo.InvariantCulture);
            }
        }

        protected string GetDefaultFilename()
        {
            var ts = GetTimeStampFromFilename();

            return $"{xmlFile.Survey}_{xmlFile.Report.ReportPeriodEnd.DateToPeriod(xmlFile.Report.Frequency)}_{xmlFile.Report.ReporterIdentifier}_{xmlFile.Report.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}_{ts}.CSV";
        }

        protected string GetFilenameWithProvider()
        {
            var ts = GetTimeStampFromFilename();

            return $"{xmlFile.Survey}_{xmlFile.Report.ReportPeriodEnd.DateToPeriod(xmlFile.Report.Frequency)}_{xmlFile.Report.DataProviderIdentifier}_{xmlFile.Report.ReporterIdentifier}_{xmlFile.Report.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}_{ts}.CSV";
        }
    }
}
