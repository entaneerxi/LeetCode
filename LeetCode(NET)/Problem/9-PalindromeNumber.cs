using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_NET_.Problem
{
    public class PalindromeNumbers
    {
        public bool IsPalindrome(int x)
        {
            //string reverseString = "";
            //foreach (var item in x.ToString().Reverse())
            //{
            //    reverseString += item.ToString();
            //}

            //if (reverseString == x.ToString())
            //    return true;

            //return false;

            var reverseString = x.ToString().Reverse();
            if (string.Concat(reverseString) == x.ToString())
                return true;
            return false;

        }
    }
}
