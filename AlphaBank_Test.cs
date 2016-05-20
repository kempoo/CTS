using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockCore;

namespace BanksSuiteTests
{
    [TestClass]
    public class AlphaBank_Test:GenericTestSet
    {
        [TestMethod]
        public void AlphaBank_GetRate_SuccessfulCall_ReturnsData()
        {
            AlphaBank unitUnderTest = new AlphaBank();
            var result = unitUnderTest.getRate();
            Assert.IsTrue(result.Count > 0 && result.Count % 4 == 0, ERR_MESSAGE);
        }

        [TestMethod]
        public void AlphaBank_GetRate_getBankInfo_ReturnsSpecificString()
        {
            AlphaBank unitUnderTest = new AlphaBank();
            string expected = "Alphabank";
            var result = unitUnderTest.getBankInfo();

            Assert.IsTrue(result == expected, ERR_MESSAGE);
        }
    }
}
