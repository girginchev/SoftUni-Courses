namespace ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;
    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var pattern = $@"\b{word}\b";

            var regex = new Regex(pattern);
            foreach (var sentence in text)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
