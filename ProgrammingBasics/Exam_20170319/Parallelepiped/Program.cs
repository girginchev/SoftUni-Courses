using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top
            Console.WriteLine("+" + new string('~', n -2) + "+" + new string('.',2 * n + 1));
            for (int i = 0; i < 2 * n +1; i++)
            {
                Console.Write("|");
                Console.Write(new string('.', i));
                Console.Write("\\" + new string('~', n - 2) + "\\");
                Console.WriteLine(new string('.', 2*n - i));
            }
            //bottom
            for (int i = 0; i < 2 *n + 1; i++)
            {
                Console.Write(new string('.',i));
                Console.Write("\\");
                Console.Write(new string('.',2*n - i));
                Console.WriteLine("|" + new string('~', n - 2) + "|");
            }
            Console.WriteLine(new string('.', 2 * n + 1) + "+" + new string('~', n - 2) + "+");
        }
    }
}
