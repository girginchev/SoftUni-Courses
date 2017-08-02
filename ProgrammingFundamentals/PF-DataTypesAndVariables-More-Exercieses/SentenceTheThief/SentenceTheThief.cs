namespace SentenceTheThief
{
    using System;
    public class SentenceTheThief
    {
        public static void Main()
        {
            var numberalType = Console.ReadLine();
            long maxValue = 0;

            switch (numberalType)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    maxValue = long.MaxValue;
                    break;
            }

            var n = int.Parse(Console.ReadLine());
            long thief = 0;
            long close = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                var id = long.Parse(Console.ReadLine());
                if (id <= maxValue && id >= close)
                {
                    thief = id;
                    close = id;
                }
            }
            sbyte num = 0;
            if (thief > 0)
            {
                num = sbyte.MaxValue;
            }
            else
            {
                num = sbyte.MinValue;
            }
            var sentence = Math.Ceiling((double)thief / num);
            if (sentence > 1)
            {
                Console.WriteLine($"Prisoner with id {thief} is sentenced to {sentence} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thief} is sentenced to {sentence} year");
            }
        }
    }
}
