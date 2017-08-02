namespace TakeOrSkipRope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class TakeOrSkipRope
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var numbersArr = GetInputNumbers(input);
            var symbolsArr = GetInputSymbols(input);
            var takeList = new List<int>();
            var skipList = new List<int>();
            var result = new List<string>();
            for (int i = 0; i < numbersArr.Count; i++)
            {
                if ((i + 1) % 2 == 0 )
                {
                    skipList.Add(numbersArr[i]);
                }
                else
                {
                    takeList.Add(numbersArr[i]);
                }
            }
            var skipCounter = 0;
            for (int i = 0; i < Math.Min(takeList.Count,skipList.Count); i++)
            {
                result.Add(new string(symbolsArr.Skip(skipCounter).Take(takeList[i]).ToArray()));
                skipCounter += skipList[i] + takeList[i];    
            }
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static char[] GetInputSymbols(string input)
        {
            var regForNoneNumbers = new Regex(@"[^\d]");
            var lettersArr = new List<char>();
            var letters = regForNoneNumbers.Matches(input);
            foreach (Match l in letters)
            {
                lettersArr.Add(char.Parse(l.Value));
            }
            return lettersArr.ToArray();
        }

        public static List<int> GetInputNumbers(string input)
        {
            var regForNumbers = new Regex(@"[\d]");
            var numbers = regForNumbers.Matches(input);
            var numbersArr = new List<int>();
            foreach (Match num in numbers)
            {
                numbersArr.Add(int.Parse(num.Value));
            }
            return numbersArr;
        }
    }
}
