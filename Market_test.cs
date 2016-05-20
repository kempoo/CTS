using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockCore;

namespace PSVSuiteTests
{
    [TestClass]
    public class Market_Test
    {
        [TestMethod]
        public void Market_checkOnlineSourceAvailability_Returns_String()
        {
            Market unitUnderTest = new Market();
            var result = unitUnderTest.checkOnlineSourceAvailability();
            Assert.IsTrue(result is string);
            Assert.IsTrue(result.Length>0);
        }

        [TestMethod]
        public void Market_getData_Returns_Data()
        {
            Market unitUnderTest = new Market();
            var r = unitUnderTest.checkOnlineSourceAvailability();
            var result = unitUnderTest.getData(r);
            Assert.IsTrue(result.Count > 0 && result.Count % 4 == 0, "unexpected result");
        }

        [TestMethod]
        public void Market_checkData_WrongData_Returns_False()
        {
            Market unitUnderTest = new Market();
            var result = unitUnderTest.checkData("wrong Data");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Market_checkData_JSON_Returns_True()
        {
            Market unitUnderTest = new Market();
            var result = unitUnderTest.checkData("{'entity': 'name'}");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Market_getPunctInfo_ReturnsSpecificString()
        {
            Market unitUnderTest = new Market();
            string expected = "Market";
            var result = unitUnderTest.getPunctInfo();

            Assert.IsTrue(result == expected, "Unexpected result");
        }
    }
}
