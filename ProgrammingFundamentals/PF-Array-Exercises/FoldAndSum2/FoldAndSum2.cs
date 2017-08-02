namespace FoldAndSum2
{
    using System;
    using System.Linq;
    public class FoldAndSum2
    {
        public static void Main()
        {
            var initialArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstKnumbers = initialArray.Take(initialArray.Length / 4).Reverse().ToArray();
            var secKNumbers = initialArray.Skip(initialArray.Length / 4).Take(initialArray.Length / 4).ToArray();
            var thirdKNumbers = initialArray.Skip(initialArray.Length / 2).Take(initialArray.Length / 4).ToArray();
            var lastKNumbers = initialArray.Skip(initialArray.Length / 4 * 3).Take(initialArray.Length / 4).Reverse().ToArray();

            var sum1 = new int[firstKnumbers.Length];
            var sum2 = new int[lastKNumbers.Length];

            for (int i = 0; i < sum1.Length; i++)
            {
                sum1[i] = firstKnumbers[i] + secKNumbers[i];
                sum2[i] = thirdKNumbers[i] + lastKNumbers[i];
            }
            var totalSum = sum1.Concat(sum2);
            Console.WriteLine(string.Join(" ", totalSum));
        }
    }
}
