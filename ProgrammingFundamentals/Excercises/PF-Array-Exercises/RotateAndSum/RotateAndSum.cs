namespace RotateAndSum
{
    using System;

    public class RotateAndSum
    {
        public static void Main(string[] args)
        {
            var arrNumbers = Console.ReadLine().Split(' ');
            int rotations = int.Parse(Console.ReadLine());

            int[] numbers = GetIntArray(arrNumbers);

            int[] sum = new int[numbers.Length];
            for (int i = 0; i < rotations; i++)
            {
                int temp = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = temp;
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        public static int[] GetIntArray(string[] arrNumbers)
        {
            var numbers = new int[arrNumbers.Length];
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                numbers[i] = int.Parse(arrNumbers[i]);
            }

            return numbers;
        }
    }
}
