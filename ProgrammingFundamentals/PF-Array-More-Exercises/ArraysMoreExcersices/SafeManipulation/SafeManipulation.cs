namespace SafeManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class SafeManipulation
    {
        public static void Main()
        {
            var entries = Console.ReadLine().Split().ToArray();
            var command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Reverse":
                        entries = entries.Reverse().ToArray();
                        break;
                    case "Distinct":
                        entries = entries.Distinct().ToArray();
                        break;
                    case "Replace":
                        var index = int.Parse(command[1]);
                        if (index< 0 || index>entries.Length -1)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        var stringForReplace = command[2];
                        entries = ReplacedArray(entries, index, stringForReplace);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", entries));
        }

        public static string[] ReplacedArray(string[] entries, int index, string stringForReplace)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (i == index)
                {
                    entries[i] = stringForReplace;
                }
            }
            return entries;
        }
    }
}

