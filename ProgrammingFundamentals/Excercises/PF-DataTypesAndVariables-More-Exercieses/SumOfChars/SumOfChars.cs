namespace SumOfChars
{
    using System;
    public class SumOfChars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += (int)symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
