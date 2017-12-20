namespace MultiplyEvensByOdds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            var num = long.Parse(Console.ReadLine());
            var result = GetNumDigitsEvenSum(num) * GetNumDigitsOddSum(num);
            Console.WriteLine(result);
        }

        public static long GetNumDigitsOddSum(long num)
        {
            long sum = 0;
            while (num != 0)
            {
                var digit = num % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                num /= 10;
            }
            return sum;
        }

        public static long GetNumDigitsEvenSum(long num)
        {
            long sum = 0;
            while (num!=0)
            {
                var digit = num % 10;
                if (digit%2 == 0)
                {
                    sum += digit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
