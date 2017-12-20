namespace PairsByDifference
{
    using System;

    public class PairsByDifference
    {
        public static void Main()
        {
            var numbersString = Console.ReadLine().Split(' ');
            var difference = int.Parse(Console.ReadLine());

            int[] numbers = new int[numbersString.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersString[i]);
            }
            var cnt = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] - numbers[j] == difference)
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
