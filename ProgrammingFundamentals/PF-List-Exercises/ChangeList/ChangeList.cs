namespace ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChangeList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var commandInformation = Console.ReadLine().Split();
            var command = commandInformation[0];

            while (command != "Odd" && command != "Even")
            {
                switch (command)
                {
                    case "Delete":
                        var element = int.Parse(commandInformation[1]);
                        numbers.RemoveAll(x=>x.Equals(element));
                        break;
                        
                    case "Insert":
                        element = int.Parse(commandInformation[1]);
                        var position = int.Parse(commandInformation[2]);
                        numbers.Insert(position, element);
                        break;
                }
                commandInformation = Console.ReadLine().Split();
                command = commandInformation[0];
            }
            var result = new List<int>();
            if (command == "Odd")
            {
                foreach (var num in numbers)
                {
                    if (num % 2 != 0)
                    {
                        result.Add(num);
                    }
                }
            }
            else
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        result.Add(num);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
