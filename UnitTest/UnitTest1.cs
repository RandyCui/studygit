using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var bl = new BL.Home();
            var testStr = string.Empty;
            var result = bl.Test(testStr);
            Assert.AreEqual(false, result, "Right for empty");
            testStr = "asdadadadasda";
            result = bl.Test(testStr);
            Assert.AreEqual(false, result, "Right for > 5");
        }
        [TestMethod]
        public void TestMethod2()
        {
            var bl = new BL.Home();
            var testStr = "as";
            var result = bl.Test(testStr);
            Assert.AreEqual(false, result, "Right for <=5");
        }
    }
}
