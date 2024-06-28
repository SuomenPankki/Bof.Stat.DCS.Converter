using Bof.Stat.DCS.Converter.Common.Enums;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using CsvHelper;

namespace Bof.Stat.DCS.Converter.BL.Handlers
{
    public class MURACsvFileHandler : CsvFileHandlerBase
    {
        public MURACsvFileHandler(string filename) : base(filename)
        {

        }

        protected override void Map(CsvReader csvReader)
        {
            csvReader.Context.RegisterClassMap<HeaderMap>();
            csvReader.Context.RegisterClassMap<MURA_BSMap>();
            csvReader.Context.RegisterClassMap<MURA_LDMap>();
            csvReader.Context.RegisterClassMap<MURA_RESTMap>();
            csvReader.Context.RegisterClassMap<MURA_SBSMap>();

            while (csvReader.Read())
            {
                switch (csvReader.GetField(0))
                {
                    case "000":
                        csvFile.Header = csvReader.GetRecord<Header>();
                        csvFile.Header.SurveyCode = SurveyEnum.MURA.ToString();
                        break;
                    case "BS":
                        var bs = csvReader.GetRecord<MURA_BS>();
                        csvFile.DataRows.Add(bs);
                        csvFile.Header.ReporterIdentifier = bs.ReporterIdentifier;
                        csvFile.Header.TypeOfReporterIdentifier = bs.TypeOfReporterIdentifier;
                        break;
                    case "LD":
                        var ld = csvReader.GetRecord<MURA_LD>();
                        csvFile.DataRows.Add(ld);
                        break;
                    case "REST":
                        var rest = csvReader.GetRecord<MURA_REST>();
                        csvFile.DataRows.Add(rest);
                        break;
                    case "SBS":
                        var sbs = csvReader.GetRecord<MURA_SBS>();
                        csvFile.DataRows.Add(sbs);
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown record type on line index {csvReader.CurrentIndex}");
                }
            }
        }
    }
}
