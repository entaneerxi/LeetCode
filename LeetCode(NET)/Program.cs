using LeetCode_NET_.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_NET_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new TwoSum();

            var oo = obj._TwoSum(new int[] { 3, 3 }, 6);
            Console.WriteLine(oo);
        }
    }
}
