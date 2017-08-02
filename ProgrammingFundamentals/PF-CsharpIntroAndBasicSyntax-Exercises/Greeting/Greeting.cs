namespace Greeting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Greeting
    {
        static void Main()
        {
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
