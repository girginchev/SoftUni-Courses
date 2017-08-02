﻿namespace BePositive
{
    using System;
    using System.Collections.Generic;

    public class BePositive
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<long>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                bool found = false;
                for (int j = 0; j < numbers.Count; j++)
                {
                    long currentNum = numbers[j];
                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(currentNum);
                        found = true;
                    }
                    else if (j + 1 < numbers.Count)
                    {
                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(currentNum);
                            found = true;
                        }
                        j++;
                    }

                }
                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                Console.WriteLine();

            }
        }
    }
}
