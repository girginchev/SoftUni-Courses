namespace EmailMe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EmailMe
    {
        public static void Main()
        {
            var email = Console.ReadLine().Split('@').ToArray();
            var firstPart = email[0];
            var secPart = email[1];

            var firstPartCharsSum = 0;
            var secPartCharsSum = 0;

            foreach (var element in firstPart)
            {
                firstPartCharsSum += (int)(element);
            }
            foreach (var element in secPart)
            {
                secPartCharsSum += element;
            }
            if (firstPartCharsSum - secPartCharsSum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
