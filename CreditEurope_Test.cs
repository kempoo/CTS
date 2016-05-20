using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockCore;

namespace BanksSuiteTests
{
    [TestClass]
    public class CreditEurope_Test:GenericTestSet
    {
        [TestMethod]
        public void CreditEurope_GetRate_SuccessfulCall_ReturnsData()
        {
            CreditEurope unitUnderTest = new CreditEurope();
            var result = unitUnderTest.getRate();
            Assert.IsTrue(result.Count > 0 && result.Count % 4 == 0, ERR_MESSAGE);
        }

        [TestMethod]
        public void CreditEurope_GetRate_getBankInfo_ReturnsSpecificString()
        {
            CreditEurope unitUnderTest = new CreditEurope();
            string expected = "CreditEurope";
            var result = unitUnderTest.getBankInfo();

            Assert.IsTrue(result == expected, ERR_MESSAGE);
        }
    }
}
