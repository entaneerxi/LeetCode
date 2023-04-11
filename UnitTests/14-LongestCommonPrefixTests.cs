using LeetCode_NET_.Problem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class LongestCommonPrefixTests14
    {
        [TestMethod]
        public void TestMethod1()
        {
            LongestCommonPrefix14 obj = new LongestCommonPrefix14();
            string[] Input = { "flower", "flow", "flight" };
            Assert.AreEqual("fl", obj.LongestCommonPrefix(Input));
        }

        [TestMethod]
        public void TestMethod2()
        {
            LongestCommonPrefix14 obj = new LongestCommonPrefix14();
            string[] Input = { "dog", "racecar", "car" };
            Assert.AreEqual("", obj.LongestCommonPrefix(Input));
        }
    }
}
