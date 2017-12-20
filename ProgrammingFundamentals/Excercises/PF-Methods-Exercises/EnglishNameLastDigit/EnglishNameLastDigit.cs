namespace EnglishNameLastDigit
{
    using System;
    public class EnglishNameLastDigit
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            string digit = GetDigitString(n);
            Console.WriteLine(digit);
        }

        public static string GetDigitString(long n)
        {
            
            long lastDigitInt = Math.Abs(n % 10);
            string lastDigitString = "";
            switch (lastDigitInt)
            {
                case 0: lastDigitString = "zero"; break;
                case 1: lastDigitString = "one"; break;
                case 2: lastDigitString = "two"; break;
                case 3: lastDigitString = "three"; break;
                case 4: lastDigitString = "four"; break;
                case 5: lastDigitString = "five"; break;
                case 6: lastDigitString = "six"; break;
                case 7: lastDigitString = "seven"; break;
                case 8: lastDigitString = "eight"; break;
                case 9: lastDigitString = "nine"; break;
                default:
                    break;
            }
            return lastDigitString;
        }
    }
}
