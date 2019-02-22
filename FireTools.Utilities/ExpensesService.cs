using System;
using System.Collections.Generic;
using System.Text;

namespace FireTools.Utilities
{
    public class ExpensesService : BaseCalculator
    {
        private readonly decimal _expenseAmount;       

        public ExpensesService(decimal expenseAmount)
        {
            _expenseAmount = expenseAmount;
        }

        public decimal CalculateWeeklyExpenses()
        {
            return (_expenseAmount * 752);
        }

        public decimal CalculateMonthlyExpenses()
        {
            return (_expenseAmount * 173);
        }

        public override decimal Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
