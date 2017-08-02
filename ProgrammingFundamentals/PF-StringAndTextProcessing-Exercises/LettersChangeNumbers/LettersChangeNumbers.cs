namespace LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var alphabetLowerCase = new Dictionary<char, double>();
            var alphabetUpperCase = new Dictionary<char, double>();
            for (int i = 0; i < 26; i++)
            {
                alphabetUpperCase.Add((char)('A' + i), 1 + i);
            }
            for (int i = 0; i < 26; i++)
            {
                alphabetLowerCase.Add((char)('a' + i), 1 + i);
            }

            var input = Console.ReadLine().Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var sums = new List<double>();
            foreach (var entry in input)
            {
                var sum = 0.0;
                var numStrung = "";
                for (int i = 1; i < entry.Length -1; i++)
                {
                    numStrung += entry[i];
                }
                var number = double.Parse(numStrung);
                if (alphabetLowerCase.ContainsKey(entry[0]))
                {
                    sum += number * secondNumLowerFirst(entry, alphabetLowerCase);
                }
                else if (alphabetUpperCase.ContainsKey(entry[0]))
                {
                    sum += number / secondNumUpperFirst(entry, alphabetUpperCase);
                }

                if (alphabetLowerCase.ContainsKey(entry[entry.Length - 1]))
                {
                    sum += secondNumLowerLast(entry, alphabetLowerCase);
                }
                else if (alphabetUpperCase.ContainsKey(entry[entry.Length - 1]))
                {
                    sum -= secondNumUpperLast(entry, alphabetUpperCase);
                }
                sums.Add(sum);
            }
            Console.WriteLine($"{sums.Sum():F2}");
        }

        private static double secondNumLowerFirst(string entry, Dictionary<char, double> alphabetLowerCase)
        {
            var number = 0.0;
            foreach (var letter in alphabetLowerCase)
            {
                if (letter.Key == entry[0])
                {
                    number = letter.Value;
                }
            }
            return number;
        }
        private static double secondNumLowerLast(string entry, Dictionary<char, double> alphabetLowerCase)
        {
            var number = 0.0;
            foreach (var letter in alphabetLowerCase)
            {
                if (letter.Key == entry[entry.Length -1])
                {
                    number = letter.Value;
                }
            }
            return number;
        }

        public static double secondNumUpperFirst(string entry, Dictionary<char, double> alphabetUpperCase)
        {
            var number = 0.0;
            foreach (var letter in alphabetUpperCase)
            {
                if (letter.Key == entry[0])
                {
                    number = letter.Value;
                }
            }
            return number;
        }
        public static double secondNumUpperLast(string entry, Dictionary<char, double> alphabetUpperCase)
        {
            var number = 0.0;
            foreach (var letter in alphabetUpperCase)
            {
                if (letter.Key == entry[entry.Length - 1])
                {
                    number = letter.Value;
                }
            }
            return number;
        }

    }
}
