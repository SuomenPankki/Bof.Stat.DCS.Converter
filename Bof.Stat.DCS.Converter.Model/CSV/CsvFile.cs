using Bof.Stat.DCS.Converter.Common.Enums;

namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class CsvFile : FileBase
    {
        public List<IDataRow> DataRows { get; set; }

        public override SurveyEnum Survey => header is not null && !String.IsNullOrEmpty(header.SurveyCode) ? (SurveyEnum)Enum.Parse(typeof(SurveyEnum), header.SurveyCode) : SurveyEnum.None;

        private Header header;

        public CsvFile(string filename)
        {
            Filename = filename;
            DataRows = new List<IDataRow>();
        }

        public Header Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }
    }
}
