using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockCore;

namespace BanksSuiteTests
{
    [TestClass]
    public class BRD_Test:GenericTestSet
    {
        [TestMethod]
        public void BRD_GetRate_SuccessfulCall_ReturnsData()
        {
            BRD unitUnderTest = new BRD();
            var result = unitUnderTest.getRate();
            Assert.IsTrue(result.Count > 0 && result.Count % 4 == 0, ERR_MESSAGE);
        }

        [TestMethod]
        public void BRD_GetRate_getBankInfo_ReturnsSpecificString()
        {
            BRD unitUnderTest = new BRD();
            string expected = "name: BRD, market share 12.4%";
            var result = unitUnderTest.getBankInfo();

            Assert.IsTrue(result == expected, ERR_MESSAGE);
        }
    }
}
