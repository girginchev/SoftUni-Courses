namespace MilesToKilometers
{
    using System;
    class MilesToKilometers
    {
        static void Main()
        {
            var miles = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", miles * 1.60934m);
        }
    }
}
