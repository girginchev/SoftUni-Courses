namespace OddFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddFilter
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var removedOddNumbers = nums.Where(n => n % 2 == 0).ToList();
            var average = removedOddNumbers.Average();
            var result = new List<int>();
            foreach (var num in removedOddNumbers)
            {
                if (num <= average)
                {
                    result.Add(num - 1);
                }
                else
                {
                    result.Add(num + 1);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
