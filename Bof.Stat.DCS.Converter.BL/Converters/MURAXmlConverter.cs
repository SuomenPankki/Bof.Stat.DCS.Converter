using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.MURA;
using System.Globalization;
using System.Text;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public class MURAXmlConverter : XmlConverterBase
    {
        public MURAXmlConverter(XmlFile xmlFile) : base(xmlFile)
        {

        }

        public override string GetFilename() => GetFilenameWithProvider();

        protected override string GetReport()
        {
            var muraXmlFile = xmlFile.Report as MuraReport;
            var report = new StringBuilder();
            var header = muraXmlFile.Header;

            report.AppendLine($"\"000\";\"{header.TypeOfDataProviderIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.DataProviderIdentifier}\";\"{header.SurveyCode}\";\"P\";\"{header.ReportingPeriodEnd.DateToPeriod(header.Frequency)}\";\"{header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\";{muraXmlFile.RowCount};\"{header.EntitysComment}\"");

            var bs = muraXmlFile.BsRecords.Bs;
            {
                report.AppendLine($"\"BS\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"Q\";\"{bs.ReportersName}\";;;;;;;;;{bs.TotalAssets}");
            }

            foreach (var ld in muraXmlFile.LdRecords)
            {
                report.AppendLine($"\"LD\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{ld.AllocationOfBalanceSheetItem}\";\"{ld.Transaction}\";;\"{ld.Instrument}\";;\"{ld.SecurisationAndLoanTransfer}\";\"{ld.TransactionPeriod}\";;;\"{ld.PurposeOfLoan}\";\"{ld.IntraGroupItem}\";;\"{ld.Collateral}\";\"{ld.InternalIdentifier}\";;\"{ld.Sector}\";;;;\"{ld.IndustrialClassification}\";\"{ld.CountryCode}\";\"{ld.CounterpartySector}\";;\"{ld.CounterpartysHomeCountry}\";;;;\"{ld.ConversionCurrency}\";{ld.BookValue};\"{ld.BookValueCurrency}\";{ld.BookValueExclNonPerformingStock};\"{ld.AnnualisedAgreedRate}\";{ld.AnnualPercentageRateOfCharge};{ld.InterestPayable};;\"{ld.FirmSize}\";;\"{ld.InterestRateLinkage}\";\"{ld.InitialPeriodOfFixation}\";\"{ld.OriginalMaturity}\";;;;{ld.InvidualLoanLossesAndImpairements};");
            }

            foreach (var rest in muraXmlFile.RestRecords)
            {
                report.AppendLine($"\"REST\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{rest.AllocationOfBalanceSheetItem}\";\"{rest.Transaction}\";;\"{rest.Instrument}\";;;\"{rest.IntraGroupItem}\";\"{rest.InternalIdentifier}\";\"{rest.Sector}\";\"{rest.CountryCode}\";;\"{rest.ConversionCurrency}\";{rest.BookValue};\"{rest.BookValueCurrency}\"");
            }

            foreach (var sbs in muraXmlFile.SbsRecords)
            {
                report.AppendLine($"\"SBS\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{sbs.AllocationOfBalanceSheetItem}\";\"{sbs.Transaction}\";\"{sbs.Instrument}\";;\"{sbs.InternalIdentifier}\";\"{sbs.IsinCode}\";;;;{sbs.NumberOfInstrument};{sbs.TotalNominalValue};\"{sbs.NominalValueCurrency}\";{sbs.TotalMarketValueDirty};\"{sbs.MarketCurrencyDirty}\";;{sbs.TotalMarketValueClean};\"{sbs.MarketCurrencyClean}\";\"{sbs.IntraGroupItem}\";\"{sbs.DirectInvestment.GetYesNo()}\";{sbs.Dividend};\"{sbs.DividendCurrency}\";;;;\"{sbs.CounterpartysSector}\";\"{sbs.CounterpartysHomeCountry}\";\"{sbs.IssueDate.ParseToNullableDateString()}\";\"{sbs.MaturityDate.ParseToNullableDateString()}\";;;;\"{sbs.CountryOfIssue}\";\"{sbs.TypeOfIssuersIdentifier}\";\"{sbs.IssuersIdentifier}\";\"{sbs.IssuersName}\";\"{sbs.IssuersSector}\";\"{sbs.IssuersHomeCountry}\"");
            }

            return report.ToString();
        }
    }
}
