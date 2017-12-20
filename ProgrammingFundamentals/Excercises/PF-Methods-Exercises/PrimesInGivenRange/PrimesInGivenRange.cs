namespace PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            string primes = string.Join(", ", GetPrimes(startNum, endNum).ToArray());
            Console.WriteLine(primes);

        }
        public static List<int> GetPrimes(int startNum, int endNum)
        {
            var result = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                if (i < 2)
                {
                    isPrime = false;
                }
                for (int e = 2; e < i; e++)
                {
                    if (i % e == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
