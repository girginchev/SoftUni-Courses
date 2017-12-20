namespace UpgradedMatcher
{
    using System;
    using System.Linq;

    public class UpgradedMatcher
    {
        public static void Main()
        {
            var products = Console.ReadLine().Split();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            var entry = Console.ReadLine();
            while (entry != "done")
            {
                var producRequest = entry.Split();
                var product = producRequest[0];
                var quantity = long.Parse(producRequest[1]);
                for (int i = 0; i < products.Length; i++)
                {
                    if (product == products[i])
                    {
                        long quantityAvailable = 0;
                        if (i >= 0 && i < quantities.Length)
                        {
                            quantityAvailable = quantities[i];
                        }
                        if (quantityAvailable >= quantity)
                        {
                            Console.WriteLine("{0} x {1} costs {2:F2}", products[i], quantity, quantity * prices[i]);
                            quantities[i] -= quantity;
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {products[i]}");
                        }
                        break;
                    }
                }
                entry = Console.ReadLine();
            }
        }
    }
}
