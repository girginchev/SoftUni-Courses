namespace SerbianUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SerbianUnleashed
    {
        public static void Main()
        {
            var serbianSingers = new Dictionary<string, Dictionary<string, int>>();
            var entry = Console.ReadLine();

            while (entry != "End")
            {
                var tokens = entry.Split('@');
                var singerName = tokens[0].Trim();
                var concertsInfo = tokens[1].Split(' ').ToList();
                var venues = new List<string>();
                for (int i = 0; i < concertsInfo.Count - 2; i++)
                {
                    venues.Add(concertsInfo[i]);
                }
                var venue = string.Join(" ", venues);

                int ticketPrice = int.Parse(concertsInfo[concertsInfo.Count - 2]);
                int ticketsCount = int.Parse(concertsInfo[concertsInfo.Count - 1]);
                var money = ticketsCount * ticketPrice;
                if (!serbianSingers.ContainsKey(venue))
                {
                    serbianSingers[venue] = new Dictionary<string, int>();
                }
                if (!serbianSingers[venue].ContainsKey(singerName))
                {
                    serbianSingers[venue][singerName] = 0;
                }
                serbianSingers[venue][singerName] += money;
                entry = Console.ReadLine();
            }
            foreach (var venue in serbianSingers)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }


    }
}
