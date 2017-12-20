namespace OddNumber
{
    using System;
    public class OddNumber
    {
        public static void Main()
        {
            var num = Math.Abs(int.Parse(Console.ReadLine()));
            while (num % 2 ==0)
            {
                Console.WriteLine("Please write an odd number.");
                num = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}
