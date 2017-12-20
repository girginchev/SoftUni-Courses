namespace PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            bool isPrime = isPrimeNumer(n);
            Console.WriteLine(isPrime);
        }
        public static bool isPrimeNumer(long n)
        {
            bool isPrime = true;
            if (n < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            return isPrime;
        }

    }
}
