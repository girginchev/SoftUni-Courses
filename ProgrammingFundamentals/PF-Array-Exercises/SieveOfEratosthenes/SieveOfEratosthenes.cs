namespace SieveOfEratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;
            for (int i = 0; i <= n; i++)
            {
                if (primes[i])
                {
                    for (int j = 2; j*i <= n; j++)
                    {
                            primes[i * j] = false;
                    }
                }       
            }
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.WriteLine(i + " ");
                }
            }
            //for (int i = 2; i <= n; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.Write("{0} ",i);
            //    }
            //}
        }
    }
}
