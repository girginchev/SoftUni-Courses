namespace OnlyLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class OnlyLetters
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"(?<digit>\d+)(?<letter>[A-Za-z])");
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                text= Regex.Replace(text, match.Groups["digit"].Value, match.Groups["letter"].Value);
            }
            Console.WriteLine(text);
        }
    }
}
