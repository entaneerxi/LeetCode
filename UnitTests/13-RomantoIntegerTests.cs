using LeetCode_NET_.Problem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class RomantoIntegerTests13
    {
        [TestMethod]
        public void TestMethod1()
        {
            RomantoInteger obj = new RomantoInteger();
            Assert.AreEqual(3, obj.RomanToInt("III"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            RomantoInteger obj = new RomantoInteger();
            Assert.AreEqual(58, obj.RomanToInt("LVIII"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            RomantoInteger obj = new RomantoInteger();
            Assert.AreEqual(1994, obj.RomanToInt("MCMXCIV"));
        }

    }
}
