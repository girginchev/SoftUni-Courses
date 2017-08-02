using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"{text[i]} - {text[i] - 97}");
            }
        }
    }
}
