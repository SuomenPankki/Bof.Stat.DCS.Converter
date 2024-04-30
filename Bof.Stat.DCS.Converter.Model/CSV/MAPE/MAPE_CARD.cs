namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class MAPE_CARD : IDataRow
    {
        public string CardTypeProperty { get; set; }
        public string EMoneyCardType { get; set; }
        public string Scheme { get; set; }
        public bool? CashFunction { get; set; }
        public string CombinationCard { get; set; }
        public string CardTechnology { get; set; }
        public string PaymentServiceUser { get; set; }
        public string Country { get; set; }
        public long Amount { get; set; }
    }
}
