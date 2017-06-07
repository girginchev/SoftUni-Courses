using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double pricePerKm = 0;

            if (season == "Spring" || season == "Autumn")
            {
                if (kilometers <= 5000)
                {
                    pricePerKm = 0.75;
                }
                else if (kilometers > 5000 && kilometers <= 10000)
                {
                    pricePerKm = 0.95;
                }
                else
                {
                    pricePerKm = 1.45;
                }
            }
            else if (season == "Summer")
            {
                if (kilometers <= 5000)
                {
                    pricePerKm = 0.90;
                }
                else if (kilometers > 5000 && kilometers <= 10000)
                {
                    pricePerKm = 1.10;
                }
                else
                {
                    pricePerKm = 1.45;
                }
            }
            else if (season == "Winter")
            {
                if (kilometers <= 5000)
                {
                    pricePerKm = 1.05;
                }
                else if (kilometers > 5000 && kilometers <= 10000)
                {
                    pricePerKm = 1.25;
                }
                else
                {
                    pricePerKm = 1.45;
                }
            }
            double salary = (kilometers * pricePerKm * 4)*0.90;
            Console.WriteLine("{0:f2}", salary);
        }
    }
}
