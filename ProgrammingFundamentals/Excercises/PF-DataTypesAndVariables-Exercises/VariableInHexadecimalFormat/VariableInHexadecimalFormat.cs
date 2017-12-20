namespace VariableInHexadecimalFormat
{
    using System;
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            
            Console.WriteLine(Convert.ToInt32(num, 16));
        }
    }
}
