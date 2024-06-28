using Bof.Stat.DCS.Converter.BL.Handlers;
using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Common.Enums;
using Bof.Stat.DCS.Converter.Model.XML.KOTI;
using Bof.Stat.DCS.Converter.Model.XML.MAPE;
using Bof.Stat.DCS.Converter.Model.XML.RATI;
using Bof.Stat.DCS.Converter.Model.XML.SAVE;
using Bof.Stat.DCS.Converter.Model.XML.PEF;
using Bof.Stat.DCS.Converter.Model.XML.TIHA;
using Bof.Stat.DCS.Converter.Model.XML.SIRA;
using Bof.Stat.DCS.Converter.Model.XML.MURA;
using NLog;
using System.Xml.Linq;

namespace Bof.Stat.DCS.Converter.BL
{
    public static class FileHandlerFactory
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static FileHandlerBase GetFileHandler(string filename)
        {
            try
            {
                if (!File.Exists(filename)) throw new FileNotFoundException($"File not found", filename);

                else if (Path.GetExtension(filename).ToLower() == ".csv")
                {
                    var survey = GetSurvey(filename);

                    return survey switch
                    {
                        SurveyEnum.MAPE => new MAPECsvFileHandler(filename),
                        SurveyEnum.KOTI or SurveyEnum.KOIA => new KOTICsvFileHandler(filename),
                        SurveyEnum.SAVE => new SAVECsvFileHandler(filename),
                        SurveyEnum.RATI => new RATICsvFileHandler(filename),
                        SurveyEnum.PEF => new PEFCsvFileHandler(filename),
                        SurveyEnum.TIHA => new TIHACsvFileHandler(filename),
                        SurveyEnum.SIRA => new SIRACsvFileHandler(filename),
                        SurveyEnum.MURA => new MURACsvFileHandler(filename),
                        _ => throw new NotImplementedException($"CSV filehandler not implemented for survey {survey}"),
                    };
                }
                else if (Path.GetExtension(filename).ToLower() == ".xml")
                {
                    var doc = XDocument.Load(filename);
                    var ns = doc.Root?.GetDefaultNamespace();

                    return (ns?.NamespaceName) switch
                    {
                        Namespaces.MAPE => new XmlFileHandler<MapeReport>(filename, SurveyEnum.MAPE),
                        Namespaces.KOTI => new XmlFileHandler<KotiReport>(filename, SurveyEnum.KOTI),
                        Namespaces.RATI => new XmlFileHandler<RatiReport>(filename, SurveyEnum.RATI),
                        Namespaces.SAVE => new XmlFileHandler<SaveReport>(filename, SurveyEnum.SAVE),
                        Namespaces.PEF => new XmlFileHandler<PefReport>(filename, SurveyEnum.PEF),
                        Namespaces.TIHA => new XmlFileHandler<TihaReport>(filename, SurveyEnum.TIHA),
                        Namespaces.SIRA => new XmlFileHandler<SiraReport>(filename, SurveyEnum.SIRA),
                        Namespaces.MURA => new XmlFileHandler<MuraReport>(filename, SurveyEnum.MURA),
                        _ => throw new NotImplementedException($"XML filehandler not implemented for namespace {ns.NamespaceName}"),
                    };
                }
                else
                {
                    throw new ArgumentException("Invalid file extension");
                }
            }
            catch (Exception ex)
            {
                logger.Error("Error getting filehandler", ex);
                throw;
            }
        }

        private static SurveyEnum GetSurvey(string filename)
        {
            try
            {
                if (Path.GetFileName(filename).Contains(SurveyEnum.MAPE.ToString()))
                {
                    return (SurveyEnum)Enum.Parse(typeof(SurveyEnum), File.ReadLines(filename).First().Split(";")[5].Replace("\"", ""));
                }
                else return (SurveyEnum)Enum.Parse(typeof(SurveyEnum), File.ReadLines(filename).First().Split(";")[3].Replace("\"", ""));
            }
            catch (Exception ex)
            {
                logger.Error("Error detecting survey from csv header", ex);
                throw;
            }
        }
    }
}
