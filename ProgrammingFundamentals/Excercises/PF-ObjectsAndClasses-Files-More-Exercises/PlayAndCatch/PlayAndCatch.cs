namespace PlayAndCatch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PlayAndCatch
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();

            var exceptionCounter = 0;
            while (true)
            {
                var entry = Console.ReadLine().Split();
                var command = entry[0];
                switch (command)
                {
                    case "Replace":
                        try
                        {
                            var index = int.Parse(entry[1]);
                            if (index < 0 || index >= line.Count)
                            {
                                Console.WriteLine("The index does not exist!");
                                exceptionCounter++;
                                break;
                            }
                            var element = int.Parse(entry[2]);
                            line.RemoveAt(index);
                            line.Insert(index, element);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("“The variable is not in the correct format!”");
                            exceptionCounter++;
                        }
                        break;
                    case "Print":
                        try
                        {
                            var startIndex = int.Parse(entry[1]);
                            if (startIndex < 0 || startIndex >= line.Count)
                            {
                                Console.WriteLine("The index does not exist!");
                                exceptionCounter++;
                                break;
                            }
                            var endIndex = int.Parse(entry[2]);

                            if (endIndex < 0 || endIndex >= line.Count)
                            {
                                Console.WriteLine("The index does not exist!");
                                exceptionCounter++;
                                break;
                            }
                            var result = new List<int>();
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                result.Add(line[i]);
                            };
                            Console.WriteLine(string.Join(", ", result));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("“The variable is not in the correct format!”");
                            exceptionCounter++;
                        }
                        break;
                    case "Show":
                        try
                        {
                            var index = int.Parse(entry[1]);
                            if (index < 0 || index >= line.Count)
                            {
                                Console.WriteLine("The index does not exist!");
                                exceptionCounter++;
                            }
                            else
                            {
                                Console.WriteLine(line[index]);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptionCounter++;
                        }
                        break;
                        
                }
                if (exceptionCounter == 3)
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(", ", line));
        }
    }
}
