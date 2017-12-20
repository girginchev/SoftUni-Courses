namespace Hideout
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class Hideout
    {
        public static void Main()
        {
            var map = Console.ReadLine();
            var elements = Console.ReadLine();
            var result = new List<string>();

            while (true)
            {
                var searchedElements = elements.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var searchedElement = searchedElements[0];
                var minCount = int.Parse(searchedElements[1]);
                var regex = new Regex($@"\{searchedElement}{{{minCount},}}");
                if (regex.IsMatch(map))
                {
                    Console.WriteLine($"Hideout found at index {regex.Match(map).Index} and it is with size {regex.Match(map).Value.Length}!");
                    break;
                }
                else
                {
                    elements = Console.ReadLine();
                }
            }
        }
    }
}
