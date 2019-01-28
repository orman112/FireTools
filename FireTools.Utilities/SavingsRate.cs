using FireTools.Utilities.Interfaces;

namespace FireTools.Utilities
{
    public class SavingsRate : BaseCalculator, ISavingsRate
    {
        public SavingsRate() { }

        public override decimal Calculate()
        {
            //Include tax advantaged (401k + match) savings as well as Roth IRA contributions
            //(^Savings^) / Net Income (gross less taxes)
            //Calculate on a per check basis

            throw new System.NotImplementedException();
        }
    }
}
