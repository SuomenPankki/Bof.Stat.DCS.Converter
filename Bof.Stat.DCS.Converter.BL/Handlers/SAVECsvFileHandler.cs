using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using CsvHelper;

namespace Bof.Stat.DCS.Converter.BL.Handlers
{
    public class SAVECsvFileHandler : CsvFileHandlerBase
    {
        public SAVECsvFileHandler(string filename) : base(filename)
        {

        }

        protected override void Map(CsvReader csvReader)
        {
            csvReader.Context.RegisterClassMap<HeaderMap>();
            csvReader.Context.RegisterClassMap<SAVE_SBSMap>();

            while (csvReader.Read())
            {
                switch (csvReader.GetField(0))
                {
                    case "000":
                        csvFile.Header = csvReader.GetRecord<Header>();
                        break;
                    case "SBS":
                        var sbs = csvReader.GetRecord<SAVE_SBS>();
                        csvFile.DataRows.Add(sbs);
                        csvFile.Header.ReporterIdentifier = sbs.ReporterIdentifier;
                        csvFile.Header.TypeOfReporterIdentifier = sbs.TypeOfReporterIdentifier;
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown record type on line index {csvReader.CurrentIndex}");
                }
            }
        }
    }
}
