namespace FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var adressBook = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = Console.ReadLine();
                adressBook[name] = email;
                name = Console.ReadLine();
            }
            var fixedEmails = adressBook.Where(x => !x.Value.ToLower().EndsWith("us") && !x.Value.ToLower().EndsWith("uk"));
            foreach (var adress in fixedEmails)
            {
                Console.WriteLine($"{adress.Key} -> {adress.Value}");
            }
        }
    }
}
