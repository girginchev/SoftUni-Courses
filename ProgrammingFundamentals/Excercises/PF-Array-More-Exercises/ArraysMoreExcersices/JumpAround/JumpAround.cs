namespace JumpAround
{
    using System;
    using System.Linq;

    public class JumpAround
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = 0;

            for (int i = 0; i < arr.Length;)
            {
                sum += arr[i];
                if (arr[i] + i <= arr.Length)
                {
                    i += arr[i];
                }
                else if (i - arr[i] >= 0)
                {
                    i -= arr[i];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
