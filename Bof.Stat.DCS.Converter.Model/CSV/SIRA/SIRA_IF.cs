namespace Bof.Stat.DCS.Converter.Model.CSV.SIRA
{
    public class SIRA_IF : IDataRow
    {
        public string ReporterIdentifier { get; set; }
        public string TypeOfReporterIdentifier { get; set; }
        public string ReporterName { get; set; }

        public decimal ExchangeRate { get; set; }
        public string CurrencyOfExchangeRate { get; set; }
        public decimal BalanceSheetTotal { get; set; }
        public string BalanceSheetCurrency { get; set; }
        public int TotalNumberOfUnitholders { get; set; }
        public int NumberOfPrivatePersonUnitholders { get; set; }
        public decimal HoldingsOfTenLargestUnitholders { get; set; }
        public string CurrencyOfHoldingsOfTenLargestUnitholders { get; set; }
        public decimal? DurationOfBondsAndMoneyMarketInstruments { get; set; }
        public decimal TotalValueOfUnitLinkedInsurancesDomesticCompanies { get; set; }
        public decimal TotalValueOfUnitLinkedInsurancesForeignCompanies { get; set; }
        public string CurrencyOfUnitLinkedInsurances { get; set; }
        public decimal CollateralRequirementForDerivatives { get; set; }
        public string CurrencyOfCollateralRequirementForDerivatives { get; set; }
        public decimal CollateralRequirementForRepurchaseAgreements { get; set; }
        public string CurrencyOfCollateralRequirementForRepurchaseAgreements { get; set; }
        public decimal CollateralRequirementForSecuritiesLendingAgreements { get; set; }
        public string CurrencyOfCollateralRequirementForSecuritiesLendingAgreements { get; set; }
        public decimal? DividendIncomeAndIncomeFromFundShares { get; set; }
        public decimal? InterestIncome { get; set; }
        public decimal? ProfitDistribution { get; set; }


    }
}
