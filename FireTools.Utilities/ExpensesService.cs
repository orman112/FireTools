using System;
using System.Collections.Generic;
using System.Text;

namespace FireTools.Utilities
{
    public class ExpensesService : BaseCalculator
    {
        private readonly decimal _expenseAmount;
        private decimal _calculationFrequency;

        public ExpensesService(decimal expenseAmount)
        {
            //Weekly and Monthly Expenses Compounded Over 10 Years
            //Assumes 7% growth

            _expenseAmount = expenseAmount;
        }

        public decimal CalculateWeeklyExpenses()
        {
            _calculationFrequency = 752;
            return Calculate();
        }

        public decimal CalculateMonthlyExpenses()
        {
            _calculationFrequency = 173;
            return Calculate();
        }

        public override decimal Calculate()
        {
            return (_expenseAmount * _calculationFrequency);
        }
    }
}
