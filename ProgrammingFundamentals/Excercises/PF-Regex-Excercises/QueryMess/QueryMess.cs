namespace QueryMess
{
    using System;
    using System.Collections.Generic;

    public class QueryMess
    {
        private static object mew;

        public static void Main()
        {
            var results = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var entries = input.Split(new char[] { '&', '?' });
                foreach (var entry in entries)
                {
                    if (entry.Contains("="))
                    {
                        var correctedEntry = entry.Replace("%20", " ").Replace("+", " ");
                        var en = correctedEntry.Split(new char[] { '=' });
                        if (!results.ContainsKey(en[0].Trim()))
                        {
                            en[1].Trim();
                            var value = "";
                            if (en[1].Contains(" "))
                            {
                                var values = en[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                                foreach (var symbol in values)
                                {
                                    value += symbol + " ";
                                }

                            }
                            else
                            {
                                value = en[1];
                            }
                            value = value.Trim();
                            results[en[0]] = value;
                        }
                        else
                        {
                            en[1].Trim();
                            var value = "";
                            if (en[1].Contains(" "))
                            {
                                var values = en[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                
                                foreach (var symbol in values)
                                {
                                    value += symbol + " ";
                                }
                                
                            }
                            else
                            {
                                value = en[1];
                            }
                            value = value.Trim();
                            results[en[0].Trim()] += ", " + value;
                        }
                    }
                }
                foreach (var result in results)
                {
                    Console.Write($"{result.Key}=[{result.Value}]");
                }
                Console.WriteLine();
                results.Clear();
                input = Console.ReadLine();
            }

        }
    }
}
