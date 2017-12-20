namespace GrabAndGo
{
    using System;
    using System.Linq;

    public class GrabAndGo
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var numSearched = long.Parse(Console.ReadLine());
            var found = false;
            long sum = 0;

            for (int i = arr.Length -1; i > 0; i--)
            {
                if (arr[i] == numSearched)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sum += arr[j];
                    }
                    found = true;
                    break;
                }
                if (found)
                {
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
