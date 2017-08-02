using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var populationCounter = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine();

            while (input != "report")
            {
                var line = input.Split('|');
                var town = line[0];
                var country = line[1];
                var population = line[2];
                var populationNumber = long.Parse(population);
                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter[country] = new Dictionary<string, long>();
                }
                if (!populationCounter[country].ContainsKey(town))
                {
                    populationCounter[country][town] = populationNumber;
                }

                input = Console.ReadLine();
            }

            foreach (var country in populationCounter.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
