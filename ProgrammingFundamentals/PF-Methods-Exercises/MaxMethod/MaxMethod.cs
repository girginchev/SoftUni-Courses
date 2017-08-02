namespace MaxMethod
{
    using System;
    public class MaxMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = GetMax(a, b,c);
            Console.WriteLine(max);
        }
        public static int GetMax(int a, int b, int c)
        {
            int max = 0;
            if (a> b && a > c)
            {
                max = a;
            }
            else if (c > a && c > b)
            {
                max = c;
            }
            else
            {
                max = b;
            }
            return max;
        }      
    }
}
