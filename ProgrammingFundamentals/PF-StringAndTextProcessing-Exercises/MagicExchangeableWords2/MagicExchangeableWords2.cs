namespace MagicExchangeableWords2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class MagicExchangeableWords2
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var matches = new Dictionary<char, char>();
            var firstWord = input[0];
            var secondWord = input[1];
            var minLenght = Math.Min(firstWord.Length, secondWord.Length);
            var isExchangeable = true;

            for (int i = 0; i < minLenght; i++)
            {
                if (!matches.Keys.Contains(firstWord[i]))
                {
                    if (!matches.Values.Contains(secondWord[i]))
                    {
                        matches.Add(firstWord[i], secondWord[i]);
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }
                }
                else
                {
                    if (matches[firstWord[i]] == secondWord[i])
                    {
                        isExchangeable = true;
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            var longerWord = firstWord.Length > secondWord.Length ? firstWord : secondWord;

            for (int i = minLenght; i < longerWord.Length; i++)
            {
                if (matches.ContainsValue(longerWord[i]) || matches.ContainsKey(longerWord[i]))
                {
                    isExchangeable = true;
                }
                else
                {
                    isExchangeable = false;
                    break;
                }
            }

            if (isExchangeable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
