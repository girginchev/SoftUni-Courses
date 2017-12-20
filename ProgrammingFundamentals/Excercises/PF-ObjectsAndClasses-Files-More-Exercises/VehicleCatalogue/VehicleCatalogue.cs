namespace VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public int HorsePower { get; set; }

    }
    public class VehicleCatalogue
    {
        public static void Main()
        {
            var entry = Console.ReadLine();
            var vehicles = new List<Vehicle>();
            while (entry != "End")
            {
                var tokens = entry.Split();
                var vehicle = new Vehicle
                {
                    Type = tokens[0].ToLower(),
                    Model = tokens[1].ToLower(),
                    Colour = tokens[2].ToLower(),
                    HorsePower = int.Parse(tokens[3])
                };
                vehicles.Add(vehicle);
                entry = Console.ReadLine();
            }

            var vehModels = Console.ReadLine();
            while (vehModels != "Close the Catalogue")
            {

                foreach (var v in vehicles)
                {
                    if (v.Model == vehModels.ToLower())
                    {
                        Console.WriteLine($"Type: {v.Type.First().ToString().ToUpper() + string.Join("",v.Type.Skip(1))}");
                        Console.WriteLine($"Model: {v.Model.First().ToString().ToUpper() + string.Join("",v.Model.Skip(1))}");
                        Console.WriteLine($"Color: {v.Colour}");
                        Console.WriteLine($"Horsepower: {v.HorsePower}");
                    }
                }
                vehModels = Console.ReadLine();
            }
            if (vehicles.Any(t=>t.Type == "car"))
            {
            Console.WriteLine($"Cars have average horsepower of: {vehicles.Where(v=>v.Type == "car").Select(v=>v.HorsePower).Average():F2}.");
            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            if (vehicles.Any(t => t.Type == "truck"))
            {
            Console.WriteLine($"Trucks have average horsepower of: {vehicles.Where(v => v.Type == "truck").Select(v => v.HorsePower).Average():F2}.");
            }
            else
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }

        }
    }
}
