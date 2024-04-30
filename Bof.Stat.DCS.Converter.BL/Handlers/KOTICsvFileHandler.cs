using Bof.Stat.DCS.Converter.Common.Enums;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using CsvHelper;
using System.Runtime.InteropServices.ComTypes;

namespace Bof.Stat.DCS.Converter.BL.Handlers
{
    public class KOTICsvFileHandler : CsvFileHandlerBase
    {
        public KOTICsvFileHandler(string filename) : base(filename)
        {

        }

        protected override void Map(CsvReader csvReader)
        {
            csvReader.Context.RegisterClassMap<HeaderMap>();
            csvReader.Context.RegisterClassMap<KOTI_BSMap>();
            csvReader.Context.RegisterClassMap<KOTI_BSIAMap>();
            csvReader.Context.RegisterClassMap<KOTI_CSMap>();
            csvReader.Context.RegisterClassMap<KOTI_CSIAMap>();
            csvReader.Context.RegisterClassMap<KOTI_CSDRMap>();

            while (csvReader.Read())
            {
                switch (csvReader.GetField(0))
                {
                    case "000":
                        csvFile.Header = csvReader.GetRecord<Header>();
                        break;
                    case "BS":
                        if (csvFile.Header.SurveyCode == SurveyEnum.KOIA.ToString())
                        {
                            var bsia = csvReader.GetRecord<KOTI_BSIA>();
                            csvFile.DataRows.Add(bsia);
                            break;
                        }
                        else
                        {
                            var bs = csvReader.GetRecord<KOTI_BS>();
                            csvFile.DataRows.Add(bs);
                            break;
                        }
                    case "BSIA":
                        var bsia2 = csvReader.GetRecord<KOTI_BSIA>();
                        csvFile.DataRows.Add(bsia2);
                        break;
                    case "CS":
                        var cs = csvReader.GetRecord<KOTI_CS>();
                        csvFile.DataRows.Add(cs);
                        csvFile.Header.ReporterIdentifier = cs.ReporterIdentifier;
                        csvFile.Header.TypeOfReporterIdentifier = cs.TypeOfReporterIdentifier;
                        break;
                    case "CSIA":
                        var csia = csvReader.GetRecord<KOTI_CSIA>();
                        csvFile.DataRows.Add(csia);
                        csvFile.Header.ReporterIdentifier = csia.ReporterIdentifier;
                        csvFile.Header.TypeOfReporterIdentifier = csia.TypeOfReporterIdentifier;
                        break;
                    case "CSDR":
                        var csdr = csvReader.GetRecord<KOTI_CSDR>();
                        csvFile.DataRows.Add(csdr);
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown record type on line index {csvReader.CurrentIndex}");
                }
            }

            csvFile.Header.SurveyCode = SurveyEnum.KOTI.ToString();
        }
    }
}
