namespace ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class ValidUsernames
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' },StringSplitOptions.RemoveEmptyEntries);
            var pattern = @"\b([a-zA-z]\w{2,25}\b)";
            var regex = new Regex(pattern);
            var matches = new List<string>();
            foreach (var user in text)
            {
                if (regex.IsMatch(user))
                {
                    matches.Add(user);
                }
            }
            var len = 0;
            var maxLenght = int.MinValue;
            var firstLongestUsername = string.Empty;
            var secondLongestUsername = string.Empty;
            
            for (int i = 0; i < matches.Count - 1; i++)
            {
                len = matches[i].Length + matches[i + 1].Length;
                if (len > maxLenght)
                {
                    maxLenght = len;
                    firstLongestUsername = matches[i];
                    secondLongestUsername = matches[i + 1];
                }
            }
            Console.WriteLine(firstLongestUsername);
            Console.WriteLine(secondLongestUsername);
        }
    }
}
