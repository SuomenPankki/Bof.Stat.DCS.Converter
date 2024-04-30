using Bof.Stat.DCS.Converter.Common.Enums;

namespace Bof.Stat.DCS.Converter.Model
{
    public abstract class FileBase
    {
        public abstract SurveyEnum Survey { get; }

        public string Filename { get; protected set; }
    }
}
