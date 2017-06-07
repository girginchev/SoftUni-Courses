using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double sqrStyrofoamPacket = double.Parse(Console.ReadLine());
            double pricePacketStyrofoam = double.Parse(Console.ReadLine());

            double windowSqr = 2.40;

            double netHouseArea = (houseArea - (windows * windowSqr)) * 1.10 ;
            double requiredPackets = Math.Ceiling(netHouseArea / sqrStyrofoamPacket);
            double moneyRequired = requiredPackets * pricePacketStyrofoam;

            

            if (moneyRequired > budget)
            {
                Console.WriteLine("Need more: {0:f2}",moneyRequired - budget);
            }
            else
            {
                Console.WriteLine("Spent: {0:f2}", moneyRequired);
                Console.WriteLine("Left: {0:f2}", budget - moneyRequired);
            }

        }
    }
}
