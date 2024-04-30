using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.RATI;
using System.Globalization;
using System.Text;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public class RATIXmlConverter : XmlConverterBase
    {
        public RATIXmlConverter(XmlFile xmlFile) : base(xmlFile)
        {

        }

        public override string GetFilename() => GetDefaultFilename();

        protected override string GetReport()
        {
            var ratiXmlFile = xmlFile.Report as RatiReport;
            var report = new StringBuilder();
            var header = ratiXmlFile.Header;

            report.AppendLine($"\"000\";\"{header.TypeOfDataProviderIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.DataProviderIdentifier}\";\"{header.SurveyCode}\";\"P\";\"{header.ReportingPeriodEnd.DateToPeriod(header.Frequency)}\";\"{header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\";{ratiXmlFile.RowCount};\"{header.EntitysComment}\"");

            foreach (var ld in ratiXmlFile.LdRecords)
            {
                report.AppendLine($"\"LD\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{ld.AllocationOfBalanceSheetItem}\";\"{ld.Transaction}\";;\"{ld.Instrument}\";\"{ld.NotionalCashPooling.GetYesNo()}\";\"{ld.SecuritisationAndLoanTransfer}\";\"{ld.TransactionPeriod}\";;;\"{ld.PurposeOfLoan}\";\"{ld.IntraGroupItem}\";\"{ld.SyndicatedItem.GetYesNo()}\";\"{ld.Collateral}\";\"{ld.InternalIdentifier}\";;\"{ld.Sector}\";\"{ld.CreditInstitutionExemptFromMinimumReserve}\";\"{ld.NameOfCreditInstitutionExemptFromMinimumReserve}\";\"{ld.EcbsAuxiliarySector}\";\"{ld.IndustrialClassification}\";\"{ld.CountryCode}\";\"{ld.CounterpartySector}\";\"{ld.EcbsAuxiliarySectorSecAndLoan}\";\"{ld.CounterpartyHomeCountry}\";;;;\"{ld.ConversionCurrency}\";{ld.BookValue};\"{ld.BookValueCurrency}\";{ld.BookValueExclNonPerformingStock};{ld.AnnualisedAgreedRate};{ld.AnnualPercentageRateOfCharge};{ld.InterestPayable};;;\"{ld.NextInterestRateReset}\";\"{ld.InterestRateLinkage}\";\"{ld.InitialPeriodOfFixation}\";\"{ld.OriginalMaturity}\";\"{ld.RemainingMaturity}\";\"{ld.SizeOfLoan}\";\"{ld.TermOfNotice}\";{ld.IndividualLoanLossesAndImpairement}");
            }

            foreach (var il in ratiXmlFile.IlRecords)
            {
                report.AppendLine($"\"IL\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{il.AllocationOfBalanceSheetItem}\";\"{il.Transaction}\";;\"{il.Instrument}\";;;;;;\"{il.PurposeOfLoan}\";\"{il.IntraGroupItem}\";\"{il.SyndicatedItem.GetYesNo()}\";\"{il.Collateral}\";\"{il.InternalIdentifier}\";;\"{il.Sector}\";;;\"{il.EcbsAuxiliarySector}\";\"{il.IndustrialClassification}\";\"{il.CountryCode}\";;;;;;;\"{il.ConversionCurrency}\";;;;;;;;;\"{il.NextInterestRateReset}\";\"{il.InterestRateLinkage}\";;\"{il.OriginalMaturity}\";;\"{il.SizeOfLoanToNonFinancialCorporation}\";;{il.CollectiveImpairment}");
            }


            foreach (var rest in ratiXmlFile.RestRecords)
            {
                report.AppendLine($"\"REST\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{rest.AllocationOfBalanceSheetItem}\";\"{rest.Transaction}\";;\"{rest.Instrument}\";;;\"{rest.IntraGroupItem}\";\"{rest.InternalIdentifier}\";\"{rest.Sector}\";\"{rest.CountryCode}\";;\"{rest.ConversionCurrency}\";{rest.BookValue};\"{rest.BookValueCurrency}\"");
            }

            foreach (var sbs in ratiXmlFile.SbsRecords)
            {
                report.AppendLine($"\"SBS\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{sbs.AllocationOfBalanceSheetItem}\";\"{sbs.Transaction}\";\"{sbs.Instrument}\";;\"{sbs.InternalIdentifier}\";\"{sbs.IsinCode}\";;;\"{sbs.CapitalCertainty.GetYesNo()}\";{sbs.NumberOfInstrument};{sbs.TotalNominalValue};\"{sbs.NominalValueCurrency}\";{sbs.TotalMarketValueDirtyPrice};\"{sbs.MarketValueCurrencyDirtyPrice}\";\"{sbs.AccountingClassification}\";{sbs.TotalMarketValueCleanPrice};\"{sbs.MarketValueCurrencyCleanPrice}\";\"{sbs.IntraGroupItem}\";\"{sbs.DirectInvestment.GetYesNo()}\";{sbs.Dividend};\"{sbs.DividendCurrency}\";;;;\"{sbs.CounterpartysSector}\";\"{sbs.CounterpartysHomeCountry}\";\"{sbs.IssueDate?.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}\";\"{sbs.MaturityDate?.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}\";;;;\"{sbs.CountryOfIssue}\";\"{sbs.TypeOfIssuersIdentifier}\";\"{sbs.IssuersIdentifier}\";\"{sbs.IssuersName}\";\"{sbs.IssuersSector}\";\"{sbs.IssuersHomeCountry}\"");
            }

            var bs = ratiXmlFile.BsRecords.Bs;
            {
                report.AppendLine($"\"BS\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{header.Frequency}\";\"{bs.ReportersName}\";;{bs.NumberOfHousingLoanCustomersHouseholds};;;;;{bs.NumberOfOffices};{bs.NumberOfEmployees};{bs.BalanceSheetTotal};;;;;;;;;");
            }

            return report.ToString();
        }
    }
}
