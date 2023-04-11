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
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] rs = null;
            for (int i = 0; i < nums.Length; i++)
            {
                map.Add(i, nums[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int completement = target - nums[i];
                int key = map.FirstOrDefault(x => x.Value == completement).Key;

                rs = new int[] { i, key };
               
                //return new int[] { };
            }
            return rs;
        }
    }
}
