using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_NET_.Problem
{
    public class RomantoInteger
    {
        public int RomanToInt(string s)
        {
            int rs = 0;
            var stringArray = s.ToArray();
            Dictionary<string, int> map = new Dictionary<string, int>
            {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 }
            };

            for (int i = 0; i < stringArray.Length; i++)
            {
                var _val = map[stringArray[i].ToString()];

                if (i < stringArray.Length - 1 && _val < map[stringArray[i + 1].ToString()])
                {
                    _val -= map[stringArray[i + 1].ToString()];
                    i++;
                }




                rs += Math.Abs(_val);

            }


            return rs;

        }
    }
}
