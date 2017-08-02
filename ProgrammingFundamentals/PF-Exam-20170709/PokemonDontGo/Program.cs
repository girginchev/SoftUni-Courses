using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Select(long.Parse)
                .ToList();

            var removedPokemons = new List<long>();

            while (true)
            {
                if (pokemons.Count <= 0)
                {
                    break;
                }
                var index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < pokemons.Count)
                {
                    var pokemonForRemoval = pokemons[index];
                    pokemons.RemoveAt(index);
                    removedPokemons.Add(pokemonForRemoval);
                    for (int j = 0; j < pokemons.Count; j++)
                    {
                        if (pokemons[j] <= pokemonForRemoval)
                        {
                            pokemons[j] += pokemonForRemoval;
                        }
                        else
                        {
                            pokemons[j] -= pokemonForRemoval;
                        }
                    }
                }
                else
                {
                    if (index < 0)
                    {
                        var pokemonForRemoval = pokemons[0];
                        pokemons[0] = pokemons[pokemons.Count - 1];
                        removedPokemons.Add(pokemonForRemoval);
                        for (int i = 0; i < pokemons.Count; i++)
                        {
                            if (pokemons[i] <= pokemonForRemoval)
                            {
                                pokemons[i] += pokemonForRemoval;
                            }
                            else
                            {
                                pokemons[i] -= pokemonForRemoval;
                            }
                        }
                    }
                    else if (index > pokemons.Count - 1)
                    {
                        var pokemonForRemoval = pokemons[pokemons.Count - 1];
                        pokemons[pokemons.Count - 1] = pokemons[0];
                        removedPokemons.Add(pokemonForRemoval);
                        for (int i = 0; i < pokemons.Count; i++)
                        {
                            if (pokemons[i] <= pokemonForRemoval)
                            {
                                pokemons[i] += pokemonForRemoval;
                            }
                            else
                            {
                                pokemons[i] -= pokemonForRemoval;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(removedPokemons.Sum());

        }
    }
}
