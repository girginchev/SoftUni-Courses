namespace ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceATag
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var regex = new Regex("<a.?href=(.*?)>(.*?)<.*?>");
                var replaced = regex.Replace(input, "[URL href=$1]$2[/URL]");
                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }

        }
    }
}
