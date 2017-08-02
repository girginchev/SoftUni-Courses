namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var count = 1;
            var maxCount = 1;
            var num = numbers[0];
            if (numbers.Count == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        num = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            var newArray = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                newArray.Add(num);
            }
            Console.WriteLine(string.Join(" ",newArray));

        }
    }
}
