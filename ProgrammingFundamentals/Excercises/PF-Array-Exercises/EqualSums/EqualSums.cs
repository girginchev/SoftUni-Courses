namespace EqualSums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (numbers.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            bool sumExist = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (LeftSum(i, numbers) == RightSum(i, numbers))
                {
                    Console.WriteLine(i);
                    sumExist = true;
                    break;
                }
                
            }
            if (!sumExist)
            {
                Console.WriteLine("no");
            }
        }

        public static int LeftSum(int i, int[] numbers)
        {
            int sum = 0;
            for (int j = 0; j < i; j++)
            {
                sum += numbers[j];
            }
            return sum;
        }
        public static int RightSum(int i, int[] numbers)
        {
            int sum = 0;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                sum += numbers[j];
            }
            return sum;
        }
    }
}
