using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockCore;

namespace BanksSuiteTests
{
    [TestClass]
    public class BancPost_Test:GenericTestSet
    {
        [TestMethod]
        public void BancPost_GetRate_SuccessfulCall_ReturnsData()
        {
            BancPost unitUnderTest = new BancPost();
            var result = unitUnderTest.getRate();
            Assert.IsTrue(result.Count > 0 && result.Count % 4 == 0, ERR_MESSAGE);
        }

        [TestMethod]
        public void BancPost_GetRate_getBankInfo_ReturnsSpecificString()
        {
            BancPost unitUnderTest = new BancPost();
            string expected = "BancPost";
            var result = unitUnderTest.getBankInfo();

            Assert.IsTrue(result == expected, ERR_MESSAGE);
        }
    }
}
