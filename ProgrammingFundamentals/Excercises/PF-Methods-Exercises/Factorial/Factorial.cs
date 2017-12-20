namespace Factorial
{
    using System;
    using System.Numerics;
    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            GetFactorialOfN(n);
        }

        public static void GetFactorialOfN(int n)
        {
            BigInteger temp = 1;
            for (int i = 1; i <= n; i++)
            {
                temp *= i;
            }
            Console.WriteLine(temp);
        }
    }
}
