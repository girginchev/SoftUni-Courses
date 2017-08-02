namespace UnicodeCharacters
{
    using System;
    using System.Text;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            foreach (var letter in input)
            {
                sb.Append($"\\u{(int)letter:x4}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
