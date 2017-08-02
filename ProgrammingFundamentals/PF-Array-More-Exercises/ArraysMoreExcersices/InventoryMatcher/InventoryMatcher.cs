namespace InventoryMatcher
{
    using System;
    using System.Linq;

    public class InventoryMatcher
    {
        public static void Main()
        {
            var products = Console.ReadLine().Split();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            var productRequest = Console.ReadLine();
            while (productRequest != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (productRequest == products[i])
                    {
                        Console.WriteLine($"{products[i]} costs: {prices[i]}; Available quantity: {quantities[i]}");
                    }
                }
                productRequest = Console.ReadLine();
            }
        }
    }
}
