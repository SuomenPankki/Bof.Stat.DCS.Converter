using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.CSV.PEF;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.Mappings.PEF;
using CsvHelper;

namespace Bof.Stat.DCS.Converter.BL.Handlers
{
    public class PEFCsvFileHandler : CsvFileHandlerBase
    {
        public PEFCsvFileHandler(string filename) : base(filename)
        {

        }

        protected override void Map(CsvReader csvReader)
        {
            csvReader.Context.RegisterClassMap<HeaderMap>();
            csvReader.Context.RegisterClassMap<PEF_IFMap>();
            csvReader.Context.RegisterClassMap<PEF_PEFMap>();

            while (csvReader.Read())
            {
                switch (csvReader.GetField(0))
                {
                    case "000":
                        csvFile.Header = csvReader.GetRecord<Header>();
                        break;
                    case "IF":
                        var iff = csvReader.GetRecord<PEF_IF>();
                        csvFile.DataRows.Add(iff);
                        break;
                    case "PEF":
                        var pef = csvReader.GetRecord<PEF_PEF>();
                        csvFile.DataRows.Add(pef);
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown record type on line index {csvReader.CurrentIndex}");
                }
            }
        }
    }
}
