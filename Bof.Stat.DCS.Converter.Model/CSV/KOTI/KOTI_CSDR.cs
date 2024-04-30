namespace Bof.Stat.DCS.Converter.Model.CSV
{
    public class KOTI_CSDR : IDataRow
    {
        public string Transaction { get; set; }
        public string BisUnit { get; set; }
        public string Instrument { get; set; }
        public string InternalIdentifier { get; set; }
        public string Sector { get; set; }
        public string CountryCode { get; set; }
        public string ConversionCurrency { get; set; }
        public decimal? BookValue { get; set; }
        public string BookValueCurrency { get; set; }
        public string RemainingMaturity { get; set; }
        public string MeasureType { get; set; }
        public string CurrencyBought { get; set; }
        public string CurrencySold { get; set; }
        public string MarketRisk { get; set; }
        public string DerivativeContractType { get; set; }
        public string ForeignExchangeDerivateContractType { get; set; }
    }
}
