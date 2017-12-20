namespace ConvertFromBase10toBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class ConvertFromBase10toBaseN
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            var baseN = input[0];
            var baseTen = input[1];
            var baseNnumber = new List<int>();
            var result = string.Empty;

            while (baseTen > 0)
            {
                baseNnumber.Add((int)(baseTen % baseN));
                baseTen /= baseN;
            }
            baseNnumber.Reverse();
            foreach (var number in baseNnumber)
            {
                result += number.ToString();
            }
            Console.WriteLine(result);
        }
    }
}
