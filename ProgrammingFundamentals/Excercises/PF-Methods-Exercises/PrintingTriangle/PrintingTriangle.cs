namespace PrintingTriangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                PrintLine(i);
            }
            for (int i = num -1; i >=1; i--)
            {
                PrintLine(i);
            }
        }

        public static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
