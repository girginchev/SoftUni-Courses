namespace IndexOfLetters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            foreach (char letter in input)
            {
                Console.WriteLine("{0} -> {1}", letter, letter - 'a');
            }
        }
    }
}
