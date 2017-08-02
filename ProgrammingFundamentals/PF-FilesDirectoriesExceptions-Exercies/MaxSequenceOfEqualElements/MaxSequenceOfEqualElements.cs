using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("input/input.txt").Split().Select(int.Parse).ToArray();
            var count = 1;
            var bestLengt = int.MinValue;
            var bestNum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > bestLengt)
                    {
                        bestLengt = count;
                        bestNum = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }

            }

            var result = new int[bestLengt];
            for (int i = 0; i < bestLengt; i++)
            {
                result[i] = bestNum;
            }

            File.AppendAllText("input/output.txt", string.Join(" ", result) + Environment.NewLine);
        }
    }
}
