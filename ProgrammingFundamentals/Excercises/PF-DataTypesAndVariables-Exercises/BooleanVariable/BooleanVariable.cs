namespace BooleanVariable
{
    using System;

    class BooleanVariable
    {
        static void Main()
        {
            string text = Console.ReadLine();
            bool isCorrect = Convert.ToBoolean(text);

            Console.WriteLine(isCorrect ? "Yes" : "No");
        }
    }
}
