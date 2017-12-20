namespace PizzaIngredients
{
    using System;
    using System.Collections.Generic;

    public class PizzaIngredients
    {
        public static void Main()
        {
            var ingredients = Console.ReadLine().Split();
            var lenghtSearched = int.Parse(Console.ReadLine());

            var usedIgredients = new List<string>();
            var ingredientsCounter = 0;

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == lenghtSearched )
                {
                    ingredientsCounter++;
                    Console.WriteLine("Adding {0}.", ingredients[i]);
                    usedIgredients.Add(ingredients[i]);
                    if (ingredientsCounter == 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {ingredientsCounter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",usedIgredients)}.");
        }
    }
}
