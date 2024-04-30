namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class MAPE_ACCO : IDataRow
    {
        public string AccountsDepositsAndOffices { get; set; }
        public string DepositType { get; set; }
        public bool? AssetsTransferableViaNetwork { get; set; }
        public bool? EMoneyAccount { get; set; }
        public string PaymentServiceUser { get; set; }
        public string Country { get; set; }
        public long? Amount { get; set; }
        public decimal? Value { get; set; }
    }
}
