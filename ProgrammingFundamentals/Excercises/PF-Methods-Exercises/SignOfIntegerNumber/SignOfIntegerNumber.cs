namespace SignOfIntegerNumber
{
    using System;

    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var sign = PrintSign(num);
            Console.WriteLine($"The number {num} is {sign}.");
        }
        public static string PrintSign(int num)
        {
            if (num > 0)
            {
                return "positive";
            }
            else if (num < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        } 
    }
}
