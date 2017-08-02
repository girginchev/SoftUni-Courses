namespace FastPrimeChecker
{
    using System;

    class FastPrimeChecker
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= number; currentNum++)
            {
                bool isPrime = true;
                for (int devide = 2; devide <= Math.Sqrt(currentNum); devide++)
                {
                    if (currentNum % devide == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {isPrime}");
            }

        }
    }
}
