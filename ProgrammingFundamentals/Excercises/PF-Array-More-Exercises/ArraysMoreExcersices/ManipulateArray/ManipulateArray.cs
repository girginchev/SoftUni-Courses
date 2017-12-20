namespace ManipulateArray
{
    using System;
    using System.Linq;

    public class ManipulateArray
    {
        public static void Main()
        {
            var entries = Console.ReadLine().Split().ToArray();
            var numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Reverse": entries = entries.Reverse().ToArray();
                        break;
                    case "Distinct": entries = entries.Distinct().ToArray();
                        break;
                    case "Replace":
                        var index = int.Parse(command[1]);
                        var stringForReplace = command[2];
                        entries = ReplacedArray(entries, index,stringForReplace );
                        break;
                }
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
