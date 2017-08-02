namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, List<double>>>();
            for (int i = 0; i < n; i++)
            {
                var dragonInfo = Console.ReadLine().Split();
                var type = dragonInfo[0];
                var name = dragonInfo[1];
                var damage = 0d;
                if (dragonInfo[2] == "null")
                {
                    damage = 45d;
                }
                else
                {
                    damage = double.Parse(dragonInfo[2]);
                }
                var health = 0d;
                if (dragonInfo[3] == "null")
                {
                    health = 250d;
                }
                else
                {
                health = double.Parse(dragonInfo[3]);
                }
                var armor = 0d;
                if (dragonInfo[4] == "null")
                {
                    armor = 10d;
                }
                else
                {
                armor = double.Parse(dragonInfo[4]);
                }
                var stats = new List<double>();
                stats.Add(damage);
                stats.Add(health);
                stats.Add(armor);
                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, List<double>>();
                }
                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new List<double>();
                }
                dragons[type][name] = stats;
            }
            foreach (var type in dragons)
            {
                var damage = new List<double>();
                var health = new List<double>();
                var armor = new List<double>();
                foreach (var kpv in type.Value)
                {

                    for (int i = 0; i < kpv.Value.Count; i += 3)
                    {
                        damage.Add(kpv.Value[i]);
                        health.Add(kpv.Value[i + 1]);
                        armor.Add(kpv.Value[i + 2]);
                    }
                }
                Console.WriteLine($"{type.Key}::({damage.Average():F2}/{health.Average():F2}/{armor.Average():F2})");
                foreach (var kpv in type.Value)
                {
                    Console.WriteLine($"-{kpv.Key} -> damage: {kpv.Value[0]}, health: {kpv.Value[1]}, armor: {kpv.Value[2]}");
                }
            }
        }
    }
}
