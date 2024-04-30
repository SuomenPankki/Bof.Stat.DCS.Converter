using Bof.Stat.DCS.Converter.Model;
using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper;
using CsvHelper.Configuration;
using NLog;
using System.Globalization;

namespace Bof.Stat.DCS.Converter.BL
{
    public abstract class CsvFileHandlerBase : FileHandlerBase
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        protected CsvFile csvFile;

        public override FileBase File => csvFile;

        protected abstract void Map(CsvReader csvReader);

        public CsvFileHandlerBase(string filename)
        {
            Handle(filename);
        }

        protected override void Handle(string filename)
        {
            try
            {
                logger.Info($"Handling CSV-file {filename}...");

                csvFile = new CsvFile(filename);

                var config = new CsvConfiguration(CultureInfo.GetCultureInfo("fi-FI"))
                {
                    MissingFieldFound = null,
                    HasHeaderRecord = false,
                    Delimiter = ";",
                    IgnoreBlankLines = true
                };

                using (var reader = new StreamReader(filename))
                using (var csvReader = new CsvReader(reader, config))
                {
                    csvReader.Context.TypeConverterOptionsCache.GetOptions<string>().NullValues.Add("");

                    var boolOptions = csvReader.Context.TypeConverterOptionsCache.GetOptions<bool?>();
                    boolOptions.BooleanTrueValues.Add("Y");
                    boolOptions.BooleanFalseValues.Add("N");

                    Map(csvReader);
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Handling CSV-file {filename} failed", ex);
                throw;
            }
        }
    }
}
