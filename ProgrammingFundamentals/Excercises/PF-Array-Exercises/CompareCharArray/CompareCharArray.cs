namespace CompareCharArray
{
    using System;
    using System.Linq;

    public class CompareCharArray
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            var shorterArray = Math.Min(firstArray.Length, secondArray.Length);
            bool smallerLetter = false;

            for (int i = 0; i < shorterArray; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        smallerLetter = true;
                        break;
                    }
                    else
                    {
                        smallerLetter = false;
                        break;
                    }
                }
                if (firstArray[i] == secondArray[i])
                {
                    if (firstArray.Length > secondArray.Length)
                    {
                        smallerLetter = true;
                        break;
                    }
                    else
                    {
                        smallerLetter = false;
                        break;
                    }
                }
            }
            if (smallerLetter)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
            else
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            } 
        }
    }
}
