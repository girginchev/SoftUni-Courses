namespace UseYourChainsBuddy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"<p>.+?<\/p>");
            var matches = regex.Matches(text);
            var entries = new List<string>();
            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                entries.Add(match.Value.Substring(3, match.Value.Length - 7));
            }
            foreach (var entry in entries)
            {
                foreach (char symbol in entry)
                {
                    if (symbol == 'a' || symbol == 'b' || symbol == 'c' || symbol == 'd' || symbol == 'e' || symbol == 'f' || symbol == 'g' ||
                     symbol == 'h' || symbol == 'i' || symbol == 'j' || symbol == 'k' || symbol == 'l' || symbol == 'm')
                    {
                        sb.Append((char)(symbol + 13));
                    }
                    else if (symbol == 'n' || symbol == 'o' || symbol == 'p' || symbol == 'q' || symbol == 'r' || symbol == 's' || symbol == 't' ||
                        symbol == 'u' || symbol == 'v' || symbol == 'w' || symbol == 'x' || symbol == 'y' || symbol == 'z')
                    {
                        sb.Append((char)(symbol - 13));
                    }
                    else if (symbol == '0' || symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' ||
                        symbol == '7' || symbol == '8' || symbol == '9')
                    {
                        sb.Append((char)(symbol));
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }

            }

            var resultList = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = "";
            foreach (var item in resultList)
            {
                result += item + " ";
            }
            Console.WriteLine(result);

        }
    }
}
