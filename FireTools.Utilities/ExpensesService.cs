using System;
using System.Collections.Generic;
using System.Text;

namespace FireTools.Utilities
{
    public class ExpensesService
    {
        private readonly decimal _expenseAmount;

        public ExpensesService(decimal expenseAmount)
        {
            _expenseAmount = expenseAmount;
        }

        public decimal CalculateWeeklyExpenses()
        {
            return 0.00m;
        }

        public decimal CalculateMonthlyExpenses()
        {
            return 0.00m;
        }
    }
}
