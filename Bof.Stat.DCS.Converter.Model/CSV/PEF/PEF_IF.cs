namespace Bof.Stat.DCS.Converter.Model.CSV.PEF
{
    public class PEF_IF : IDataRow
    {
        public string ReporterIdentifier { get; set; }
        public string TypeOfReporterIdentifier { get; set; }
        public string ReporterName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string CurrencyOfExchangeRate { get; set; }
        public decimal? BalanceSheetTotal { get; set; }
        public string BalanceSheetCurrency { get; set; }
        public int? TotalNumberOfUnitholders { get; set; }
    }
}
