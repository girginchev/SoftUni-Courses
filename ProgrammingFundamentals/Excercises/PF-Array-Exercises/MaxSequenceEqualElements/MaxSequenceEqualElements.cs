namespace MaxSequenceEqualElements
{
    using System;
    using System.Linq;

    public class MaxSequenceEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counter = 1;
            var maxCounter = 1;
            int[] equalElements = new int[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    counter++;
                    if (counter>maxCounter)
                    {
                        maxCounter = counter;
                        equalElements = new int[maxCounter];
                        for (int j = 0; j < maxCounter; j++)
                        {
                            equalElements[j] = numbers[i];
                        }
                    }
                }
                else
                {
                    counter = 1;
                }           
            }
            Console.WriteLine(string.Join(" ",equalElements));
        }
    }
}
