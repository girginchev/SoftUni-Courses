namespace StringConcatenation
{
    using System;
    public class StringConcatenation
    {
        public static void Main()
        {
            var seperator = char.Parse(Console.ReadLine());
            var targetLine = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var text = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                var currentWord = Console.ReadLine();
                if (targetLine == "even")
                {
                    if (i % 2 == 0)
                    {
                        text += currentWord + seperator;
                    }
                }
                if (targetLine == "odd")
                {
                    if (i % 2 != 0)
                    {
                        text += currentWord + seperator;
                    }
                }
            }
            Console.WriteLine(text.Remove(text.Length - 1));
        }
    }
}
