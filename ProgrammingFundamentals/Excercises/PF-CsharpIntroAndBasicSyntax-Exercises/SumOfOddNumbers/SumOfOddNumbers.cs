namespace SumOfOddNumbers
{
    using System;
    public class SumOfOddNumbers
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;

            for (int i = 1; i < int.MaxValue; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                    Console.WriteLine(i);
                    count++;
                    if (count == num)
                    {
                        break;
                    }

                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
