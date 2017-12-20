namespace SortTimes
{
    using System;
    using System.Linq;
    using System.Globalization;
    public class SortTimes
    {
        public static void Main(string[] args)
        {
            var entry = Console.ReadLine().Split().Select(t => DateTime.ParseExact(t, "HH:mm", CultureInfo.InvariantCulture)).ToList();
            var result = entry.OrderBy(t=>t).ToList();
            foreach (var time in result)
            {
                if (time == result.First())
                {
                    Console.Write($"{time:HH:mm}");
                }
                else
                {
                    Console.Write($", {time:HH:mm}");
                }
            }
            Console.WriteLine();
        }
    }
}
