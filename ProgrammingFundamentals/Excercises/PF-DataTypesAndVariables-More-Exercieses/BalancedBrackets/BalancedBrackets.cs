namespace BalancedBrackets
{
    using System;

    public class BalancedBrackets
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var lastString = string.Empty;
            bool balanced = true;

            for (int i = 0; i < n; i++)
            {
                var currentString = Console.ReadLine();
                if (currentString == "(")
                {
                    if (lastString == "(")
                    {
                        balanced = false;
                        break;
                    }
                    lastString = "(";
                }
                if (currentString == ")")
                {
                    if (lastString != "(")
                    {
                        balanced = false;
                        break;
                    }
                    lastString = ")";
                }

            }
            if (lastString == "(")
            {
                balanced = false;
            }
            if (balanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
