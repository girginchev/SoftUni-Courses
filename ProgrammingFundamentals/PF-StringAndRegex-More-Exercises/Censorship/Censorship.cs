namespace Censorship
{
    using System;
    using System.Text.RegularExpressions;

    public class Censorship
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            var regex = new Regex(word);

            var result = regex.Replace(text, new string('*', word.Length));
            Console.WriteLine(result);
        }
    }
}
