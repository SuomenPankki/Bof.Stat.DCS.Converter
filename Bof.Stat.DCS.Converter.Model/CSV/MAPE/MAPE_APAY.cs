namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class MAPE_APAY : IDataRow
    {
        public string ReportersRole { get; set; }
        public string InformationType { get; set; }
        public string PaymentService { get; set; }
        public bool? Electronic { get; set; }
        public string ChannelForGivingConsent { get; set; }
        public string CardType { get; set; }
        public string RemoteNonRemote { get; set; }
        public string Terminal { get; set; }
        public string CustomerAuthentication { get; set; }
        public string ReasonForNonSca { get; set; }
        public string FraudType { get; set; }
        public string LiabilityBearer { get; set; }
        public string CounterpartysPspLocation { get; set; }
        public string TerminalLocation { get; set; }
        public long? Amount { get; set; }
        public decimal Value { get; set; }
    }
}
