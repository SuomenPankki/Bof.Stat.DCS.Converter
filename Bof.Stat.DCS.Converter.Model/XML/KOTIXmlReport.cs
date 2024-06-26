//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.0.0 using the following command:
// XmlSchemaClassGenerator C:\Users\MIHO-D\source\repos\Bof.Stat.DCS\Bof.Stat.DCS.Converter\Schemas\KOTI_1.0.xsd -0 --namespace=Bof.Stat.DCS.Converter.Model.XML.KOTI --collectionSettersMode=Public --nullableReferenceAttributes -v --enumAsString
namespace Bof.Stat.DCS.Converter.Model.XML.KOTI
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("headerType", Namespace = "http://bof.fi/KOTI")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HeaderType
    {

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("typeOfDataProviderIdentifier")]
        public string TypeOfDataProviderIdentifier { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum length: 10.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("dataProviderIdentifier")]
        public string DataProviderIdentifier { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("typeOfReporterIdentifier")]
        public string TypeOfReporterIdentifier { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum length: 10.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("reporterIdentifier")]
        public string ReporterIdentifier { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("surveyCode")]
        public string SurveyCode { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("reportingPeriodEnd", DataType = "date")]
        public System.DateTime ReportingPeriodEnd { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("frequency")]
        public string Frequency { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("creationDate", DataType = "dateTime")]
        public System.DateTime CreationDate { get; set; }

        /// <summary>
        /// <para xml:lang="en">Maximum length: 500.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(500)]
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("entitysComment")]
        public string EntitysComment { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("csType", Namespace = "http://bof.fi/KOTI")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CsType
    {

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("allocationOfBalanceSheetItem")]
        public string AllocationOfBalanceSheetItem { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("transaction")]
        public string Transaction { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("instrument")]
        public string Instrument { get; set; }

        /// <summary>
        /// <para xml:lang="en">Maximum length: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("internalIdentifier")]
        public string InternalIdentifier { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("sector")]
        public string Sector { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("countryCode")]
        public string CountryCode { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("groupUnitCountry")]
        public string GroupUnitCountry { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("conversionCurrency")]
        public string ConversionCurrency { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bookValue")]
        public decimal BookValue { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bookValueCurrency")]
        public string BookValueCurrency { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("remainingMaturity")]
        public string RemainingMaturity { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("targetCountryOfRiskTransfer")]
        public string TargetCountryOfRiskTransfer { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("targetSectorOfRiskTransfer")]
        public string TargetSectorOfRiskTransfer { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("bsType", Namespace = "http://bof.fi/KOTI")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BsType
    {

        /// <summary>
        /// <para xml:lang="en">Maximum length: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("reportersName")]
        public string ReportersName { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("riskWeightedAssets")]
        public decimal RiskWeightedAssets { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("tier1Capital")]
        public decimal Tier1Capital { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("consolidatedBalanceSheet")]
        public decimal ConsolidatedBalanceSheet { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("csiaType", Namespace = "http://bof.fi/KOTI")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CsiaType
    {

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("allocationOfBalanceSheetItem")]
        public string AllocationOfBalanceSheetItem { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("transaction")]
        public string Transaction { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bisUnit")]
        public string BisUnit { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("instrument")]
        public string Instrument { get; set; }

        /// <summary>
        /// <para xml:lang="en">Maximum length: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("internalIdentificationCode")]
        public string InternalIdentificationCode { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("sector")]
        public string Sector { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("countryCode")]
        public string CountryCode { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("homeCountryOfGroupEntityCountyCode")]
        public string HomeCountryOfGroupEntityCountyCode { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("conversionCurrency")]
        public string ConversionCurrency { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bookValue")]
        public decimal BookValue { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bookValueCurrency")]
        public string BookValueCurrency { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("remainingMaturity")]
        public string RemainingMaturity { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("targetCountryOfRiskTransfer")]
        public string TargetCountryOfRiskTransfer { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("targetSectorOfRiskTransfer")]
        public string TargetSectorOfRiskTransfer { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("collateralType")]
        public string CollateralType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("debtSecurityType")]
        public string DebtSecurityType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("accountingClassification")]
        public string AccountingClassification { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("typeOfEquityInvestment")]
        public string TypeOfEquityInvestment { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("subordination")]
        public bool SubordinationValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Subordination property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SubordinationValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Subordination
        {
            get
            {
                if (this.SubordinationValueSpecified)
                {
                    return this.SubordinationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SubordinationValue = value.GetValueOrDefault();
                this.SubordinationValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("insuranceAssetType")]
        public string InsuranceAssetType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("insurancePolicyType")]
        public string InsurancePolicyType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("equityType")]
        public string EquityType { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("csdrType", Namespace = "http://bof.fi/KOTI")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CsdrType
    {

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("transaction")]
        public string Transaction { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bisUnit")]
        public string BisUnit { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("instrument")]
        public string Instrument { get; set; }

        /// <summary>
        /// <para xml:lang="en">Maximum length: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("internalIdentifier")]
        public string InternalIdentifier { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("sector")]
        public string Sector { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("countryCode")]
        public string CountryCode { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("conversionCurrency")]
        public string ConversionCurrency { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bookValue")]
        public decimal BookValue { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bookValueCurrency")]
        public string BookValueCurrency { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("remainingMaturity")]
        public string RemainingMaturity { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("measureType")]
        public string MeasureType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("currencyBought")]
        public string CurrencyBought { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("currencySold")]
        public string CurrencySold { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("marketRisk")]
        public string MarketRisk { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("derivativeContractType")]
        public string DerivativeContractType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("foreignExchangeDerivateContractType")]
        public string ForeignExchangeDerivateContractType { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("bsiaType", Namespace = "http://bof.fi/KOTI")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BsiaType
    {

        /// <summary>
        /// <para xml:lang="en">Maximum length: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("reportersName")]
        public string ReportersName { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("riskWeightedAssets")]
        public decimal RiskWeightedAssets { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("tier1Capital")]
        public decimal Tier1Capital { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bankingGroupBalanceSheet")]
        public decimal BankingGroupBalanceSheet { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999999999.99.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Total number of digits: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-999999999999999999.99", "999999999999999999.99")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("totalConsolidatedBalanceSheet")]
        public decimal TotalConsolidatedBalanceSheet { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("kotiReport", Namespace = "http://bof.fi/KOTI", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("kotiReport", Namespace = "http://bof.fi/KOTI")]
    public partial class KotiReport
    {

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("header")]
        public Bof.Stat.DCS.Converter.Model.XML.KOTI.HeaderType Header { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsType> _csRecords;

        [System.Xml.Serialization.XmlArrayAttribute("csRecords")]
        [System.Xml.Serialization.XmlArrayItemAttribute("cs", Namespace = "http://bof.fi/KOTI")]
        public System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsType> CsRecords
        {
            get
            {
                return _csRecords;
            }
            set
            {
                _csRecords = value;
            }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CsRecords collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CsRecordsSpecified
        {
            get
            {
                return ((this.CsRecords != null)
                            && (this.CsRecords.Count != 0));
            }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="KotiReport" /> class.</para>
        /// </summary>
        public KotiReport()
        {
            this._csRecords = new System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsType>();
            this._csiaRecords = new System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsiaType>();
            this._csdrRecords = new System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsdrType>();
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bsRecords")]
        public KotiReportBsRecords BsRecords { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsiaType> _csiaRecords;

        [System.Xml.Serialization.XmlArrayAttribute("csiaRecords")]
        [System.Xml.Serialization.XmlArrayItemAttribute("csia", Namespace = "http://bof.fi/KOTI")]
        public System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsiaType> CsiaRecords
        {
            get
            {
                return _csiaRecords;
            }
            set
            {
                _csiaRecords = value;
            }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CsiaRecords collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CsiaRecordsSpecified
        {
            get
            {
                return ((this.CsiaRecords != null)
                            && (this.CsiaRecords.Count != 0));
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsdrType> _csdrRecords;

        [System.Xml.Serialization.XmlArrayAttribute("csdrRecords")]
        [System.Xml.Serialization.XmlArrayItemAttribute("csdr", Namespace = "http://bof.fi/KOTI")]
        public System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsdrType> CsdrRecords
        {
            get
            {
                return _csdrRecords;
            }
            set
            {
                _csdrRecords = value;
            }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CsdrRecords collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CsdrRecordsSpecified
        {
            get
            {
                return ((this.CsdrRecords != null)
                            && (this.CsdrRecords.Count != 0));
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bsiaRecords")]
        public KotiReportBsiaRecords BsiaRecords { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("schemaVersion")]
        public string SchemaVersion { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("KotiReportCsRecords", Namespace = "http://bof.fi/KOTI", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KotiReportCsRecords
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsType> _cs;

        [System.Xml.Serialization.XmlElementAttribute("cs")]
        public System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsType> Cs
        {
            get
            {
                return _cs;
            }
            set
            {
                _cs = value;
            }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Cs collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CsSpecified
        {
            get
            {
                return ((this.Cs != null)
                            && (this.Cs.Count != 0));
            }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="KotiReportCsRecords" /> class.</para>
        /// </summary>
        public KotiReportCsRecords()
        {
            this._cs = new System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsType>();
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("KotiReportBsRecords", Namespace = "http://bof.fi/KOTI", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KotiReportBsRecords
    {

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bs")]
        public Bof.Stat.DCS.Converter.Model.XML.KOTI.BsType Bs { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("KotiReportCsiaRecords", Namespace = "http://bof.fi/KOTI", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KotiReportCsiaRecords
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsiaType> _csia;

        [System.Xml.Serialization.XmlElementAttribute("csia")]
        public System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsiaType> Csia
        {
            get
            {
                return _csia;
            }
            set
            {
                _csia = value;
            }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Csia collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CsiaSpecified
        {
            get
            {
                return ((this.Csia != null)
                            && (this.Csia.Count != 0));
            }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="KotiReportCsiaRecords" /> class.</para>
        /// </summary>
        public KotiReportCsiaRecords()
        {
            this._csia = new System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsiaType>();
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("KotiReportCsdrRecords", Namespace = "http://bof.fi/KOTI", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KotiReportCsdrRecords
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsdrType> _csdr;

        [System.Xml.Serialization.XmlElementAttribute("csdr")]
        public System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsdrType> Csdr
        {
            get
            {
                return _csdr;
            }
            set
            {
                _csdr = value;
            }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Csdr collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CsdrSpecified
        {
            get
            {
                return ((this.Csdr != null)
                            && (this.Csdr.Count != 0));
            }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="KotiReportCsdrRecords" /> class.</para>
        /// </summary>
        public KotiReportCsdrRecords()
        {
            this._csdr = new System.Collections.ObjectModel.Collection<Bof.Stat.DCS.Converter.Model.XML.KOTI.CsdrType>();
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("KotiReportBsiaRecords", Namespace = "http://bof.fi/KOTI", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KotiReportBsiaRecords
    {

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bsia")]
        public Bof.Stat.DCS.Converter.Model.XML.KOTI.BsiaType Bsia { get; set; }
    }
}
