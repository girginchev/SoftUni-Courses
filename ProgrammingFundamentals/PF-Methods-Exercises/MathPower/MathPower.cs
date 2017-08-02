namespace MathPower
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var pow = int.Parse(Console.ReadLine());

            var result = RaiseToPower(num, pow);
            Console.WriteLine(result);
        }

        public static double RaiseToPower(double num, int pow)
        {
            var result = 1d;
            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
