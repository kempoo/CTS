using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockCore;

namespace BanksSuiteTests
{
    [TestClass]
    public class BCR_Test:GenericTestSet
    {
        [TestMethod]
        public void BCR_GetRate_SuccessfulCall_ReturnsData()
        {
            BCR unitUnderTest = new BCR();
            var result = unitUnderTest.getRate();
            Assert.IsTrue(result.Count > 0 && result.Count % 4 == 0, ERR_MESSAGE);
        }

        [TestMethod]
        public void BCR_GetRate_getBankInfo_ReturnsSpecificString()
        {
            BCR unitUnderTest = new BCR();
            string expected = "name: BCR, market share: 16.2%";
            var result = unitUnderTest.getBankInfo();

            Assert.IsTrue(result == expected, ERR_MESSAGE);
        }
    }
}
