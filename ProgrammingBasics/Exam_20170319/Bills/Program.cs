using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double totalEl = 0;
            double water = 20.0 * months;
            double internet = 15.0 * months;

            for (int i = 0; i < months; i++)
            {
                double el = double.Parse(Console.ReadLine());
                totalEl += el;

            }
            double other = (totalEl + water + internet) * 1.2;
            double averageUtilities = (totalEl + water + internet + other) / months;

            Console.WriteLine("Electricity: {0:f2} lv", totalEl);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", internet);
            Console.WriteLine("Other: {0:f2} lv", other);
            Console.WriteLine("Average: {0:f2} lv", averageUtilities);





        }
    }
}
