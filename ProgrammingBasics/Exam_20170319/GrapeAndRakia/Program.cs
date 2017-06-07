using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double vineyeardSqr = double.Parse(Console.ReadLine());
            double kilosFromOneSqr = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double totalKilos = vineyeardSqr * kilosFromOneSqr;
            totalKilos = totalKilos - waste;
            double grapeKilosForRakia = totalKilos * 0.45;
            double grapeKilosForSale = totalKilos * 0.55;

            double kilosRakia = grapeKilosForRakia / 7.50;

            double incomeRakia = kilosRakia * 9.80;
            double incomeGrape = grapeKilosForSale * 1.50;

            Console.WriteLine("{0:f2}", incomeRakia);
            Console.WriteLine("{0:f2}", incomeGrape);

        }
    }
}
