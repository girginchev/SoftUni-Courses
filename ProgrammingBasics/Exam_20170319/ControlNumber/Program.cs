using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            int moves = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int e = m; e >= 1; e--)
                {
                    sum += i * 2 + e * 3;
                    moves++;
                    if (sum >= controlNum)
                    {

                        break;
                    }
                }
                if (sum >= controlNum)
                {

                    break;
                }
            }

            if (sum > controlNum)
            {
                Console.WriteLine("{0} moves", moves);
                Console.WriteLine("Score: {0} >= {1}",sum, controlNum);
            }
            else
            {
                Console.WriteLine("{0} moves", moves);
            }
        }
    }
}
