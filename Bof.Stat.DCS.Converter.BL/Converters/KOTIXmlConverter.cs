using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Common.Enums;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.KOTI;
using System.Globalization;
using System.Text;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public class KOTIXmlConverter : XmlConverterBase
    {
        private bool isKoia => (xmlFile.Report as KotiReport).BsiaRecords is not null;

        public KOTIXmlConverter(XmlFile xmlFile) : base(xmlFile)
        {

        }

        public override string GetFilename()
        {
            var ts = GetTimeStampFromFilename();

            return $"{(isKoia ? SurveyEnum.KOIA : SurveyEnum.KOTI)}_{xmlFile.Report.ReportPeriodEnd.DateToPeriod(xmlFile.Report.Frequency)}_{xmlFile.Report.ReporterIdentifier}_{xmlFile.Report.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}_{ts}.CSV";
        }

        protected override string GetReport()
        {
            var kotiXmlFile = xmlFile.Report as KotiReport;
            var report = new StringBuilder();
            var header = kotiXmlFile.Header;

            if (isKoia)
            {
                report.AppendLine($"\"000\";\"{header.TypeOfDataProviderIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.DataProviderIdentifier}\";\"KOIA\";\"P\";\"{header.ReportingPeriodEnd.DateToPeriod(header.Frequency)}\";\"{header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\";{kotiXmlFile.RowCount};\"{header.EntitysComment}\"");
            }
            else
            {
                report.AppendLine($"\"000\";\"{header.TypeOfDataProviderIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.DataProviderIdentifier}\";\"KOTI\";\"P\";\"{header.ReportingPeriodEnd.DateToPeriod(header.Frequency)}\";\"{header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\";{kotiXmlFile.RowCount};\"{header.EntitysComment}\"");
            }

            foreach (var cs in kotiXmlFile.CsRecords)
            {
                report.AppendLine($"\"CS\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{cs.AllocationOfBalanceSheetItem}\";\"{cs.Transaction}\";;\"{cs.Instrument}\";\"{cs.InternalIdentifier}\";\"{cs.Sector}\";\"{cs.CountryCode}\";\"{cs.GroupUnitCountry}\";\"{cs.ConversionCurrency}\";{cs.BookValue};\"{cs.BookValueCurrency}\";;\"{cs.RemainingMaturity}\";\"{cs.TargetCountryOfRiskTransfer}\";\"{cs.TargetSectorOfRiskTransfer}\"");
            }

            foreach (var csia in kotiXmlFile.CsiaRecords)
            {
                report.AppendLine($"\"CSIA\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{csia.AllocationOfBalanceSheetItem}\";\"{csia.Transaction}\";\"{csia.BisUnit}\";\"{csia.Instrument}\";\"{csia.InternalIdentificationCode}\";\"{csia.Sector}\";\"{csia.CountryCode}\";\"{csia.HomeCountryOfGroupEntityCountyCode}\";\"{csia.ConversionCurrency}\";{csia.BookValue};\"{csia.BookValueCurrency}\";;\"{csia.RemainingMaturity}\";\"{csia.TargetCountryOfRiskTransfer}\";\"{csia.TargetSectorOfRiskTransfer}\";\"{csia.CollateralType}\";\"{csia.DebtSecurityType}\";\"{csia.AccountingClassification}\";\"{csia.TypeOfEquityInvestment}\";\"{csia.Subordination}\";;\"{csia.InsuranceAssetType}\";\"{csia.InsurancePolicyType}\";\"{csia.EquityType}\";;;;;;;;;");
            }

            foreach (var csdr in kotiXmlFile.CsdrRecords)
            {
                report.AppendLine($"\"CSDR\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";;\"{csdr.Transaction}\";\"{csdr.BisUnit}\";\"{csdr.Instrument}\";\"{csdr.InternalIdentifier}\";\"{csdr.Sector}\";\"{csdr.CountryCode}\";;\"{csdr.ConversionCurrency}\";{csdr.BookValue};\"{csdr.BookValueCurrency}\";;\"{csdr.RemainingMaturity}\";;;;;;;;;;;;\"{csdr.MeasureType}\";\"{csdr.CurrencyBought}\";\"{csdr.CurrencySold}\";\"{csdr.MarketRisk}\";\"{csdr.DerivativeContractType}\";\"{csdr.ForeignExchangeDerivateContractType}\";;;");
            }

            if (!isKoia)
            {
                var bs = kotiXmlFile.BsRecords.Bs;
                {
                    report.AppendLine($"\"BS\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{header.Frequency}\";\"{bs.ReportersName}\";;;;;;;{bs.RiskWeightedAssets};{bs.Tier1Capital};{bs.ConsolidatedBalanceSheet}");
                }
            }
            else
            {
                var bsia = kotiXmlFile.BsiaRecords.Bsia;
                {
                    report.AppendLine($"\"BS\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{header.Frequency}\";\"{bsia.ReportersName}\";;;;;;;{bsia.RiskWeightedAssets};{bsia.Tier1Capital};{bsia.BankingGroupBalanceSheet};{bsia.TotalConsolidatedBalanceSheet}");
                }
            }

            return report.ToString();
        }
    }
}
