namespace MultiplicationTable
{
    using System;
    public class MultiplicationTable
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, i , num * i);
            }
        }
    }
}
