namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class KOTI_BS : IDataRow
    {
        public string ReportingFrequency { get; set; }
        public string ReportersName { get; set; }
        public decimal? RiskWeightedAssets { get; set; }
        public decimal? Tier1Capital { get; set; }
        public decimal? ConsolidatedBalanceSheet { get; set; }
    }
}
