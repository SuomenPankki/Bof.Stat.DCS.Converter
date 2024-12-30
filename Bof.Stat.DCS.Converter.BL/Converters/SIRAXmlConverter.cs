using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.SIRA;
using System.Globalization;
using System.Text;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public class SIRAXmlConverter : XmlConverterBase
    {
        public SIRAXmlConverter(XmlFile xmlFile) : base(xmlFile)
        {

        }

        public override string GetFilename() => GetDefaultFilename();

        protected override string GetReport()
        {
            var siraXmlFile = xmlFile.Report as SiraReport;
            var report = new StringBuilder();
            var header = siraXmlFile.Header;

            report.AppendLine($"\"000\";\"{header.TypeOfManagementCompanyIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ManagementCompanyIdentifier}\";\"{header.SurveyCode}\";\"P\";\"{header.ReportingPeriodEnd.DateToPeriod(header.Frequency)}\";\"{header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\";{siraXmlFile.RowCount};\"{header.EntitysComment}\"");

            var iff = siraXmlFile.IfRecords.If;

            report.AppendLine($"\"IF\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{header.ReporterName}\";{iff.ExchangeRate};\"{iff.CurrencyOfExchangeRate}\";{iff.BalanceSheetTotal};\"{iff.BalanceSheetCurrency}\";{iff.TotalNumberOfUnitholders};{iff.NumberOfPrivatePersonUnitholders};{iff.HoldingsOfTenLargestUnitholders};\"{iff.CurrencyOfHoldingsOfTenLargestUnitholders}\";{iff.DurationOfBondsAndMoneyMarketInstruments};{iff.TotalValueOfUnitLinkedInsurancesDomesticCompanies};{iff.TotalValueOfUnitLinkedInsurancesForeignCompanies};\"{iff.CurrencyOfUnitLinkedInsurances}\";{iff.CollateralRequirementForDerivatives};\"{iff.CurrencyOfCollateralRequirementForDerivatives}\";{iff.CollateralRequirementForSecuritiesLendingAgreements};\"{iff.CurrencyOfCollateralRequirementForRepurchaseAgreements}\";{iff.CollateralRequirementForSecuritiesLendingAgreements};\"{iff.CurrencyOfCollateralRequirementForSecuritiesLendingAgreements}\";{iff.DividendIncomeAndIncomeFromFundShares};{iff.InterestIncome};{iff.ProfitDistribution}");

            foreach (var item in siraXmlFile.ItemRecords)
            {
                report.AppendLine($"\"ITEM\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{item.Category}\";;\"{item.Instrument}\";\"{item.Collateral}\";\"{item.InternalIdentificationCode}\";;;;;;;\"{item.NominalValueCurrency}\";{item.TotalValue};\"{item.CurrencyOfValue}\";;;;;;;;\"{item.TypeOfCounterpartysIdentifier}\";\"{item.CounterpartysIdentifier}\";\"{item.CounterpartysName}\";\"{item.CounterpartysSector}\";\"{item.CounterpartysHomeCountry}\";\"{item.IssueDate.ParseToNullableDateString()}\";\"{item.MaturityDate.ParseToNullableDateString()}\"");
            }

            foreach (var sbs in siraXmlFile.SbsRecords)
            {
                report.AppendLine($"\"SBS\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{sbs.Category}\";{sbs.ContractType};\"{sbs.Instrument}\";\"{sbs.Collateral}\";\"{sbs.InternalIdentificationCode}\";\"{sbs.IsinCode}\";\"{sbs.AllCode}\";\"{sbs.InstrumentsName}\";;{sbs.NumberOfInstruments};{sbs.TotalNominalValue};\"{sbs.NominalValueCurrency}\";{sbs.TotalMarketValueDirtyPrice};\"{sbs.MarketCurrencyDirtyPrice}\";;{sbs.TotalMarketValueCleanPrice};\"{sbs.MarketCurrencyCleanPrice}\";;;;;{sbs.TypeOfCounterpartysIdentifier};{sbs.CounterpartysIdentifier};{sbs.CounterpartysName};{sbs.CounterpartysSector};{sbs.CounterpartysHomeCountry};\"{sbs.IssueDate.ParseToNullableDateString()}\";\"{sbs.MaturityDate.ParseToNullableDateString()}\";;;;;{sbs.TypeOfIssuersIdentifier};{sbs.IssuersIdentifier};\"{sbs.IssuersName}\";\"{sbs.IssuersSector}\";\"{sbs.IssuersHomeCountry}\";;;;;{sbs.DerivativesSellingOrBuyingIndicator};\"{sbs.Marketplace}\";\"{sbs.UnderlyingAssetOfDerivative}\";\"{sbs.TypeOfUnderlyingAssetsIdentifier}\";\"{sbs.UnderlyingAssetsIdentifier}\";\"{sbs.TypeOfUnderlyingSecurityIssuersIdentifier}\";\"{sbs.UnderlyingSecurityIssuersIdentifier}\";\"{sbs.NameOfUnderlyingSecurityIssuer}\";\"{sbs.HomeCountryOfUnderlyingSecurityIssuer}\";{sbs.TotalNumberOfUnderlyingAssets};{sbs.MarketPriceOfUnderlyingAsset};\"{sbs.MarketPriceCurrencyOfUnderlyingAsset}\";{sbs.DerivativesRiskWeightedValue};\"{sbs.CurrencyOfDerivativesRiskWeightedValue}\";{sbs.DerivativesDelta}");
            }

            return report.ToString();
        }
    }
}
