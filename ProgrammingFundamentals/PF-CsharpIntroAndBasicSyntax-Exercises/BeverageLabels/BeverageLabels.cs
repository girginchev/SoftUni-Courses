namespace BeverageLabels
{
    using System;
    class BeverageLabels
    {
        static void Main()
        {
            var productName = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());

            var energy = (volume / 100.0) * energyPer100ml;
            var sugar = (volume / 100.0) * sugarPer100ml;

            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
