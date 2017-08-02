namespace MultiplayBigNumbers
{
    using System;

    public class MultiplayBigNumbers
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine().TrimStart('0');
            var secNum = int.Parse(Console.ReadLine());

            var result = "";
            var residual = 0;

            if (firstNum == "0" || secNum == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < firstNum.Length; i++)
            {
                var internalSum = residual + (firstNum[firstNum.Length - 1 - i] - 48) * secNum;
                if (internalSum > 9)
                {
                    if (firstNum.Length - 1 - i != 0)
                    {
                        residual = internalSum / 10;
                        internalSum %= 10;
                    }
                }
                else
                {
                    residual = 0;
                }
                result = internalSum + result;
            }
            Console.WriteLine(result);
        }
    }
}
