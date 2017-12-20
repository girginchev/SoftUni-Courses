namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;
    public class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"(?<=\s)[A-Za-z0-9]+([-._]\w*)*@[A-Za-z]+([-._\w*])*(\.[a-z]+)";

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                if (!match.Value.StartsWith("-") && !match.Value.StartsWith(".") && !match.Value.StartsWith("_"))
                {
                    Console.WriteLine(match.Value);
                }

            }
        }
    }
}
