namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class MAPE_QPAY : IDataRow
    {
        public string ReportersRole { get; set; }
        public string InformationType { get; set; }
        public string PaymentService { get; set; }
        public string PaymentServiceUser { get; set; }
        public bool? Electronic { get; set; }
        public string RemoteNonRemote { get; set; }
        public string CounterpartysPspLocation { get; set; }
        public string TerminalLocation { get; set; }
        public string Industry { get; set; }
        public long Amount { get; set; }
        public decimal Value { get; set; }
    }
}
