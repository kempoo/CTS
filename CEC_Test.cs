using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockCore;

namespace BanksSuiteTests
{
    [TestClass]
    public class CEC_Test:GenericTestSet
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CEC_GetRate_UnsuccessfulCall_ThrowException()
        {
            CEC unitUnderTest = new CEC();
            var result = unitUnderTest.getRate();
            Assert.IsTrue(result.Count > 0 && result.Count % 4 == 0, ERR_MESSAGE);
        }

        [TestMethod]
        public void CEC_GetRate_getBankInfo_ReturnsSpecificString()
        {
            CEC unitUnderTest = new CEC();
            string expected = "name: CEC, market share: 7.7%";
            var result = unitUnderTest.getBankInfo();

            Assert.IsTrue(result == expected, ERR_MESSAGE);
        }
    }
}
