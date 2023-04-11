using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_NET_.Problem
{
    public class TwoSum
    {
        public int[] _TwoSum(int[] nums, int target)
        {

            //#region bruteforce
            //for (int x = 0; x < nums.Length; x++)
            //{
            //    int a = nums[x];
            //    for(int y = x + 1; y < nums.Length; y++)
            //    {
            //        if (target == (a + nums[y]))
            //        {
            //            return new int[] { x, y };
            //        }

            //    }
            //}
            //return null;
            //#endregion



            #region completion 
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }

            return null;
            #endregion

        }
    }
}
