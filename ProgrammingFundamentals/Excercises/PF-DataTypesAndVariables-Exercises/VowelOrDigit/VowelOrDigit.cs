namespace VowelOrDigit
{
    using System;
    class VowelOrDigit
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());
            if (char.IsNumber(symbol))
            {
                Console.WriteLine("digit");
            }
            else
            {
                switch (symbol)
                {
                    case 'a':
                        Console.WriteLine("vowel");
                        break;
                    case 'o':
                        Console.WriteLine("vowel");
                        break;
                    case 'i':
                        Console.WriteLine("vowel");
                        break;
                    case 'u':
                        Console.WriteLine("vowel");
                        break;
                    case 'y':
                        Console.WriteLine("vowel");
                        break;
                    case 'e':
                        Console.WriteLine("vowel");
                        break;

                    default:
                        Console.WriteLine("other");
                        break;
                }
            
            }
        }
    }
}
