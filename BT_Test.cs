using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockCore;

namespace BanksSuiteTests
{
    [TestClass]
    public class BT_Test:GenericTestSet
    {
        [TestMethod]
        public void BT_GetRate_SuccessfulCall_ReturnsData()
        {
            BT unitUnderTest = new BT();
            var result = unitUnderTest.getRate();
            Assert.IsTrue(result.Count > 0 && result.Count % 4 == 0, ERR_MESSAGE);
        }

        [TestMethod]
        public void BT_GetRate_getBankInfo_ReturnsSpecificString()
        {
            BT unitUnderTest = new BT();
            string expected = "BT";
            var result = unitUnderTest.getBankInfo();

            Assert.IsTrue(result == expected, ERR_MESSAGE);
        }
    }
}
