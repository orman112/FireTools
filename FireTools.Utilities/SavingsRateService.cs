using FireTools.Utilities.Interfaces;

namespace FireTools.Utilities
{
    public class SavingsRateService : BaseCalculator, ISavingsRate
    {
        public SavingsRateService() { }

        public override decimal Calculate()
        {
            throw new System.NotImplementedException();
        }

        public decimal Calculate(decimal pretaxContributions, decimal takeHomePay, decimal postTaxContributions)
        {
            return (pretaxContributions + postTaxContributions) / (takeHomePay + pretaxContributions);
        }
    }
}
