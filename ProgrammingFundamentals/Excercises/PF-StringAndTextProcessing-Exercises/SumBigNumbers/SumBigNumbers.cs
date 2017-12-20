namespace SumBigNumbers
{
    using System;

    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine().TrimStart('0');
            var secNum = Console.ReadLine().TrimStart('0');

            var minLen = Math.Min(firstNum.Length, secNum.Length);
            var maxLen = Math.Max(firstNum.Length, secNum.Length);
            var result = "";
            var residual = 0;

            for (int i = 0; i < minLen; i++)
            {

                var internalSum = residual + firstNum[firstNum.Length - 1 - i] - 48 + secNum[secNum.Length - 1 - i] - 48;
                if (internalSum > 9)
                {
                    if (minLen == maxLen)
                    {
                        if (minLen - 1 - i != 0)
                        {
                            internalSum %= 10;
                            residual = 1;
                        }
                    }
                    else
                    {
                        internalSum %= 10;
                        residual = 1;
                    }
                }
                else
                {
                    residual = 0;
                }
                result = internalSum + result;
            }
            for (int i = 0; i < maxLen - minLen; i++)
            {
                if (firstNum.Length > secNum.Length)
                {
                    var internalSum = residual + firstNum[firstNum.Length - minLen - 1 - i] - 48;
                    if (internalSum > 9)
                    {
                        if (firstNum.Length - minLen - 1 - i != 0)
                        {
                            internalSum %= 10;
                            residual = 1;
                        }
                    }
                    else
                    {
                        residual = 0;
                    }
                    result = internalSum + result;
                }
                else
                {
                    var internalSum = residual + secNum[secNum.Length - minLen - 1 - i] - 48;
                    if (internalSum > 9)
                    {
                        if (secNum.Length - minLen - 1 - i != 0)
                        {
                            internalSum %= 10;
                            residual = 1;
                        }
                    }
                    else
                    {
                        residual = 0;
                    }
                    result = internalSum + result;
                }
            }
            Console.WriteLine(result);
        }
    }
}
