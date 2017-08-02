namespace ForeignLanguages
{
    using System;
    public class ForeignLanguages
    {
        public static void Main()
        {
            var country = Console.ReadLine();

            switch (country)
            {
                case "USA": Console.WriteLine("English");
                    break;
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
