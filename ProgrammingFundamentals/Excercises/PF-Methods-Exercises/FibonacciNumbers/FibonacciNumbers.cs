namespace FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            int fibunacciNum = int.Parse(Console.ReadLine());

            int resultFubNum = GetFibunacciNumber(fibunacciNum);
            Console.WriteLine(resultFubNum);
        }

        public static int GetFibunacciNumber(int fibunacciNum)
        {
            var firstNum = 0;
            var secNum = 1;
            int thirdNum = 1;

            for (int i = 0; i < fibunacciNum; i++)
            {
                thirdNum = firstNum + secNum;
                firstNum = secNum;
                secNum = thirdNum;
            }
            return thirdNum;
        }
    }
}
