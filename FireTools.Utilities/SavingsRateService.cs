using FireTools.Utilities.Interfaces;

namespace FireTools.Utilities
{
    public class SavingsRateService : BaseCalculator
    {
        private readonly decimal _pretaxContributions;
        private readonly decimal _takeHomePay;
        private readonly decimal _postTaxContributions;

        public SavingsRateService(decimal pretaxContributions, decimal takeHomePay, decimal postTaxContributions)
        {
            _pretaxContributions = pretaxContributions;
            _takeHomePay = takeHomePay;
            _postTaxContributions = postTaxContributions;
        }

        public override decimal Calculate()
        {
            return (_pretaxContributions + _postTaxContributions) / (_takeHomePay + _pretaxContributions);
        }
    }
}
