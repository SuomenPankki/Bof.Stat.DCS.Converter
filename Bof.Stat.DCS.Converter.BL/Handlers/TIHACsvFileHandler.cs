using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using CsvHelper;

namespace Bof.Stat.DCS.Converter.BL.Handlers
{
    public class TIHACsvFileHandler : CsvFileHandlerBase
    {
        public TIHACsvFileHandler(string filename) : base(filename)
        {

        }

        protected override void Map(CsvReader csvReader)
        {
            csvReader.Context.RegisterClassMap<HeaderMap>();
            csvReader.Context.RegisterClassMap<TIHA_SBSMap>();

            while (csvReader.Read())
            {
                switch (csvReader.GetField(0))
                {
                    case "000":
                        csvFile.Header = csvReader.GetRecord<Header>();
                        csvFile.Header.ReporterIdentifier = csvFile.Header.DataProviderIdentifier;
                        csvFile.Header.TypeOfReporterIdentifier = csvFile.Header.TypeOfDataProviderIdentifier;
                        break;
                    case "SBS":
                        var sbs = csvReader.GetRecord<TIHA_SBS>();
                        csvFile.DataRows.Add(sbs);
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown record type on line index {csvReader.CurrentIndex}");
                }
            }
        }
    }
}
