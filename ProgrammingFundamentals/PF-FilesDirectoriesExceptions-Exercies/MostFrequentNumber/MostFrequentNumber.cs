using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("input/input.txt").Split();
            var maxCount = int.MinValue;
            var count = 0;
            var number = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (count>maxCount)
                        {
                            maxCount = count;
                            number = int.Parse(numbers[i]);
                        }
                    }
                }
                count = 0;
            }
            File.WriteAllText("input/output.txt", $"The number {number} is the most frequent (occurs {maxCount} times)");
        }
    }
}
