using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.TIHA;
using System.Globalization;
using System.Text;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public class TIHAXmlConverter : XmlConverterBase
    {
        public TIHAXmlConverter(XmlFile xmlFile) : base(xmlFile)
        {

        }

        public override string GetFilename() => GetDefaultFilename();

        protected override string GetReport()
        {
            var tihaXmlFile = xmlFile.Report as TihaReport;
            var report = new StringBuilder();
            var header = tihaXmlFile.Header;

            report.AppendLine($"\"000\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{header.SurveyCode}\";\"P\";\"{header.ReportingPeriodEnd.DateToPeriod(header.Frequency)}\";\"{header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\";{tihaXmlFile.RowCount};\"{header.EntitysComment}\"");


            foreach (var sbs in tihaXmlFile.SbsRecords)
             {
                    report.AppendLine($"\"SBS\";;;;;\"{sbs.Instrument}\";;\"{sbs.InternalIdentificationCode}\";\"{sbs.IsinCode}\";;\"{sbs.InstrumentsName}\";;{sbs.NumberOfInstruments};{sbs.TotalNominalValue};\"{sbs.NominalCurrency}\";;;;{sbs.TotalMarketValue};\"{sbs.MarketCurrency}\";;;{sbs.Dividends};\"{sbs.DividendCurrency}\";;;;;;\"{sbs.IssueDate?.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}\";\"{sbs.MaturityDate?.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}\";\"{sbs.NextCouponDate?.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}\";{sbs.CouponRate};{sbs.CouponFrequency};;;;;\"{sbs.IssuersSector}\";\"{sbs.IssuersHomeCountry}\";\"{sbs.TypeOfHoldersIdentifier}\";\"{sbs.HoldersIdentifier}\";\"{sbs.HoldersName}\";\"{sbs.HoldersSector}\";\"{sbs.HoldersHomeTaxationCountry}\"");


             }

            return report.ToString();
        }
    }
}
