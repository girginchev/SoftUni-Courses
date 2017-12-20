namespace PrintPartASCIITable
{
    using System;
    class PrintPartASCIITable
    {
        static void Main(string[] args)
        {
            int firstSymbol = int.Parse(Console.ReadLine());
            int lastSymbol = int.Parse(Console.ReadLine());

            for (char i = (char)firstSymbol; i <= (char)lastSymbol; i++)
            {
                Console.Write(i + " ");
                
            }
            Console.WriteLine();
        }
    }
}
