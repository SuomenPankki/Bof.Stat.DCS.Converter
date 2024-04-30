using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.PEF;
using System.Globalization;
using System.Text;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public class PEFXmlConverter : XmlConverterBase
    {
        public PEFXmlConverter(XmlFile xmlFile) : base(xmlFile)
        {

        }

        public override string GetFilename() => GetDefaultFilename();

        protected override string GetReport()
        {
            var pefXmlFile = xmlFile.Report as PefReport;
            var report = new StringBuilder();
            var header = pefXmlFile.Header;

            report.AppendLine($"\"000\";\"{header.TypeOfManagementCompanyIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ManagementCompanyIdentifier}\";\"{header.SurveyCode}\";\"P\";\"{header.ReportingPeriodEnd.DateToPeriod(header.Frequency)}\";\"{header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\";{pefXmlFile.RowCount};\"{header.EntitysComment}\"");

            var iff = pefXmlFile.IfRecords.If;

            report.AppendLine($"\"IF\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{header.ReporterName}\";{iff.ExchangeRate};\"{iff.CurrencyOfExchangeRate}\";{iff.BalanceSheetTotal};\"{iff.BalanceSheetCurrency}\";{iff.TotalNumberOfUnitholders}");

            foreach (var pef in pefXmlFile.PefRecords)
            {
                report.AppendLine($"\"PEF\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{pef.Category}\";\"{pef.ContractType}\";\"{pef.Instrument}\";;\"{pef.InternalIdentificationCode}\";\"{pef.IsinCode}\";;{pef.NumberOfInstruments};{pef.TotalNominalValue};\"{pef.NominalValueCurrency}\";{pef.TotalMarketValueDirty};{pef.TotalMarketValueClean};{pef.CapitalFlows};{pef.LoanLosses};;;;\"{pef.TypeOfCounterpartysIdentifier}\";\"{pef.CounterpartysIdentifier}\";\"{pef.CounterpartysName}\";\"{pef.CounterpartysSector}\";\"{pef.CounterpartysHomeCountry}\";;;;\"{pef.IssueDate.ParseToNullableDateString()}\";\"{pef.MaturityDate.ParseToNullableDateString()}\";;;\"{pef.TypeOfIssuersIdentifier}\";\"{pef.IssuersIdentifier}\";\"{pef.IssuersName}\";\"{pef.IssuersSector}\";\"{pef.IssuersHomeCountry}\"");
            }

            return report.ToString();
        }
    }
}
