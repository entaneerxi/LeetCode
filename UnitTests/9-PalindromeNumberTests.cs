using LeetCode_NET_.Problem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class PalindromeNumberTests9
    {
        [TestMethod]
        public void TestMethod1()
        {
            PalindromeNumbers obj = new PalindromeNumbers();
            Assert.AreEqual(true, obj.IsPalindrome(121));

        }

        [TestMethod]
        public void TestMethod2()
        {
            PalindromeNumbers obj = new PalindromeNumbers();
            Assert.AreEqual(false, obj.IsPalindrome(-121));

        }

        [TestMethod]
        public void TestMethod3()
        {
            PalindromeNumbers obj = new PalindromeNumbers();
            Assert.AreEqual(false, obj.IsPalindrome(10));

        }
    }
}
