using Bof.Stat.DCS.Converter.BL.Converters;
using Bof.Stat.DCS.Converter.Common.Enums;
using Bof.Stat.DCS.Converter.Model;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.XML;
using NLog;

namespace Bof.Stat.DCS.Converter.BL
{
    public static class ConverterFactory
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static IConverter GetConverter(FileBase fileBase)
        {
            try
            {
                if (fileBase is CsvFile csvFile)
                {
                    return csvFile.Survey switch
                    {
                        SurveyEnum.SAVE => new SAVECsvConverter(csvFile),
                        SurveyEnum.MAPE => new MAPECsvConverter(csvFile),
                        SurveyEnum.RATI => new RATICsvConverter(csvFile),
                        SurveyEnum.KOTI or SurveyEnum.KOIA => new KOTICsvConverter(csvFile),
                        SurveyEnum.PEF => new PEFCsvConverter(csvFile),
                        SurveyEnum.TIHA => new TIHACsvConverter(csvFile),
                        SurveyEnum.SIRA => new SIRACsvConverter(csvFile),
                        SurveyEnum.MURA => new MURACsvConverter(csvFile),
                        _ => throw new NotImplementedException($"Conversion of survey {csvFile.Survey} not implemented"),
                    };
                }
                else if (fileBase is XmlFile xmlFile)
                {
                    return xmlFile.Survey switch
                    {
                        SurveyEnum.SAVE => new SAVEXmlConverter(xmlFile),
                        SurveyEnum.KOTI => new KOTIXmlConverter(xmlFile),
                        SurveyEnum.MAPE => new MAPEXmlConverter(xmlFile),
                        SurveyEnum.RATI => new RATIXmlConverter(xmlFile),
                        SurveyEnum.PEF => new PEFXmlConverter(xmlFile),
                        SurveyEnum.TIHA  => new TIHAXmlConverter(xmlFile),
                        SurveyEnum.SIRA => new SIRAXmlConverter(xmlFile),
                        SurveyEnum.MURA => new MURAXmlConverter(xmlFile),
                        _ => throw new NotImplementedException($"Conversion of survey {xmlFile.Survey} not implemented")
                    };
                }
                else
                {
                    throw new NotImplementedException("Converter not implemented");
                }
            }
            catch (Exception ex)
            {
                logger.Error("Error getting converter", ex);
                throw;
            }
        }
    }
}
