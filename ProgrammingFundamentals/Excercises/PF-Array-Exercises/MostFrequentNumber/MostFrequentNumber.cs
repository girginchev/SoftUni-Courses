namespace MostFrequentNumber
{
    using System;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var cnt = 0;
            var maxCnt = 0;
            var num = 0;
            //4 1 1 4 2 3 4 4 1 2 4 9 3
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        cnt++;
                        if (cnt > maxCnt)
                        {
                            maxCnt = cnt;
                            num = numbers[i];
                        }
                    }
                }
                cnt = 0;
            }
            Console.WriteLine(num);
            //Console.WriteLine("The number {0} is the most frequent (occurs {1} times)", num, maxCnt);
        }
    }
}
