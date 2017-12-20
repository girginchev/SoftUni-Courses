namespace TouristInformation
{
    using System;
    public class TouristInformation
    {
        public static void Main()
        {
            var imperialUnit = Console.ReadLine();
            var value = decimal.Parse(Console.ReadLine());

            var miles = 1.60m;
            var inches = 2.54m;
            var feet = 30.0m;
            var yards = 0.91m;
            var gallons = 3.8m;

            switch (imperialUnit)
            {
                case "miles":
                    Console.WriteLine("{0} miles = {1:F2} kilometers", value, value*miles);
                    break;
                case "inches":
                    Console.WriteLine("{0} inches = {1:F2} centimeters", value, value * inches);
                    break;
                case "feet":
                    Console.WriteLine("{0} feet = {1:F2} centimeters", value, value * feet);
                    break;
                case "yards":
                    Console.WriteLine("{0} yards = {1:F2} meters", value, value * yards);
                    break;
                case "gallons":
                    Console.WriteLine("{0} gallons = {1:F2} liters", value, value * gallons);
                    break;
            }
        }
    }
}
