namespace SupermarketDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SupermarketDatabase
    {
        public static void Main()
        {
            var entry = Console.ReadLine();
            var productPrice = new Dictionary<string, double>();
            var productQuantites = new Dictionary<string, int>();
            var productTotal = new Dictionary<string, double>();

            while (entry != "stocked")
            {
                var productInfo = entry.Split().ToList();
                var name = productInfo[0];
                var price = double.Parse(productInfo[1]);
                var quantity = int.Parse(productInfo[2]);
                productPrice[name] = price;
                if (!productQuantites.ContainsKey(name))
                {
                    productQuantites[name] = quantity;
                }
                else
                {
                    productQuantites[name] += quantity;
                }

                entry = Console.ReadLine();
            }
            foreach (var price in productPrice)
            {
                
                foreach (var quantity in productQuantites)
                {
                    if (price.Key == quantity.Key)
                    {
                        var total = price.Value * quantity.Value;
                        productTotal[quantity.Key] = total;
                        Console.WriteLine($"{price.Key}: ${price.Value:F2} * {quantity.Value} = ${total:F2}");
                    }
                }
            }

            Console.WriteLine(new string('-',30));
            var grandTotal = productTotal.Select(p => p.Value).Sum();
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
