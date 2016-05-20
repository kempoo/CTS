using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockCore;
using Microsoft.QualityTools.Testing.Fakes;

namespace BanksSuiteTests
{
    [TestClass]
    public class BNR_Test:GenericTestSet
    {
        [TestMethod]
        public void BNR_GetRate_SuccessfulCall_ReturnsData()
        {
            BNR unitUnderTest = new BNR();
            var result = unitUnderTest.getRate();
            Assert.IsTrue(result.Count > 0 && result.Count % 4 == 0, ERR_MESSAGE);
        }

        [TestMethod]
        public void BNR_GetRate_getBankInfo_ReturnsSpecificString()
        {
            BNR unitUnderTest = new BNR();
            string expected = "BNR, national bank";
            var result = unitUnderTest.getBankInfo();

            Assert.IsTrue(result==expected, ERR_MESSAGE);
        }
    }
}
