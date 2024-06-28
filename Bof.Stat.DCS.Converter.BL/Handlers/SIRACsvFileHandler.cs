using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.CSV.SIRA;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.Mappings.SIRA;
using CsvHelper;

namespace Bof.Stat.DCS.Converter.BL.Handlers
{
    public class SIRACsvFileHandler : CsvFileHandlerBase
    {
        public SIRACsvFileHandler(string filename) : base(filename)
        {

        }

        protected override void Map(CsvReader csvReader)
        {
            csvReader.Context.RegisterClassMap<HeaderMap>();
            csvReader.Context.RegisterClassMap<SIRA_IFMap>();
            csvReader.Context.RegisterClassMap<SIRA_SBSMap>();
            csvReader.Context.RegisterClassMap<SIRA_ITEMMap>();

            while (csvReader.Read())
            {
                switch (csvReader.GetField(0))
                {
                    case "000":
                        csvFile.Header = csvReader.GetRecord<Header>();
                        break;
                    case "IF":
                        var iff = csvReader.GetRecord<SIRA_IF>();
                        csvFile.DataRows.Add(iff);
                        break;
                    case "SBS":
                        var sbs = csvReader.GetRecord<SIRA_SBS>();
                        csvFile.DataRows.Add(sbs);
                        break;
                    case "ITEM":
                        var item = csvReader.GetRecord<SIRA_ITEM>();
                        csvFile.DataRows.Add(item);
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown record type on line index {csvReader.CurrentIndex}");
                }
            }
        }
    }
}
