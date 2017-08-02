namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            var materialQuantity = new Dictionary<string, int>();
            var keyMaterials = new Dictionary<string, int>();
            var junkMaterials = new SortedDictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            
            while (true)
            {
                var materials = Console.ReadLine().Split();
                for (int i = 0; i < materials.Length - 1; i += 2)
                {
                    var quantity = int.Parse(materials[i]);
                    var material = materials[i + 1].ToLower();
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (!keyMaterials.ContainsKey(material))
                        {
                            keyMaterials[material] = 0;
                        }
                        keyMaterials[material] += quantity;
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }
                        junkMaterials[material] += quantity;
                    }
                    if (keyMaterials.Values.Max() >= 250)
                    {
                        if (keyMaterials["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterials["shards"] -= 250;
                            foreach (var mat in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                            {
                                Console.WriteLine($"{mat.Key}: {mat.Value}");
                            }
                            foreach (var mat in junkMaterials)
                            {
                                Console.WriteLine($"{mat.Key}: {mat.Value}");
                            }
                            return;
                        }
                        if (keyMaterials["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterials["fragments"] -= 250;
                            foreach (var mat in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                            {
                                Console.WriteLine($"{mat.Key}: {mat.Value}");
                            }
                            foreach (var mat in junkMaterials)
                            {
                                Console.WriteLine($"{mat.Key}: {mat.Value}");
                            }
                            return;
                        }
                        if (keyMaterials["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterials["motes"] -= 250;
                            foreach (var mat in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                            {
                                Console.WriteLine($"{mat.Key}: {mat.Value}");
                            }
                            foreach (var mat in junkMaterials)
                            {
                                Console.WriteLine($"{mat.Key}: {mat.Value}");
                            }
                            return;
                        }
                    }
                }
            }
        }
    }
}
