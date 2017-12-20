namespace DecryptingMessage
{
    using System;
    public class DecryptingMessage
    {
        public static void Main()
        {
            var key = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var decryptedText = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                decryptedText += (char)(symbol + key);
            }
            Console.WriteLine(decryptedText);
        }
    }
}
