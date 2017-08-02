using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Pokemon
    {
        public string Type { get; set; }

        public int Index { get; set; }
    }
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pokemons = new Dictionary<string, List<Pokemon>>();

            while (input != "wubbalubbadubdub")
            {
                var line = Regex.Split(input, @"->").Select(x => x.Trim()).ToArray();
                if (line.Length > 1)
                {
                    var name = line[0];
                    var type = line[1];
                    var index = int.Parse(line[2]);
                    var pokemon = new Pokemon();
                    pokemon.Index = index;
                    pokemon.Type = type;
                    if (!pokemons.ContainsKey(name))
                    {
                        pokemons[name] = new List<Pokemon>();
                    }
                    pokemons[name].Add(pokemon);

                    input = Console.ReadLine();
                }
                else
                {
                    var name = line[0];
                    if (pokemons.ContainsKey(name))
                    {
                        foreach (var p in pokemons)
                        {
                            if (p.Key == name)
                            {
                                Console.WriteLine($"# {p.Key}");
                                foreach (var kpv in p.Value)
                                {
                                    Console.WriteLine($"{kpv.Type} <-> {kpv.Index}");
                                }
                            }
                        }
                    }
                    input = Console.ReadLine();
                }
            }
            foreach (var p in pokemons)
            {
                Console.WriteLine($"# {p.Key}");
                foreach (var kpv in p.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine($"{kpv.Type} <-> {kpv.Index}");
                }
            }
        }
    }
}
