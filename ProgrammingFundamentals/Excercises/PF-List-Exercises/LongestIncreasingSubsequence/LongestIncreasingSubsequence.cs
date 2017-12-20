namespace LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var len = new int[numbers.Count];
            var prev = new int[numbers.Count];

            for (int a = 0; a < numbers.Count; a++)
            {
                len[a] = 1;
                prev[a] = -1;
                for (int c = 0; c < a; c++)
                {
                    if (numbers[a] > numbers[c] && len[c] >= len[a])
                    {
                        len[a] = len[c] + 1;
                        prev[a] = c;
                    }
                }
            }
            var longestIncreasingSubsequence = new List<int>();
            var maxLen = 0;
            for (int i = 0; i < len.Length; i++)
            {
                if (len[i] == len.Max())
                {
                    maxLen = i;
                    break;
                }
            }
            for (int i = maxLen; i >=0;)
            {
                longestIncreasingSubsequence.Add(numbers[i]);
                i = prev[i];
            }
            longestIncreasingSubsequence.Reverse();
            Console.WriteLine(string.Join(" ",longestIncreasingSubsequence));
        }
    }
}
