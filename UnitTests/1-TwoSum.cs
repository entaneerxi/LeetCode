using LeetCode_NET_.Problem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class TwoSumTests1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TwoSum obj = new TwoSum();

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] rs = { 0, 1 };
            Assert.AreEqual(rs, obj._TwoSum(nums, target));
        }

        [TestMethod]
        public void TestMethod2()
        {
            TwoSum obj = new TwoSum();

            int[] nums = { 3, 2, 4 };
            int target = 6;

            int[] rs = { 1, 2 };
            Assert.AreEqual(rs, obj._TwoSum(nums, target));
        }

        [TestMethod]
        public void TestMethod3()
        {
            TwoSum obj = new TwoSum();

            int[] nums = { 3, 3 };
            int target = 6;

            int[] rs = { 0, 1 };
            Assert.AreEqual(rs, obj._TwoSum(nums, target));
        }
    }
}
