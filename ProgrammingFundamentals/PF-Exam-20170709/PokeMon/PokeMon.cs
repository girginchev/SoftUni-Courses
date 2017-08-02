namespace PokeMon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class PokeMon
    {
        public static void Main(string[] args)
        {
            var power = long.Parse(Console.ReadLine());
            var distanceToTarget = long.Parse(Console.ReadLine());
            var exhaustionFactor = long.Parse(Console.ReadLine());
            var orginalPower = power;
            var powerForDivision = orginalPower * 0.50m;

            var pokeCount = 0;

            while (true)
            {
                if (power == powerForDivision)
                {
                    if (power > 0 && exhaustionFactor > 0)
                    {
                    power /= exhaustionFactor;
                    }
                }
                if (power >= distanceToTarget)
                {
                    power -= distanceToTarget;
                    pokeCount++;
                }
                if (power < distanceToTarget)
                {
                    break;
                }

            }
            Console.WriteLine(power);
            Console.WriteLine(pokeCount);
        }
    }
}
