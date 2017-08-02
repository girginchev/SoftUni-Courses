namespace ParkingValidation
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ParkingValidation
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var regiteredLicensePlates = new Dictionary<string, string>();
            var pattern = @"[A-Z]{2}\d{4}[A-Z]{2}";
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split();
                var command = entry[0];
                var user = entry[1];
                var reg = new Regex(pattern);
                switch (command)
                {
                    case "register": Register(user, entry, reg, regiteredLicensePlates);
                        break;
                    case "unregister": Unregister(user, regiteredLicensePlates);
                        break;
                }
            }
            foreach (var kpv in regiteredLicensePlates)
            {
                Console.WriteLine($"{kpv.Key} => {kpv.Value}");
            }
        }

        public static void Unregister(string user, Dictionary<string, string> regiteredLicensePlates)
        {
            if (!regiteredLicensePlates.ContainsKey(user))
            {
                Console.WriteLine($"ERROR: user {user} not found");
            }
            else
            {
                regiteredLicensePlates.Remove(user);
                Console.WriteLine($"user {user} unregistered successfully");
            }
        }

        public static void Register(string user, string[] entry, Regex reg, Dictionary<string, string> regiteredLicensePlates)
        {
            var licensePlate = entry[2];
            if (regiteredLicensePlates.ContainsKey(user))
            {
                Console.WriteLine($"ERROR: already registered with plate number {regiteredLicensePlates[user]}");
            }
            else if (reg.IsMatch(licensePlate))
            {
                if (!regiteredLicensePlates.ContainsValue(licensePlate))
                {
                    regiteredLicensePlates[user] = licensePlate;
                    Console.WriteLine($"{user} registered {licensePlate} successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: license plate {licensePlate} is busy");
                }
            }
            else
            {
                Console.WriteLine($"ERROR: invalid license plate {licensePlate}");
            }
        }
    }
}
