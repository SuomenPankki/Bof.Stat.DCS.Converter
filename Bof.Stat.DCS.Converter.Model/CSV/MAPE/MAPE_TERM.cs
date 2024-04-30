namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class MAPE_TERM : IDataRow
    {
        public string TerminalType { get; set; }
        public bool? Eftpos { get; set; }
        public bool? ContactlessPayment { get; set; }
        public bool? TerminalAcceptingEMoney { get; set; }
        public bool? EMoneyLoadingUnloading { get; set; }
        public string Country { get; set; }
        public long Amount { get; set; }
    }
}
