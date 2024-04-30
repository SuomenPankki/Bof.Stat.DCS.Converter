namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class MAPE_HPAY : IDataRow
    {
        public string ReportersRole { get; set; }
        public string InformationType { get; set; }
        public string PaymentService { get; set; }
        public string PaymentServiceUser { get; set; }
        public bool? Electronic { get; set; }
        public string PaymentOrder { get; set; }
        public string ChannelForGivingConsent { get; set; }
        public string PaymentScheme { get; set; }
        public bool? InstantPayment { get; set; }
        public string CardType { get; set; }
        public string EMoneyType { get; set; }
        public string RemoteNonRemote { get; set; }
        public string ContactlessTechnology { get; set; }
        public string Terminal { get; set; }
        public string InitiationChannel { get; set; }
        public string MobilePaymentType { get; set; }
        public string CustomerAuthentication { get; set; }
        public string ReasonForNonSca { get; set; }
        public string FraudType { get; set; }
        public string LiabilityBearer { get; set; }
        public string CounterpartysPspLocation { get; set; }
        public string TerminalLocation { get; set; }
        public string Currency { get; set; }
        public long? Amount { get; set; }
        public double Value { get; set; }
    }
}
