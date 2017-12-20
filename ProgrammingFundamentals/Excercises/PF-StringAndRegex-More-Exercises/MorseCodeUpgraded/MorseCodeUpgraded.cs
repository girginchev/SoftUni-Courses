namespace MorseCodeUpgraded
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MorseCodeUpgraded
    {
        public static void Main()
        {
            var codes = Console.ReadLine().Split('|');
            var message = new StringBuilder();

            foreach (var code in codes)
            {
                var digitSum = 0;
                var totalSum = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    if (code[i] == '0')
                    {
                        digitSum += 3;
                    }
                    else if (code[i] == '1')
                    {
                        digitSum += 5;
                    }
                }
                totalSum = digitSum;
                var counter = 1;
                var totalCount = new List<int>();
                for (int i = 1; i < code.Length; i++)
                {
                    if (code[i] == code[i-1])
                    {
                        if (i == (code.Length - 1))
                        {
                            counter++;
                            totalCount.Add(counter);
                            break;
                        }
                        counter++;
                    }
                    else
                    {
                        if (counter>1)
                        {
                        totalCount.Add(counter);

                        }
                        counter = 1;
                    }
                }
                totalSum += totalCount.Sum();
                message.Append((char)totalSum);
            }
            Console.WriteLine(message.ToString());
        }
    }
}
