namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class KOTI_BSIA : IDataRow
    {
        public string ReportingFrequency { get; set; }
        public string ReportersName { get; set; }
        public decimal? RiskWeightedAssets { get; set; }
        public decimal? Tier1Capital { get; set; }
        public decimal? BankingGroupBalanceSheet { get; set; }
        public decimal? TotalConsolidatedBalanceSheet { get; set; }
    }
}
