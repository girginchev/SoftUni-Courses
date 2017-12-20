namespace ExchangeVariableValues
{
    using System;
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(@"Before:
                                a = {0}
                                b = {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(@"After:
                                a = {0}
                                b = {1}", a, b);
        }
    }
}
