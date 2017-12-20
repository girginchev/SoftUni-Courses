namespace HelloName
{
    using System;
    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            Greeting(name);
        }

        public static void Greeting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
