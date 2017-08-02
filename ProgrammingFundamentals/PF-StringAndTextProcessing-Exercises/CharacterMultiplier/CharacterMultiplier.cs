namespace CharacterMultiplier
{
    using System;
    using System.Numerics;
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstString = input[0];
            var secondString = input[1];
            var minLenght = Math.Min(firstString.Length, secondString.Length);
            var sum = 0;

            for (int i = 0; i < minLenght; i++)
            {
                sum += (int)firstString[i] * (int)secondString[i];
            }

            var longerString = firstString.Length > secondString.Length ? firstString : secondString;

            for (int i = minLenght; i < longerString.Length; i++)
            {
                sum += (int)longerString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
