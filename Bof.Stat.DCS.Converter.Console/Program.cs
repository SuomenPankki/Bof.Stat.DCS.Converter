using Bof.Stat.DCS.Converter.BL;
using NLog;

namespace Bof.Stat.DCS.Converter.Console
{
    internal class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

            System.Console.WriteLine($"{fvi.ProductName}");
            System.Console.WriteLine();

            try
            {
                if (args.Length == 1)
                {
                    var filename = args[0];

                    var fileHandler = FileHandlerFactory.GetFileHandler(filename);
                    var converter = ConverterFactory.GetConverter(fileHandler.File);

                    foreach (var result in converter.Convert())
                    {
                        var targetFilename = Path.Combine(Path.GetDirectoryName(filename), result.Filename);

                        logger.Info($"Writing file {targetFilename}...");

                        File.WriteAllText(targetFilename, result.FileContent);
                    }
                }
                else
                {
                    System.Console.Write("Usage: Bof.Stat.DCS.Converter.Console.exe [filename]");
                    System.Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                Environment.Exit(-1);
            }
        }
    }
}
