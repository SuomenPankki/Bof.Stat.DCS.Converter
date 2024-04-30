using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.Mappings.MAPE;
using CsvHelper;

namespace Bof.Stat.DCS.Converter.BL.Handlers
{
    public class MAPECsvFileHandler : CsvFileHandlerBase
    {
        public MAPECsvFileHandler(string filename) : base(filename)
        {

        }

        protected override void Map(CsvReader csvReader)
        {
            csvReader.Context.RegisterClassMap<MAPE_HeaderMap>();
            csvReader.Context.RegisterClassMap<MAPE_ACCOMap>();
            csvReader.Context.RegisterClassMap<MAPE_APAYMap>();
            csvReader.Context.RegisterClassMap<MAPE_HPAYMap>();
            csvReader.Context.RegisterClassMap<MAPE_QPAYMap>();
            csvReader.Context.RegisterClassMap<MAPE_CARDMap>();
            csvReader.Context.RegisterClassMap<MAPE_SERVMap>();
            csvReader.Context.RegisterClassMap<MAPE_TERMMap>();

            while (csvReader.Read())
            {
                switch (csvReader.GetField(0))
                {
                    case "000":
                        csvFile.Header = csvReader.GetRecord<Header>();
                        break;
                    case "ACCO":
                        var acco = csvReader.GetRecord<MAPE_ACCO>();
                        csvFile.DataRows.Add(acco);
                        break;
                    case "APAY":
                        var apay = csvReader.GetRecord<MAPE_APAY>();
                        csvFile.DataRows.Add(apay);
                        break;
                    case "HPAY":
                        var hpay = csvReader.GetRecord<MAPE_HPAY>();
                        csvFile.DataRows.Add(hpay);
                        break;
                    case "QPAY":
                        var qpay = csvReader.GetRecord<MAPE_QPAY>();
                        csvFile.DataRows.Add(qpay);
                        break;
                    case "CARD":
                        var card = csvReader.GetRecord<MAPE_CARD>();
                        csvFile.DataRows.Add(card);
                        break;
                    case "SERV":
                        var serv = csvReader.GetRecord<MAPE_SERV>();
                        csvFile.DataRows.Add(serv);
                        break;
                    case "TERM":
                        var term = csvReader.GetRecord<MAPE_TERM>();
                        csvFile.DataRows.Add(term);
                        break;

                    default:
                        throw new InvalidOperationException($"Unknown record type on line index {csvReader.CurrentIndex}");
                }
            }
        }
    }
}
