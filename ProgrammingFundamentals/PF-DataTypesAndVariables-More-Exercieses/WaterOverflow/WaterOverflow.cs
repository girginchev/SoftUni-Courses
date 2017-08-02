namespace WaterOverflow
{
    using System;
    public class WaterOverflow
    {
        public static void Main(string[] args)
        {
            byte capacity = 255;
            var totalLiters = 0;
            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var quantity = int.Parse(Console.ReadLine());
                totalLiters += quantity;
                if (totalLiters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalLiters -= quantity;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(totalLiters);
        }
    }
}
