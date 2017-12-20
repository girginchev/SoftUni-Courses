using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            var lines = File.ReadAllLines(@"..\..\input.txt");
            foreach (var line in lines)
            {
                var numbers = line.Split().Select(int.Parse).ToArray();
                bool found = true;
                if (numbers.Length <= 1)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    for (int i = 1; i < numbers.Length; i++)
                    {

                        var leftSum = 0;
                        var rightSum = 0;
                        for (int left = i - 1; left >= 0; left--)
                        {

                            leftSum += numbers[left];
                        }

                        for (int right = i + 1; right < numbers.Length; right++)
                        {

                            rightSum += numbers[right];
                        }
                        if (leftSum == rightSum)
                        {
                            Console.WriteLine(i);
                            found = true;
                            break;
                        }
                        else
                        {
                            found = false;
                        }
                    }
                }
                if (!found)
                {
                    Console.WriteLine("no");
                }
            }



        }
    }
}
