namespace KeyReplacer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class KeyReplacer
    {
        public static void Main()
        {
            var keyString = Console.ReadLine();
            var text = Console.ReadLine();

            var keys = Regex.Split(keyString, @"\||<|\\");
            var startKey = keys.First();
            var endKey = keys.Last();

            var matches = Regex.Matches(text, $"{startKey}(.*?){endKey}");
            var result = new List<string>();
            foreach (Match match in matches)
            {
                if (match.Groups[1].Value != string.Empty)
                {
                result.Add(match.Groups[1].Value);
                }
            }
            if (result.Count>0)
            {
                var resultAsString = new StringBuilder();
                foreach (var word in result)
                {
                    resultAsString.Append(word);
                }
                Console.WriteLine(resultAsString.ToString());
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
