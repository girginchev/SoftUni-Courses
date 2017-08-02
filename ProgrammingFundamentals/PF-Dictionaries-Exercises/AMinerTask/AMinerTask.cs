namespace AMinerTask
{
    using System;
    using System.Collections.Generic;

    public class AMinerTask
    {
        public static void Main()
        {
            var resource = Console.ReadLine();
            var resources = new Dictionary<string, double>();

            while (resource != "stop")
            {
                double quantity = double.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = quantity;
                }
                else
                {
                    resources[resource] += quantity;
                }


                resource = Console.ReadLine();
            }
            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
