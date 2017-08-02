namespace MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstWord = input[0];
            var secondWord = input[1];
            var minLen = Math.Min(firstWord.Length, secondWord.Length);
            var maxLen = Math.Max(firstWord.Length, secondWord.Length);
            var matched = new Dictionary<char, char>();
            bool isExchangable = false;

            for (int i = 0; i < minLen; i++)
            {
                if (!matched.ContainsKey(firstWord[i]))
                {
                    if (!matched.ContainsValue(secondWord[i]))
                    {
                        matched[firstWord[i]] = secondWord[i];
                    }
                }
                else
                {
                    if (matched[firstWord[i]] == secondWord[i])
                    {
                        isExchangable = true;
                        continue;
                    }
                    else
                    {
                        isExchangable = false;
                        break;
                    }
                }
            }
            for (int i = minLen; i < maxLen; i++)
            {
                if (firstWord.Length > secondWord.Length)
                {
                    if (matched.Keys.Contains(firstWord[i]))
                    {
                        isExchangable = true;
                    }
                    else
                    {
                        isExchangable = false;
                        break;
                    }
                }
                else
                {
                    if (matched.Values.Contains(secondWord[i]))
                    {
                        isExchangable = true;
                    }
                    else
                    {
                        isExchangable = false;
                        break;
                    }
                }
            }
            if (isExchangable)
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
