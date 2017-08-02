namespace MakeAWord
{
    using System;
    using System.Text;
    public class MakeAWord
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var word = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                word.Append(symbol);
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
