using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// <summary>
    /// 386. Lexicographical Numbers
    /// </summary>
    public partial class Problem
    {
        public IList<int> LexicalOrder(int n)
        {
            List<int> result = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                F(i, n, ref result);
            }
            return result;
        }

        private void F(int value, int maxValue, ref List<int> temp)
        {
            if (value > maxValue) return;
            temp.Add(value);
            value *= 10;
            for (int i = 0; i < 10; i++)
            {
                F(value + i, maxValue, ref temp);
            }
        }
    }
}
