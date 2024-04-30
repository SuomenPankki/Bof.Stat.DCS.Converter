using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Common.Enums;
using Bof.Stat.DCS.Converter.Model;
using Bof.Stat.DCS.Converter.Model.XML;
using NLog;

namespace Bof.Stat.DCS.Converter.BL.Handlers
{
    public class XmlFileHandler<T> : FileHandlerBase
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private XmlFile xmlFile;

        public override FileBase File => xmlFile;

        private readonly SurveyEnum survey;

        public XmlFileHandler(string filename, SurveyEnum survey)
        {
            this.survey = survey;

            Handle(filename);
        }

        protected override void Handle(string filename)
        {
            try
            {
                logger.Info($"Handling XML-file {filename}...");

                xmlFile = new XmlFile(filename, survey)
                {
                    Report = Serialization.DeserializeFromFile<T>(filename) as IXmlReport
                };
            }
            catch (Exception ex)
            {
                logger.Error($"Handling XML-file {filename} failed", ex);
                throw;
            }
        }
    }
}
