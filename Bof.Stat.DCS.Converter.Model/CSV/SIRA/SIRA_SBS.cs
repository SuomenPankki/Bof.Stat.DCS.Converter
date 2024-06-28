namespace Bof.Stat.DCS.Converter.Model.CSV.SIRA
{
    public class SIRA_SBS : IDataRow
    {
        public string ReporterIdentifier { get; set; }
        public string TypeOfReporterIdentifier { get; set; }

        public string Category { get; set; }
        public string ContractType { get; set; }
        public string Instrument { get; set; }
        public string Collateral { get; set; }
        public string InternalIdentificationCode { get; set; }
        public string IsinCode { get; set; }
        public string AllCode { get; set; }
        public string InstrumentsName { get; set; }
        public decimal? NumberOfInstruments { get; set; }
        public decimal? TotalNominalValue { get; set; }
        public string NominalValueCurrency { get; set; }
        public decimal TotalMarketValueDirtyPrice { get; set; }
        public string MarketCurrencyDirtyPrice { get; set; }
        public decimal? TotalMarketValueCleanPrice { get; set; }
        public string MarketCurrencyCleanPrice { get; set; }
        public string TypeOfCounterpartysIdentifier { get; set; }
        public string CounterpartysIdentifier { get; set; }
        public string CounterpartysName { get; set; }
        public string CounterpartysSector { get; set; }
        public string CounterpartysHomeCountry { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public string TypeOfIssuersIdentifier { get; set; }
        public string IssuersIdentifier { get; set; }
        public string IssuersName { get; set; }
        public string IssuersSector { get; set; }
        public string IssuersHomeCountry { get; set; }
        public int? DerivativesSellingOrBuyingIndicator { get; set; }
        public string Marketplace { get; set; }
        public string UnderlyingAssetOfDerivative { get; set; }
        public string TypeOfUnderlyingAssetsIdentifier { get; set; }
        public string UnderlyingAssetsIdentifier { get; set; }
        public string TypeOfUnderlyingSecurityIssuersIdentifier { get; set; }
        public string UnderlyingSecurityIssuersIdentifier { get; set; }
        public string NameOfUnderlyingSecurityIssuer { get; set; }
        public string HomeCountryOfUnderlyingSecurityIssuer { get; set; }
        public decimal? TotalNumberOfUnderlyingAssets { get; set; }
        public decimal? MarketPriceOfUnderlyingAsset { get; set; }
        public string MarketPriceCurrencyOfUnderlyingAsset { get; set; }
        public decimal? DerivativesRiskWeightedValue { get; set; }
        public string CurrencyOfDerivativesRiskWeightedValue { get; set; }
        public decimal? DerivativesDelta { get; set; }


    }
}
