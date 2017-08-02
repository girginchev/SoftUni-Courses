namespace BeerKegs
{
    using System;
    public class BeerKegs
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var biggestKeg = 0.0;
            var result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                var volume = Math.Pow(radius, 2) * height * Math.PI;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    result = model;
                }
            }
        Console.WriteLine(result);
        }
    }
}
