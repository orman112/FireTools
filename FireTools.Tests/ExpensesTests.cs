using FireTools.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FireTools.Tests
{
    public class ExpensesTests
    {
        [Test]
        public void CupOfCoffee_ShouldSaveFifteenThousandDollars()
        {
            //$4 cup of coffee equals $20 a week
            var expensesService = new ExpensesService(20);
            var amountSavedByNotSpending = expensesService.CalculateWeeklyExpenses();

            Assert.AreEqual(15040, amountSavedByNotSpending);
        }

        [Test]
        public void ProfessionalHaircut_ShouldSaveSeventeenThousandDollars()
        {
            //$100 haircut each month
            var expensesService = new ExpensesService(100);
            var amountSavedByNotSpending = expensesService.CalculateMonthlyExpenses();

            Assert.AreEqual(17300, amountSavedByNotSpending);
        }
    }
}
