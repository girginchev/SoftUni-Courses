using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var specialBombNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           
            var sum = 0;
            while (numbers.Contains(specialBombNumbers[0]))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (specialBombNumbers[0] == numbers[i])
                    {
                        if (i == 0)
                        {
                            numbers.RemoveRange(Math.Max(i - specialBombNumbers[1], 0), Math.Min(specialBombNumbers[1] + 1, numbers.Count - Math.Max(i - specialBombNumbers[1], 0)));
                        }
                        else
                        {
                            numbers.RemoveRange(Math.Max(i - specialBombNumbers[1], 0), Math.Min(2 * specialBombNumbers[1] + 1, numbers.Count - Math.Max(i - specialBombNumbers[1], 0)));
                        }
                    }
                }

            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
