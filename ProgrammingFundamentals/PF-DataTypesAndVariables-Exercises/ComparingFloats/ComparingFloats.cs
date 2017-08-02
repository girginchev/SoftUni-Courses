namespace ComparingFloats
{
    using System;
    class ComparingFloats
    {
        static void Main()
        {
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            if (Math.Abs(numA - numB) > 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
