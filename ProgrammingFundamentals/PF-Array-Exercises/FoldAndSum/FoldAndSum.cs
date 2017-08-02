namespace FoldAndSum
{
    using System;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbersString = Console.ReadLine().Split(' ');

            long[] numbers = SplitInput(numbersString);

            //separate numbers in four arrays

            long[] firstKNumbers = new long[numbers.Length / 4];
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                firstKNumbers[i] = numbers[i];
            }

            long[] secondKNumbers = new long[numbers.Length / 4];
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                secondKNumbers[i] = numbers[i + numbers.Length / 4];
            }

            long[] thirdKNumbers = new long[numbers.Length / 4];
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                thirdKNumbers[i] = numbers[i + numbers.Length / 2];
            }

            long[] lastKNumbers = new long[numbers.Length / 4];
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                lastKNumbers[i] = numbers[i + numbers.Length / 4 * 3];
            }


            //reverse first array
            long[] reversedFirstArray = new long[numbers.Length / 4];
            for (int j = 0; j < firstKNumbers.Length; j++)
            {
                reversedFirstArray[j] = firstKNumbers[j];
            }
            for (int j = 0; j < firstKNumbers.Length / 2; j++)
            {
                reversedFirstArray[j] = firstKNumbers[firstKNumbers.Length - 1 - j];
            }
            for (int j = 0; j < firstKNumbers.Length / 2; j++)
            {
                reversedFirstArray[reversedFirstArray.Length - 1] = firstKNumbers[j];
            }

            //reverse last array
            long[] reversedLastArray = new long[numbers.Length / 4];
            for (int j = 0; j < firstKNumbers.Length; j++)
            {
                reversedLastArray[j] = lastKNumbers[j];
            }
            for (int j = 0; j < lastKNumbers.Length / 2; j++)
            {
                reversedLastArray[j] = lastKNumbers[lastKNumbers.Length - 1 - j];
            }
            for (int j = 0; j < lastKNumbers.Length / 2; j++)
            {
                reversedLastArray[reversedLastArray.Length - 1] = lastKNumbers[j];
            }

            //sum first and second array
            long[] sum = new long[reversedFirstArray.Length];
            for (int i = 0; i < reversedFirstArray.Length; i++)
            {
                sum[i] = reversedFirstArray[i] + secondKNumbers[i];
            }

            //sum third and last array
            long[] sum2 = new long[reversedLastArray.Length];
            for (int i = 0; i < reversedLastArray.Length; i++)
            {
                sum2[i] = reversedLastArray[i] + thirdKNumbers[i];
            }

            Console.WriteLine(string.Join(" ", sum) + " " + string.Join(" ",sum2));

        }

        public static long[] SplitInput(string[] numbersString)
        {
            long[] numbers = new long[numbersString.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(numbersString[i]);
            }
            return numbers;
        }
    }
}
