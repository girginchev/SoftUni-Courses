namespace DrawAFilledSquare
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DrawAFilledSquare
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            PrintHeaderRow(num);
            PrintMiddleRow(num);
            PrintHeaderRow(num);
        }

        public static void PrintMiddleRow(int num)
        {
            for (int i = 0; i < num -2 ; i++)
            {
                Console.Write('-');
                for (int j = 1; j < num; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        public static void PrintHeaderRow(int num)
        {
            Console.WriteLine(new string('-', 2*num));
        }
    }
}
