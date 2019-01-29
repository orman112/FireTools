using FireTools.Utilities;
using NUnit.Framework;

namespace FireTools.Tests
{
    public class SavingsRateTests
    {
        private SavingsRateService _savingsRateService;

        [SetUp]
        public void Setup()
        {
            _savingsRateService = new SavingsRateService();
        }

        [Test]
        public void SavingEntireTakeHomePay_ShouldEqual100PercentSavingsRate()
        {
            const int takeHomePay = 50000;
            const int preTaxContributions = 12000;
            var savingsRate = 
                _savingsRateService.Calculate(preTaxContributions, takeHomePay, takeHomePay);

            Assert.AreEqual(1m, savingsRate);
        }
    }
}