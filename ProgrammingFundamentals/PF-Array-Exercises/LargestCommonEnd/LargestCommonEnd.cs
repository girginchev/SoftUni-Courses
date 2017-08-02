namespace LargestCommonEnd
{
    using System;

    public class LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            var first = Console.ReadLine().Split();
            var second = Console.ReadLine().Split();

            var leftCounter = 0;
            var rightCounter = 0;
            var minLenght = Math.Min(first.Length, second.Length);
            for (int i = 0; i < minLenght; i++)
            {
                if (first[i] == second[i])
                {
                    leftCounter++;
                }
                if (first[first.Length - 1 - i] == second[second.Length - 1 -i])
                {
                    rightCounter++;
                }
            }
            Console.WriteLine(Math.Max(leftCounter,rightCounter));
        }
    }
}
