using Bof.Stat.DCS.Converter.Common.Enums;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using CsvHelper;

namespace Bof.Stat.DCS.Converter.BL.Handlers
{
    public class RATICsvFileHandler : CsvFileHandlerBase
    {
        public RATICsvFileHandler(string filename) : base(filename)
        {

        }

        protected override void Map(CsvReader csvReader)
        {
            csvReader.Context.RegisterClassMap<HeaderMap>();
            csvReader.Context.RegisterClassMap<RATI_BSMap>();
            csvReader.Context.RegisterClassMap<RATI_LDMap>();
            csvReader.Context.RegisterClassMap<RATI_ILMap>();
            csvReader.Context.RegisterClassMap<RATI_RESTMap>();
            csvReader.Context.RegisterClassMap<RATI_SBSMap>();

            while (csvReader.Read())
            {
                switch (csvReader.GetField(0))
                {
                    case "000":
                        csvFile.Header = csvReader.GetRecord<Header>();
                        csvFile.Header.SurveyCode = SurveyEnum.RATI.ToString();
                        break;
                    case "BS":
                        var bs = csvReader.GetRecord<RATI_BS>();
                        csvFile.DataRows.Add(bs);
                        csvFile.Header.ReporterIdentifier = bs.ReporterIdentifier;
                        csvFile.Header.TypeOfReporterIdentifier = bs.TypeOfReporterIdentifier;
                        break;
                    case "IL":
                        var il = csvReader.GetRecord<RATI_IL>();
                        csvFile.DataRows.Add(il);
                        break;
                    case "LD":
                        var ld = csvReader.GetRecord<RATI_LD>();
                        csvFile.DataRows.Add(ld);
                        break;
                    case "REST":
                        var rest = csvReader.GetRecord<RATI_REST>();
                        csvFile.DataRows.Add(rest);
                        break;
                    case "SBS":
                        var sbs = csvReader.GetRecord<RATI_SBS>();
                        csvFile.DataRows.Add(sbs);
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown record type on line index {csvReader.CurrentIndex}");
                }
            }
        }
    }
}
