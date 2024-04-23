using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public string OddString(string[] words)
        {
            Dictionary<string, int> dc = new();
            foreach (string s in words)
            {
                string diff = GetDiffs(s);
                dc[diff] = dc.GetValueOrDefault(diff) + 1;
            }
            foreach (string s in words)
                if (dc[GetDiffs(s)] == 1)
                    return s;
            return string.Empty;
        }

        private string GetDiffs(string s)
        {
            StringBuilder sb = new();
            for (int i = 0; i < s.Length - 1; i++)
            {
                sb.Append(s[i + 1] - s[i]);
                sb.Append(",");
            }
            return sb.ToString();
        }
    }
}
