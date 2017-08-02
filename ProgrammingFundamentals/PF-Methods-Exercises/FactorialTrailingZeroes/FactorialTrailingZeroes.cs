namespace FactorialTrailingZeroes
{
    using System;
    using System.Numerics;
    public class FactorialTrailingZeroes
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string factorielString = GetFactorialOfN(n).ToString();
            int zeroCounter = 0;
            for (int i = factorielString.Length - 1; i >= 0; i--)
            {
                if (factorielString[i] == '0')
                {
                    zeroCounter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(zeroCounter);
        }

        public static BigInteger GetFactorialOfN(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
