namespace MultiplicationTable2._0
{
    using System;
    public class MultiplicationTable2
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            if (multiplier > 10 )
            {
                Console.WriteLine("{0} X {1} = {2}", num, multiplier, num * multiplier);
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
                }
            }

        }
    }
}
