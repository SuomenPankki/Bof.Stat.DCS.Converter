using Bof.Stat.DCS.Converter.Common.Enums;

namespace Bof.Stat.DCS.Converter.Model.XML
{
    public class XmlFile : FileBase
    {
        public IXmlReport Report { get; set; }
        private readonly SurveyEnum survey;

        public override SurveyEnum Survey => survey;

        public XmlFile(string filename, SurveyEnum survey)
        {
            this.survey = survey;
            Filename = filename;
        }
    }
}
