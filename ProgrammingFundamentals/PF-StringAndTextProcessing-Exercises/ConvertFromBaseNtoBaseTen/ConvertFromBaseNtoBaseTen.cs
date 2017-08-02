namespace ConvertFromBaseNtoBaseTen
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class ConvertFromBaseNtoBaseTen
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim().Split();

            var baseN = int.Parse(input[0]);
            var baseNnumber = BigInteger.Parse(input[1]);
            var baseTen = new List<BigInteger>();
            var baseNnumOfNumbers = 0;
            var baseNnums = new List<BigInteger>();
            while (baseNnumber != 0)
            {
                baseNnumOfNumbers = (int)(baseNnumber % 10);
                baseNnums.Add(baseNnumOfNumbers);
                baseNnumber /= 10;
            }
            baseNnums.Reverse();

            int index = baseNnums.Count - 1;
            foreach (var num in baseNnums)
            {
                baseTen.Add(BigInteger.Multiply(num, BigInteger.Pow(baseN, index)));
                index--;
            }
            BigInteger baseTenSum = 0;
            foreach (var num in baseTen)
            {
                baseTenSum += num;
            }
            Console.WriteLine(baseTenSum); 

        }
    }
}
