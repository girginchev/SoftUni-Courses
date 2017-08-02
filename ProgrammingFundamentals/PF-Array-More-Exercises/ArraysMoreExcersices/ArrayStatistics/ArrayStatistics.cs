namespace ArrayStatistics
{
    using System;
    using System.Linq;

    public class ArrayStatistics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine("Min = {0}",numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Average = {0}", numbers.Average());
        }
    }
}
