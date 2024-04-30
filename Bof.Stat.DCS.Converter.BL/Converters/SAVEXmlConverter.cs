using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.SAVE;
using System.Globalization;
using System.Text;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public class SAVEXmlConverter : XmlConverterBase
    {
        public SAVEXmlConverter(XmlFile xmlFile) : base(xmlFile)
        {

        }

        public override string GetFilename()
        {
            return $"{xmlFile.Survey}_{xmlFile.Report.ReportPeriodEnd.DateToPeriod(xmlFile.Report.Frequency)}_{xmlFile.Report.DataProviderIdentifier}_{xmlFile.Report.ReporterIdentifier}_{xmlFile.Report.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}.CSV";
        }

        protected override string GetReport()
        {
            var saveXmlFile = xmlFile.Report as SaveReport;
            var report = new StringBuilder();
            var header = saveXmlFile.Header;

            report.AppendLine($"\"000\";\"{header.TypeOfDataProviderIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.DataProviderIdentifier}\";\"{header.SurveyCode}\";\"P\";\"{header.ReportingPeriodEnd.DateToPeriod(header.Frequency)}\";\"{header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\";{saveXmlFile.RowCount};\"{header.EntitysComment}\"");

            foreach (var sbs in saveXmlFile.SbsRecords)
            {
                report.AppendLine($"\"SBS\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{sbs.Category}\";{sbs.ContractType};\"{sbs.Instrument}\";;\"{sbs.InternalIdentificationCode}\";\"{sbs.IsinCode}\";;\"{sbs.InstrumentName}\";;{sbs.NumberOfInstruments};{sbs.TotalNominalValue};\"{sbs.NominalCurrency}\";;;;{sbs.TotalMarketValue};\"{sbs.MarketCurrency}\";\"{sbs.IntraGroupItem.GetYesNo()}\";;{sbs.Dividends};\"{sbs.DividendCurrency}\";;;;;\"{sbs.ContractingPartysHomeCountry}\";\"{sbs.IssueDate?.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}\";\"{sbs.MaturityDate?.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}\";\"{sbs.NextCouponDate?.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}\";{sbs.CouponRate};{sbs.CouponFrequency};\"{sbs.CountryOfIssue}\";;;;\"{sbs.IssuersSector}\";\"{sbs.IssuersHomeCountry}\"");
            }

            return report.ToString();
        }
    }
}
