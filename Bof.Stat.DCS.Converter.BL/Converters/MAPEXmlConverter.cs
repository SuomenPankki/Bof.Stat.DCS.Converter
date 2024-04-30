using Bof.Stat.DCS.Converter.Common;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.MAPE;
using System.Globalization;
using System.Text;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public class MAPEXmlConverter : XmlConverterBase
    {
        public MAPEXmlConverter(XmlFile xmlFile) : base(xmlFile)
        {

        }

        public override string GetFilename() => GetDefaultFilename();

        protected override string GetReport()
        {
            var mapeXmlFile = xmlFile.Report as MapeReport;
            var report = new StringBuilder();
            var header = mapeXmlFile.Header;

            report.AppendLine($"\"000\";\"{header.TypeOfDataProviderIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.DataProviderIdentifier}\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{header.SurveyCode}\";\"P\";\"{header.Frequency}\";\"{header.ReportingPeriodEnd.DateToPeriod(header.Frequency)}\";\"{header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\";{mapeXmlFile.RowCount};\"{header.EntitysComment}\"");

            foreach (var acco in mapeXmlFile.AccoRecords)
            {
                report.AppendLine($"\"ACCO\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{acco.AccountsDepositsAndOffices}\";\"{acco.DepositType}\";\"{acco.AssetsTransferableViaNetwork.GetYesNo()}\";\"{acco.EMoneyAccount.GetYesNo()}\";\"{acco.PaymentServiceUser}\";\"{acco.Country}\";{acco.Amount};{acco.Value}");
            }

            foreach (var card in mapeXmlFile.CardRecords)
            {
                report.AppendLine($"\"CARD\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{card.CardTypeProperty}\";\"{card.EMoneyCardType}\";\"{card.Scheme}\";\"{card.CashFunction.GetYesNo()}\";\"{card.CombinationCard}\";\"{card.CardTechnology}\";\"{card.PaymentServiceUser}\";\"{card.Country}\";{card.Amount}");
            }

            foreach (var term in mapeXmlFile.TermRecords)
            {
                report.AppendLine($"\"TERM\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{term.TerminalType}\";\"{term.Eftpos.GetYesNo()}\";\"{term.ContactlessPayment.GetYesNo()}\";\"{term.TerminalAcceptingEMoney.GetYesNo()}\";\"{term.EMoneyLoadingUnloading.GetYesNo()}\";\"{term.Country}\";{term.Amount}");
            }

            foreach (var hpay in mapeXmlFile.HpayRecords)
            {
                report.AppendLine($"\"HPAY\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{hpay.ReportersRole}\";\"{hpay.InformationType}\";\"{hpay.PaymentService}\";\"{hpay.PaymentServiceUser}\";\"{hpay.Electronic.GetYesNo()}\";\"{hpay.PaymentOrder}\";\"{hpay.ChannelForGivingConsent}\";\"{hpay.PaymentScheme}\";\"{hpay.InstantPayment.GetYesNo()}\";\"{hpay.CardType}\";\"{hpay.EMoneyType}\";\"{hpay.RemoteNonRemote}\";\"{hpay.ContactlessTechnology}\";\"{hpay.Terminal}\";\"{hpay.InitiationChannel}\";\"{hpay.MobilePaymentType}\";\"{hpay.CustomerAuthentication}\";\"{hpay.ReasonForNonSca}\";\"{hpay.FraudType}\";\"{hpay.LiabilityBearer}\";\"{hpay.CounterpartysPspLocation}\";\"{hpay.TerminalLocation}\";\"{hpay.Currency}\";;{hpay.Amount};{hpay.Value}");
            }

            foreach (var qpay in mapeXmlFile.QpayRecords)
            {
                report.AppendLine($"\"QPAY\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{qpay.ReportersRole}\";\"{qpay.InformationType}\";\"{qpay.PaymentService}\";\"{qpay.PaymentServiceUser}\";\"{qpay.Electronic.GetYesNo()}\";;;;;;;\"{qpay.RemoteNonRemote}\";;;;;;;;;\"{qpay.CounterpartysPspLocation}\";\"{qpay.TerminalLocation}\";;\"{qpay.Industry}\";{qpay.Amount};{qpay.Value}");
            }

            foreach (var apay in mapeXmlFile.ApayRecords)
            {
                report.AppendLine($"\"APAY\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{apay.ReportersRole}\";\"{apay.InformationType}\";\"{apay.PaymentService}\";;\"{apay.Electronic.GetYesNo()}\";;\"{apay.ChannelForGivingConsent}\";;;\"{apay.CardType}\";;\"{apay.RemoteNonRemote}\";;\"{apay.Terminal}\";;;\"{apay.CustomerAuthentication}\";\"{apay.ReasonForNonSca}\";\"{apay.FraudType}\";\"{apay.LiabilityBearer}\";\"{apay.CounterpartysPspLocation}\";\"{apay.TerminalLocation}\";;;{apay.Amount};{apay.Value}");
            }

            foreach (var serv in mapeXmlFile.ServRecords)
            {
                report.AppendLine($"\"SERV\";\"{header.TypeOfReporterIdentifier.GetTypeOfBoFIdentifier()}\";\"{header.ReporterIdentifier}\";\"{serv.Service}\";{serv.Amount}");
            }

            return report.ToString();
        }
    }
}
