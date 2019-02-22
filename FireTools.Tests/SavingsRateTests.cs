using FireTools.Utilities;
using NUnit.Framework;

namespace FireTools.Tests
{
    public class SavingsRateTests
    {
        [Test]
        public void SavingEntireTakeHomePay_ShouldEqual100PercentSavingsRate()
        {
            const int takeHomePay = 50000;
            const int preTaxContributions = 12000;
            var savingsRateService = new SavingsRateService(preTaxContributions, takeHomePay, takeHomePay);
            var savingsRate = savingsRateService.Calculate();

            Assert.AreEqual(1m, savingsRate);
        }
    }
}