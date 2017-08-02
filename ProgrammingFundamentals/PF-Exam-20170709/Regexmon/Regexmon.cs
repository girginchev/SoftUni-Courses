using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var didimonRegex = new Regex(@"([^A-Za-z-]+)");
            var bojomonRegex = new Regex(@"([A-Za-z]+-[A-Za-z]+)");
            var index = 1;
            while (true)
            {
                if (!didimonRegex.IsMatch(line))
                {
                    break;
                }
                var match = didimonRegex.Match(line).ToString();
                index = line.IndexOf(match);
                Console.WriteLine(match);
                line = line.Remove(0, index - 1 + match.Length);
                if (!bojomonRegex.IsMatch(line))
                {
                    break;
                }
                var secondMatch = bojomonRegex.Match(line).ToString();
                index = line.IndexOf(secondMatch);
                Console.WriteLine(secondMatch);
                line = line.Remove(0, index - 1 + secondMatch.Length);
            }

        }
    }
}
