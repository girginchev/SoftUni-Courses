namespace MasterNumber
{
    using System;

    public class MasterNumber
    {
        public static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                bool isSimetric = Simetric(i);
                bool isDigitsSumDivisibleBySeven = DigitSumDivisibleBySeven(i);
                bool hasOneEvenDigit = HasOneEvenDigit(i);
                if (isSimetric && isDigitsSumDivisibleBySeven && hasOneEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool HasOneEvenDigit(int i)
        {
            bool evenDigit = false;
            while (i != 0)
            {
                int lastDigit = i % 10;
                i /= 10;
                if (lastDigit % 2 == 0)
                {
                    evenDigit = true;
                    return evenDigit;
                }
            }
            return evenDigit;
        }

        public static bool DigitSumDivisibleBySeven(int i)
        {
            bool isDivisibleBySeven = false;
            int sum = 0;
            while (i !=0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
            {
                isDivisibleBySeven = true;
            }
            return isDivisibleBySeven;
        }

        public static bool Simetric(int i)
        {
            bool isSimetric = true;
            string number = i.ToString();
            for (int e = 0; e < number.Length/2; e++)
            {
                if (number[e] != number[number.Length -1 - e])
                {
                    isSimetric = false;
                    return isSimetric;
                }
            }
            return isSimetric;
        }
    }
}
