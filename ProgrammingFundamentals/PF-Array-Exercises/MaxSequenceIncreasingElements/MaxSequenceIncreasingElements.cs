namespace MaxSequenceIncreasingElements
{
    using System;
    using System.Linq;

    public class MaxSequenceIncreasingElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counter = 1;
            var maxCount = 1;
            int[] increasingArray = new int[0];
            //3 2 3 4 2 2 4

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i -1])
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        increasingArray = new int[maxCount];
                        for (int j = 0, k = i - maxCount + 1; j < maxCount && k <= maxCount + 1; j++, k++)
                        {
                            increasingArray[j] = numbers[k];
                        }
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(string.Join(" ",increasingArray));
        }
    }
}
