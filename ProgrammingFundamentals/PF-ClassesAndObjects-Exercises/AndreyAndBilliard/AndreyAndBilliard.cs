namespace AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AndreyAndBilliard
    {
        public static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            var products = new Dictionary<string, decimal>();
            var customers = new List<Customer>();
            for (int i = 0; i < entries; i++)
            {
                var entry = Console.ReadLine().Split('-');
                var productName = entry[0];
                var productPrice = decimal.Parse(entry[1]);
                if (!products.ContainsKey(productName))
                {
                    products[productName] = 0.0m;
                }
                products[productName] = productPrice;
            }

            var order = Console.ReadLine();
            while (order != "end of clients")
            {
                var orderComponents = order.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var customer = orderComponents[0];
                var product = orderComponents[1];
                var quantity = decimal.Parse(orderComponents[2]);
                var price = 0m;
                foreach (var p in products)
                {
                    if (p.Key == product)
                    {
                        price = p.Value;
                    }
                }

                if (products.ContainsKey(product))
                {
                    if (!customers.Any(x=>x.Name == customer))
                    {
                        var customerOrder = new Customer();
                        customerOrder.Name = customer;
                        customerOrder.Product = product;
                        customerOrder.Quantity = quantity;
                        customerOrder.Price = price;
                        customers.Add(customerOrder);
                    }
                    else
                    {
                        foreach (var c in customers)
                        {
                            if (c.Name == customer)
                            {
                                c.Quantity += quantity;
                            }
                        }
                    }

                }
                order = Console.ReadLine();
            }

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{customer.Name}");
                Console.WriteLine($"-- {customer.Product} - {customer.Quantity}");
                Console.WriteLine($"Bill: {customer.Bill():F2}");
            }
            Console.WriteLine($"Total bill: {customers.Select(x => x.Bill()).Sum():F2}");
        }
    }
}

