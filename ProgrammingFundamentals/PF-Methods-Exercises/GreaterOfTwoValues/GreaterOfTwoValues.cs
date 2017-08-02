namespace GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            var valueType = Console.ReadLine();
            var firstValue = Console.ReadLine();
            var secValue = Console.ReadLine();

            switch (valueType)
            {
                case "int":
                    var max = GetMax(int.Parse(firstValue), int.Parse(secValue));
                    Console.WriteLine(max);
                    break;
                case "char":
                    var charMax = GetMax(char.Parse(firstValue), char.Parse(secValue));
                    Console.WriteLine(charMax);
                    break;
                case "string":
                    var stringMax = GetMax(firstValue, secValue);
                    Console.WriteLine(stringMax);
                    break;
            }
            
        }

        public static int GetMax(int v1, int v2)
        {
            if (v1> v2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        public static char GetMax(char v1, char v2)
        {
            if (v1 >v2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        public static string GetMax(string v1, string v2)
        {
            if (v1.CompareTo(v2) > 0)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }
    }
}
